using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;
using LukeFZ.Shared;
using MemoryPack;
using PRISM.Definitions;

namespace PrismCatalogDownloader;

internal class ValueTupleDictionaryConverter : JsonConverter<Dictionary<ValueTuple<int, int>, MstHairstyleResource>>
{
    public override Dictionary<(int, int), MstHairstyleResource> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var baseDict =
            JsonSerializer.Deserialize<Dictionary<string, MstHairstyleResource>>(ref reader, options)!;

        var actualDict = new Dictionary<ValueTuple<int, int>, MstHairstyleResource>();

        foreach (var (key, value) in baseDict)
        {
            var vals = key.Split("/");
            actualDict[(int.Parse(vals[0]), int.Parse(vals[1]))] = value;
        }

        return actualDict;
    }

    public override void Write(Utf8JsonWriter writer, Dictionary<(int, int), MstHairstyleResource> value, JsonSerializerOptions options)
    {
        var dict = new Dictionary<string, MstHairstyleResource>(value.Count);

        foreach (var (key, val) in value)
        {
            dict[$"{key.Item1}/{key.Item2}"] = val;
        }

        JsonSerializer.Serialize(writer, dict, options);
    }
}

internal class Program
{
    private static readonly HttpClient Client = new();

    private static readonly JsonSerializerOptions Options = new()
    {
        Converters = {new JsonStringEnumConverter(), new ValueTupleDictionaryConverter()}
    };

    private static async Task Main(string[] args)
    {
        if (2 > args.Length)
        {
            Console.WriteLine("Usage: PrismCatalogDownloader.exe <GameVersion> <ResourceVersion> [OutputPath]");
            Console.WriteLine("Example: PrismCatalogDownloader.exe 1.0.4 10000300@3PYTsQ2KhKxntVCcPFAlFV8= assets");
            return;
        }

        var bundleVersion = args[0];
        var resourceVersion = args[1];

        if (!resourceVersion.Contains('@'))
        {
            Console.WriteLine("Invalid resource version provided.");
            return;
        }

        var parts = resourceVersion.Split("@");
        var simpleVersion = parts[0];
        var catalogInfoEncoded = parts[1];

        //var paddingVal = catalogInfoEncoded.Length % 4;
        //if (paddingVal != 0)
        //    for (int i = 0; i < 4 - paddingVal; i++)
        //        catalogInfoEncoded += "=";

        var outputPath = Path.GetFullPath(
            args.Length > 2 
                ? args[2] 
                : $"output_{bundleVersion}_{resourceVersion.Replace('@', '_')}");

        Directory.CreateDirectory(outputPath);

        var rootHash = HashUtils.Crc64($"{bundleVersion}:{simpleVersion}");
        var manifest = CatalogManifest.FromCatalogInfo(catalogInfoEncoded, rootHash);

        var list = new Dictionary<string, List<ReadableCatalogEntry>>();
        await DumpAndParseCatalog(outputPath, "root", manifest, list);
            
        await File.WriteAllTextAsync(Path.Join(outputPath, "assetinfo.json"), JsonSerializer.Serialize(list, Options));

        var rawFolder = Path.Join(outputPath, "root", "raw");
        var localizeText = Path.Join(rawFolder, "localizetext.bytes");
        if (File.Exists(localizeText))
        {
            var bytes = await File.ReadAllBytesAsync(localizeText);
            var dict = MemoryPackSerializer.Deserialize<Dictionary<string, Dictionary<int, string>>>(bytes,
                MemoryPackSerializerOptions.Utf16);
                
            await File.WriteAllTextAsync(Path.Join(rawFolder, "localizetext.json"), JsonSerializer.Serialize(dict));
        }

        var masterData = Path.Join(rawFolder, "masterdata.bytes");
        if (File.Exists(masterData))
        {
            var bytes = await File.ReadAllBytesAsync(masterData);
            var dict = MemoryPackSerializer.Deserialize<MasterData>(bytes,
                MemoryPackSerializerOptions.Utf16);
                
            await File.WriteAllTextAsync(Path.Join(rawFolder, "masterdata.json"), JsonSerializer.Serialize(dict));
        }
    }

    private static async Task DumpAndParseCatalog(string outputDirectory, string label, CatalogManifest manifest, Dictionary<string, List<ReadableCatalogEntry>> catalogs)
    {
        var encodedCatalog = await DownloadFile(manifest.GetRealName());
        if (encodedCatalog == null)
            return;

        var subOutputDirectory = Path.Join(outputDirectory, label);
        Directory.CreateDirectory(subOutputDirectory);

        var catalogCatalog = CatalogBinaryParser.ParseEncoded(manifest, encodedCatalog);
        catalogs[label] = DumpCatalog(subOutputDirectory, catalogCatalog);

        foreach (var entry in catalogCatalog.Entries)
        {
            if (catalogCatalog.Types[entry.TypeIdx] == "catalog")
            {
                Console.WriteLine($"Dumping catalog {entry.Label}.");
                await DumpAndParseCatalog(subOutputDirectory, entry.Label, entry.AsManifest(), catalogs);
            }
        }
    }

    private static List<ReadableCatalogEntry> DumpCatalog(string outputDirectory, CatalogBinary catalog)
    {
        List<ReadableCatalogEntry> entries = [];

        foreach (var info in catalog.Entries)
        {
            var name = $"{info.Label}.{catalog.Types[info.TypeIdx]}";
            var url = info.AsManifest().GetRealName();

            entries.Add(new ReadableCatalogEntry(name, url, info.ResourceType));

            if (catalog.Types[info.TypeIdx] == "catalog")
                continue;

            Console.WriteLine($"Downloading {name}...");
            if (name.Contains('/'))
                Directory.CreateDirectory(Path.Join(outputDirectory, Path.GetDirectoryName(name)));

            DownloadAsset(Path.Join(outputDirectory, name), info);
            //foreach (var contents in info.ContentAddressCrcs)
            //{
            //    Console.WriteLine($"\tContains: {contents}");
            //}
        }

        return entries;
    }

    private static void DownloadAsset(string outputPath, CatalogBinaryEntry entry)
    {
        var fileData = DownloadFile(entry.AsManifest().GetRealName()).Result;
        if (fileData == null)
            return;

        var actualFileData = entry.ResourceType switch
        {
            ResourceType.BundlePlain => fileData,
            ResourceType.RawPlain => fileData,
            ResourceType.BundlePaddedStart => fileData.AsSpan(4),
            ResourceType.RawLz4Compressed => Lz4.DecompressFrame(fileData),
            ResourceType.RawEncrypted => Decrypt(fileData),
            _ => throw new UnreachableException()
        };

        using var fs = File.OpenWrite(outputPath);
        fs.Write(actualFileData);
        return;

        ReadOnlySpan<byte> Decrypt(byte[] encrypted)
        {
            var keyMaterial = (stackalloc byte[24]);
            var writer = SpanWriter.BigEndian(keyMaterial);
            writer.WriteUInt64(entry.Seed);
            writer.WriteUInt64(entry.LabelCrc);
            writer.WriteUInt64(entry.Size);

            var hash = SHA1.HashData(keyMaterial);
            var key = hash[..16];
            var iv = hash[4..20];

            var data = encrypted.AsSpan();
            AesCtr.Decrypt(data, key, iv);
            return Lz4.DecompressFrame(data);
        }
    }

    private static string ToUrl(string realName)
        => $"https://asset.imassc.song4.prism.bn765.com/r/{realName[..2]}/{realName}";

    private static async Task<byte[]?> DownloadFile(string realName)
    {
        var req = new HttpRequestMessage(HttpMethod.Get, ToUrl(realName));
        var resp = await Client.SendAsync(req);
        if (!resp.IsSuccessStatusCode)
        {
            Console.WriteLine($"The file {realName} does not exist on the remote server.");
            return null;
        }

        return await resp.Content.ReadAsByteArrayAsync();
    }

    private record ReadableCatalogEntry(string Name, string Path, ResourceType Type);
}
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using LukeFZ.Shared;

namespace PrismCatalogDownloader;

public static class CatalogBinaryParser
{
    private static readonly byte[] EncodedTempBuffer = new byte[8 + 8 + 10 + 16];

    public static CatalogBinary ParseEncoded(CatalogManifest manifest, byte[] data)
    {
        var writer = SpanWriter.BigEndian(EncodedTempBuffer);
        writer.WriteBytes(Convert.FromHexString("E040926FB42EBD50886A8849E5545924"));
        writer.WriteUInt64(manifest.Seed);
        writer.WriteUInt64(manifest.LabelCrc);
        writer.WriteVarUInt64(manifest.Size);

        var hash = SHA1.HashData(EncodedTempBuffer.AsSpan(0, writer.Offset));

        var key = hash[..16];
        var iv = hash[4..20];

        var span = data.AsSpan();
        AesCtr.Decrypt(span, key, iv);
        return ParseCompressed(span);
    }

    public static CatalogBinary ParseCompressed(ReadOnlySpan<byte> data)
    {
        return Parse(Lz4.DecompressFrame(data));
    }

    public static CatalogBinary Parse(ReadOnlySpan<byte> data)
    {
        var reader = new SpanReader(data, littleEndian: false);
        var ascii = Encoding.ASCII;

        var magic = reader.ReadUInt16();
        if (magic != 0xbc10)
            throw new InvalidDataException("Invalid Magic.");

        var entryCount = reader.ReadVarUInt32();
        var typeCount = reader.ReadVarUInt32();
        var groupCount = reader.ReadVarUInt32();

        var types = new Dictionary<int, string>();
        for (int i = 0; i < typeCount; i++)
        {
            types[i] = reader.ReadNullTerminatedString();
        }

        var groupStrings = new Dictionary<int, string>();
        var groups = new Dictionary<int, uint>();
        for (int i = 0; i < groupCount; i++)
        {
            groupStrings[i] = reader.ReadNullTerminatedString();
            groups[i] = HashUtils.Crc32(ascii.GetBytes(groupStrings[i]));
        }

        var entries = new CatalogBinaryEntry[entryCount];

        var groupRelations = new Dictionary<uint, List<int>>();
        var revMap = new Dictionary<string, int>();

        // Loading Structure of Arrays
        for (int i = 0; i < entryCount; i++)
        {
            entries[i].Priority = reader.ReadVarInt32();
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].ResourceType = (ResourceType)reader.ReadVarInt32();
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].NumDeps = reader.ReadVarInt32();
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].NumContents = reader.ReadVarInt32();
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].NumGroups = reader.ReadVarInt32();
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].Size = reader.ReadVarUInt64();
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].TypeIdx = reader.ReadVarInt32();
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].ContentTypes = new string[entries[i].NumContents];

            for (int j = 0; j < entries[i].NumContents; j++)
            {
                entries[i].ContentTypes[j] = types[reader.ReadVarInt32()];
            }
        }

        for (int i = 0; i < entryCount; i++)
        {
            var arr = new byte[4 * entries[i].NumGroups];
            var writer = SpanWriter.BigEndian(arr);

            for (int j = 0; j < entries[i].NumGroups; j++)
            {
                var groupId = groups[reader.ReadVarInt32()];
                writer.WriteUInt32(groupId);

                if (!groupRelations.TryGetValue(groupId, out var list))
                {
                    list = [];
                    groupRelations[groupId] = list;
                }

                list.Add(i);
            }

            entries[i].GroupsChecksum = HashUtils.Crc32(arr);
        }

        for (int i = 0; i < entryCount; i++)
        {
            var label = reader.ReadNullTerminatedString();

            var crc = HashUtils.Crc64(ascii.GetBytes(label));
            crc = HashUtils.Crc64("."u8, crc);
            crc = HashUtils.Crc64(ascii.GetBytes(types[entries[i].TypeIdx]), crc);

            entries[i].Label = label;
            entries[i].LabelCrc = crc;

            // This is also actually the CRC but I use the label
            revMap[entries[i].Label] = i;
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].ContentAddressCrcs = new byte[8 * entries[i].NumContents];
            var writer = SpanWriter.BigEndian(entries[i].ContentAddressCrcs);
            //entries[i].ContentAddressCrcs = new string[entries[i].NumContents];
            for (int j = 0; j < entries[i].NumContents; j++)
            {
                var address = reader.ReadNullTerminatedString();

                var crc = HashUtils.Crc64(ascii.GetBytes(address));
                crc = HashUtils.Crc64("."u8, crc);
                crc = HashUtils.Crc64(ascii.GetBytes(entries[i].ContentTypes[j]), crc);
                writer.WriteUInt64(crc);
                //entries[i].ContentAddressCrcs[j] = reader.ReadNullTerminatedString();
            }
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].DepCrcs = new byte[8 * entries[i].NumDeps];
            var writer = SpanWriter.BigEndian(entries[i].DepCrcs);
            //entries[i].DepCrcs = new string[entries[i].NumDeps];
            for (int j = 0; j < entries[i].NumDeps; j++)
            {
                var dep = reader.ReadNullTerminatedString();
                var crc = HashUtils.Crc64(ascii.GetBytes(dep));
                writer.WriteUInt64(crc);
            }

            entries[i].NumRecDepCrcs = entries[i].NumDeps;
            entries[i].RecDepCrcs = entries[i].DepCrcs;
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].Checksum = reader.ReadUInt64();
        }

        for (int i = 0; i < entryCount; i++)
        {
            entries[i].Seed = (reader.Peek & 0x80) != 0 ? reader.ReadUInt64() : reader.ReadByte();
        }

        Debug.Assert(reader.Offset == data.Length);

        return new CatalogBinary(types, groups, entries);
    }
}

public record CatalogBinary(
    Dictionary<int, string> Types,
    Dictionary<int, uint> Groups,
    CatalogBinaryEntry[] Entries);

public record struct CatalogBinaryEntry
{
    public int Priority { get; set; } // 0x0
    public ResourceType ResourceType { get; set; } // 0x4
    public int NumDeps { get; set; } // 0x8
    public int NumContents { get; set; } // 0xc
    public int NumGroups { get; set; } // 0x10
    public ulong Size { get; set; } // 0x18
    public string Label { get; set; } // 0x20
    public int TypeIdx { get; set; } // 0x30
    public uint GroupsChecksum { get; set; } // 0x34
    public ulong LabelCrc { get; set; } // 0x38
    public byte[] ContentAddressCrcs { get; set; } // 0x40 // 64-bit CRC per Content
    public byte[] DepCrcs { get; set; } // 0x48 // 64-bit CRC per Dep
    public byte[] RecDepCrcs { get; set; } // 0x50
    public int NumRecDepCrcs { get; set; } // 0x58
    public ulong Checksum { get; set; } // 0x60
    public ulong Seed { get; set; } // 0x68
    public string[] ContentTypes { get; set; } // 0x70

    public readonly CatalogManifest AsManifest()
        => new(LabelCrc, Size, Checksum, Seed);
}

public enum ResourceType
{
    BundlePlain = 0,
    BundlePaddedStart,
    RawPlain = 64,
    RawLz4Compressed, // Pack1
    RawEncrypted // Pack2
}
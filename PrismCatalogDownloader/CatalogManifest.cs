using System.Security.Cryptography;
using LukeFZ.Shared;

namespace PrismCatalogDownloader;

public record CatalogManifest(ulong LabelCrc, ulong Size, ulong Checksum, ulong Seed)
{
    public string GetRealName()
    {
        var data = (stackalloc byte[8 + 10 + 8]);
        var writer = SpanWriter.BigEndian(data);
        writer.WriteUInt64(Checksum);
        writer.WriteVarUInt64(Size);
        writer.WriteUInt64(LabelCrc);

        var hash = MD5.HashData(data[..writer.Offset]);
        return Base32.FromBytes(hash);
    }

    public static CatalogManifest FromCatalogInfo(string encodedInfo, ulong rootNameHash)
    {
        var info = Convert.FromBase64String(encodedInfo);
        var reader = new SpanReader(info, littleEndian: false);

        var checksum = reader.ReadUInt64();
        var size = reader.ReadVarUInt64();
        var seed = reader.ReadUInt64();

        return new CatalogManifest(rootNameHash, size, checksum, seed);
    }
}
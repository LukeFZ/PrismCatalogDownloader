namespace PrismCatalogDownloader;

public static class HashUtils
{
    private static readonly ulong[] Crc64Table = new ulong[256];
    private static readonly uint[] Crc32Table = new uint[256];

    static HashUtils()
    {
        for (var i = 0uL; i < 256u; i++)
        {
            const ulong top = 1uL << 63;

            var val = i << 56;

            for (int j = 0; j < 8; j++)
            {
                if ((val & top) != 0)
                    val = (val << 1) ^ 0x42F0E1EBA9EA3693uL;
                else
                    val <<= 1;
            }

            Crc64Table[i] = val;
        }

        for (var i = 0u; i < 256u; i++)
        {
            var val = i;

            for (int j = 0; j < 8; j++)
            {
                if ((val & 1) != 0)
                    val = (val >> 1) ^ 0xEDB88320;
                else
                    val >>= 1;
            }

            Crc32Table[i] = val;
        }
    }

    public static ulong Crc64(ReadOnlySpan<char> source, ulong crc = 0)
    {
        for (var i = 0; i < source.Length; i++)
            crc = Crc64Table[source[i] ^ (crc >> 56)] ^ (crc << 8);

        return crc;
    }

    public static ulong Crc64(ReadOnlySpan<byte> source, ulong crc = 0)
    {
        for (var i = 0; i < source.Length; i++)
            crc = Crc64Table[source[i] ^ (crc >> 56)] ^ (crc << 8);

        return crc;
    }

    public static uint Crc32(ReadOnlySpan<char> source, uint crc = 0xffffffff)
    {
        for (var i = 0; i < source.Length; i++)
            crc = Crc32Table[(source[i] ^ crc) & 0xff] ^ (crc >> 8);

        return crc;
    }

    public static uint Crc32(ReadOnlySpan<byte> source, uint crc = 0xffffffff)
    {
        for (var i = 0; i < source.Length; i++)
            crc = Crc32Table[(source[i] ^ crc) & 0xff] ^ (crc >> 8);

        return ~crc;
    }
}
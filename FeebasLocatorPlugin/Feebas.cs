namespace FeebasLocatorPlugin;

public static class Feebas3
{
    public static ushort[] GetTiles(uint seed)
    {
        short i = 0;
        ushort[] tiles = new ushort[6] { 0, 0, 0, 0, 0, 0 };
        ushort tile;

        while (i < tiles.Length)
        {
            seed = (0x41C64E6D * seed) + 0x3039;
            tile = (ushort)((seed >> 16) % 0x1BF);

            if (tile == 0)
                tile = 447;

            if (tile >= 4)
            {
                tiles[i] = tile;
                i++;
            }
        }
        return tiles;
    }

    public static bool IsAccessible(ushort tile) => tile is not (< 4 or > 447 or 105 or 119 or 132 or 144 or 296 or 297 or 298);
    public static bool IsUnderBridge(ushort tile) => tile is 132;
}

public static class Feebas4
{
    public static ushort[] GetTiles(uint seed)
    {
        ushort[] tiles = new ushort[4] { 0, 0, 0, 0 };

        for (short i = 0; i < tiles.Length; i++)
        {
            tiles[i] = (ushort)((((seed >> (24 - 8 * i)) & 0xFF) % 0x84) + (0x84 * i));
        }
        return tiles;
    }

    public static bool IsAccessible(ushort tile) => tile is not (< 0 or > 528);
}

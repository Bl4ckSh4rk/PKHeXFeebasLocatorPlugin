namespace FeebasLocatorPlugin
{
    public static class Feebas3
    {
        public static uint[] GetTiles(uint seed)
        {
            int i = 0;
            uint[] tiles = new uint[6] { 0, 0, 0, 0, 0, 0 };
            uint tile = 0;

            while (i < 6)
            {
                seed = (0x41C64E6D * seed) + 0x3039;
                tile = (((seed >> 16)) % 0x1BF);

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

        public static bool IsAccessible(uint tile)
        {
            return tile switch
            {
                < 4 or > 447 or 105 or 119 or 132 or 144 or 296 or 297 or 298 => false,
                _ => true
            };
        }

        public static bool IsUnderBridge(uint tile)
        {
            return tile switch
            {
                132 => true,
                _ => false
            };
        }
    }

    public static class Feebas4
    {
        public static uint[] GetTiles(uint seed)
        {
            int i = 0;
            uint[] tiles = new uint[4] { 0, 0, 0, 0 };

            while (i < 4)
            {
                tiles[i] = (uint)((((seed >> (24 - 8 * i)) & 0xFF) % 0x84) + (0x84 * i));
                i++;
            }
            return tiles;
        }

        public static bool IsAccessible(uint tile)
        {
            return tile switch
            {
                < 0 or > 528 => false,
                _ => true
            };
        }
    }
}

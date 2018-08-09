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
            if (tile < 4 || tile > 447 || tile == 105 || tile == 119 || tile == 132 || tile == 144 || tile == 296 || tile == 297 || tile == 298)
                return false;
            return true;
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
            if (tile < 0 || tile > 528)
                return false;
            return true;
        }
    }
}

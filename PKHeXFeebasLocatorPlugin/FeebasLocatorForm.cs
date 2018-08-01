using System;
using System.Drawing;
using PKHeX.Core;
using System.Windows.Forms;

namespace FeebasLocatorPlugin
{
    public partial class FeebasLocatorForm : Form
    {
        private SAV3 sav;
        private uint Seed;
        private int Offset;
        private uint[] Tiles = new uint[6];
        private Panel[] Marker = new Panel[6];

        public FeebasLocatorForm(SAV3 sav)
        {
            InitializeComponent();
            for (int i = 0; i < Marker.Length; i++)
                Marker[i] = new Panel();

            this.sav = sav;

            if (sav.RS)
                Offset = this.sav.GetBlockOffset(3) + 0xED6;
            else
                Offset = this.sav.GetBlockOffset(3) + 0xF6A;

            Seed = BitConverter.ToUInt16(this.sav.Data, Offset);
            FeebasSeedBox.Value = Seed;
        }

        private void GetTiles()
        {
            int i = 0;
            uint tile = 0;

            while (i < 6)
            {
                Seed = (0x41C64E6D * Seed) + 0x3039;
                tile = (((Seed >> 16)) % 0x1BF);

                if (tile == 0)
                    tile = 447;

                if (tile >= 4)
                {
                    Tiles[i] = tile;
                    i++;
                }
            }
        }

        private void MarkTiles()
        {
            for (int i = 0; i < Tiles.Length; i++)
            {
                int location = (int)GetTileLocation(Tiles[i]);
                int x = ((location % 40) * 16) + 1;
                int y = (((location - (location % 40)) / 40) * 16) + 1;
                    
                Marker[i].BackColor = Color.Transparent;
                Marker[i].BackgroundImage = Properties.Resources.marker;
                Marker[i].Location = new Point(x, y);
                Marker[i].Name = "Marker" + i;
                Marker[i].Size = new Size(15, 15);
                Marker[i].Visible = location != 0; // only show valid locations

                TilePanel.Controls.Add(Marker[i]);
            }
        }

        private static uint GetTileLocation(uint tile)
        {
            if (tile == 105 || tile == 119 || tile == 132 || tile == 144 || tile == 296 || tile == 297 || tile == 298)
                return 0; // tile is not accessible

            return PossibleTileLocations[tile - 4]; // tile 0 - 3 are invalid as well
        }

        private static uint[] PossibleTileLocations =
        {
            58, 98, 99, 136, 137, 138, 139, 177, 178, 179,
            217, 218, 219, 257, 258, 259, 297, 298, 299, 497,
            498, 499, 537, 538, 539, 576, 577, 578, 579, 580,
            616, 617, 618, 619, 620, 736, 737, 738, 739, 740,
            776, 777, 778, 779, 780, 816, 817, 818, 819, 820,
            856, 857, 858, 859, 860, 861, 862, 896, 897, 898,
            899, 900, 901, 902, 936, 937, 938, 939, 940, 941,
            942, 976, 977, 978, 979, 980, 981, 982, 1016, 1017,
            1018, 1019, 1020, 1021, 1022, 1023, 1056, 1057, 1058, 1059,
            1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069,
            1070, 1099, 1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107,
            1108, 1109, 1110, 1111, 1112, 1140, 1141, 1142, 1143, 1144,
            1145, 1146, 1147, 1148, 1149, 1150, 1151, 1152, 1183, 1184,
            1185, 1186, 1187, 1188, 1189, 1190, 1191, 1192, 1193, 1194,
            1227, 1228, 1229, 1230, 1231, 1232, 1233, 1234, 1270, 1271,
            1272, 1273, 1274, 1311, 1312, 1313, 1314, 1315, 1351, 1352,
            1353, 1391, 1392, 1393, 1431, 1432, 1433, 1434, 1435, 1471,
            1472, 1473, 1474, 1475, 1513, 1514, 1515, 1553, 1554, 1555,
            1591, 1592, 1593, 1594, 1595, 1631, 1632, 1633, 1634, 1635,
            1670, 1671, 1672, 1673, 1674, 1675, 1707, 1708, 1709, 1710,
            1711, 1712, 1713, 1714, 1746, 1747, 1748, 1749, 1750, 1751,
            1752, 1753, 1786, 1787, 1788, 1789, 1790, 1791, 1826, 1827,
            1828, 1829, 1830, 1831, 1866, 1867, 1868, 1869, 1870, 1871,
            1872, 1904, 1905, 1906, 1907, 1908, 1909, 1944, 1945, 1946,
            1947, 1948, 1982, 1983, 1984, 1985, 1986, 1987, 1988, 2022,
            2023, 2024, 2025, 2026, 2027, 2028, 2062, 2063, 2064, 2065,
            2066, 2100, 2101, 2102, 2103, 2104, 2105, 2106, 2140, 2141,
            2142, 2143, 2144, 2145, 2180, 2181, 2182, 2183, 2184, 2185,
            2220, 2221, 2222, 2223, 2224, 2225, 2260, 2261, 2262, 2263,
            2301, 2341, 2661, 2662, 2663, 3254, 3294, 3334, 3335, 3336,
            3339, 3340, 3343, 3344, 3374, 3375, 3376, 3377, 3378, 3379,
            3380, 3381, 3382, 3383, 3384, 3414, 3415, 3416, 3417, 3418,
            3419, 3420, 3421, 3422, 3423, 3424, 3454, 3455, 3456, 3457,
            3458, 3459, 3460, 3461, 3462, 3463, 3464, 3494, 3495, 3496,
            3497, 3498, 3499, 3500, 3501, 3502, 3503, 3504, 3505, 3534,
            3535, 3536, 3537, 3538, 3539, 3540, 3541, 3542, 3543, 3544,
            3545, 3569, 3570, 3571, 3572, 3573, 3574, 3575, 3576, 3577,
            3578, 3579, 3580, 3583, 3584, 3585, 3607, 3608, 3609, 3610,
            3611, 3612, 3613, 3614, 3615, 3616, 3617, 3618, 3619, 3620,
            3623, 3624, 3625, 3649, 3650, 3651, 3652, 3653, 3654, 3655,
            3656, 3657, 3658, 3659, 3660, 3661, 3662, 3663, 3664, 3665,
            3689, 3690, 3691, 3692, 3693, 3694, 3695, 3696, 3697, 3698,
            3699, 3700, 3701, 3702, 3703, 3728, 3729, 3730, 3731, 3732,
            3733, 3734, 3735, 3736, 3737, 3738, 3739, 3768, 3769, 3770,
            3771, 3772, 3807, 3808
        };

        private void FeebasSeedBox_ValueChanged(object sender, EventArgs e)
        {
            Seed = (uint)FeebasSeedBox.Value;
            GetTiles();
            MarkTiles();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            sav.SetData(BitConverter.GetBytes((uint)FeebasSeedBox.Value), Offset);
            Close();
        }
    }
}

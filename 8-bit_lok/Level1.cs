using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_bit_lok
{
    
    class Level1
    {
        Gcs game = new Gcs();
        private static Gengin.TextID[,] blocks = new Gengin.TextID[Gcs.level_w, Gcs.level_h];

        public static Gengin.TextID[,] Blocks
        {
            get { return blocks; }
            set { blocks = value; }
        }

        public static void initlevel()
        {
            for (int x = 0; x < Gcs.level_w; x++)
            {
                 for (int y = 0; y < Gcs.level_h; y++)
            {
                if (y >= 11)
                {
                    blocks[x, y] = Gengin.TextID.dirt;
                }
                else
                {
                    blocks[x, y] = Gengin.TextID.air;
                }
            }
            }
        }

    }
}

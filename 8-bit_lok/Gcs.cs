using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _8_bit_lok
{
    class Gcs
    {
        public const int can_h = 700;
        public const int can_w = 1200;
        
        private Gengin ge;

        public void startg(Graphics g)
        {
             ge = new Gengin(g);
             ge.init();
        }

        public void stopgame()
        {
            ge.stop();

        }
        
    }
}
 
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
 
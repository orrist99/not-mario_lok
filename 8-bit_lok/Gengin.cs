using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace _8_bit_lok
{
    class Gengin
    {
        /*-----------------Member---------------*/
        private Graphics drawh;
        private Thread renderthred;

        public Gengin(Graphics g)
        {
            drawh = g;
        }

        public void init()
        {
            renderthred = new Thread(new ThreadStart(render));
            renderthred.Start();
        }

        public void stop()
        {
            renderthred.Abort();
        }

        private void render()
        {

            int framesrander = 0;
            long starttime = Environment.TickCount;
            long endtime = 0;
            while (true)
            {
                drawh.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, 1200, 700);

                //test fps
                framesrander++;
                if (Environment.TickCount >= starttime + 1000)
                {
                    Console.Write("runig at " + framesrander + " fps");
                    Console.WriteLine(" ");
                    framesrander = 0;
                    starttime = Environment.TickCount;
                }


            }
        }

    }
}
 
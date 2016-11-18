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

        public const int can_h = 700;
        public const int can_w = 1200;
        /*-----------------Member---------------*/
        private Graphics drawh;
        private Thread renderthred;

        private Bitmap mario_no;
        public Gengin(Graphics g)
        {
            drawh = g;
        }

        public void init()
        {
            loadasset();
            renderthred = new Thread(new ThreadStart(render));
            renderthred.Start();
        }
        private void loadasset()
        {
            mario_no = _8_bit_lok.Properties.Resources.not_mario;
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

            Bitmap frame = new Bitmap(Gcs.can_h, Gcs.can_w);
            Graphics frameGraphics = Graphics.FromImage(frame);

            while (true)
            {
           frameGraphics.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, Gcs.can_w, Gcs.can_h);

           frameGraphics.DrawImage(mario_no, 100, 100);
           drawh.DrawImage(frame, 0, 0);

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
 
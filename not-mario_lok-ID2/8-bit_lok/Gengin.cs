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
        /*--------------asets----------------*/
        private Bitmap mario_no;
        private Bitmap dirte;


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
            dirte = _8_bit_lok.Properties.Resources.dirt;
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

            Bitmap frame = new Bitmap(Gcs.can_w, Gcs.can_h);
            Graphics frameGraphics = Graphics.FromImage(frame);
            TextID[,] textur = Level1.Blocks;



            while (true)
            {
                 frameGraphics.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, Gcs.can_w, Gcs.can_h);

                 for (int x = 0; x < Gcs.level_w; x++)
                 {
                     for (int y = 0; y < Gcs.level_h; y++)
                     {
                         switch (textur[x,y])
                         {
                             case TextID.air:
                                 break;

                             case TextID.dirt:
                                 frameGraphics.DrawImage(dirte, x * Gcs.tille, y * Gcs.tille);
                                 break;
                         }


	
                     }
                 }

                frameGraphics.DrawImage(mario_no, 50, 450);
           
           //drawh.DrawImage(frame, 0, 0);
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
        public enum TextID
        {
            air,
            dirt
        }

    }
}
 
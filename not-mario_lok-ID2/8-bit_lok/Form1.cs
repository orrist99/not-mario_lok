using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace _8_bit_lok
{
    public partial class Form1 : Form
    {  
        bool right;
        bool left;
        bool jump;
        int G = 40;
        int force;
        private Gcs game = new Gcs();

        public Form1()
        {
            InitializeComponent();
        }

        private void canv1_Paint(object sender, PaintEventArgs e)
        {
            game.loadlevel();
            Graphics g = canv1.CreateGraphics();
           // MessageBox.Show("KONNI");
            game.startg(g);
        }

        private void canv1_Leave(object sender, EventArgs e)
        {
            game.stopgame();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        private void time1_Tick(object sender, EventArgs e)
        {



            //vinstri hlið á pipu
            if (player.Right > pipe.Left && player.Left < pipe.Right - player.Width / 2 && player.Bottom > pipe.Top)
            {
                right = false;
            }


            //hægri hlið á pipu
            if (player.Left < pipe.Right && player.Right > pipe.Left + player.Width / 2 && player.Bottom > pipe.Top)
            {
                left = false;
            }


            

            if (right == true)
            {
               player.Left += 5;
            }
            if (left == true)
            {
                player.Left -= 5;
            }

          if (jump == true)
            {
              //ef player hefur hopad adur
                player.Top -= force;
                force -= 1;
            }
          if (player.Top + player.Height >= screen.Height)
          {
              player.Top  = screen.Height - player.Height;//fall hættir á bottinum
              jump = false;
          }
          else
          {
              player.Top += 5;
          }
          
           //top
            
            if (player.Left + player.Width - 1 > pipe.Left && player.Left + player.Width + 5 < pipe.Left + pipe.Width + player.Width && player.Top + player.Height >= pipe.Top && player.Top < pipe.Top)
            {
                player.Top = screen.Height - pipe.Height - player.Height;
                force = 0;
                jump = false;
            }
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();//hætta
            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = G;
                }

              /*  if (player.Top + player.Height >= screen.Height)
                {
                    player.Top = screen.Height - player.Height;
                    jump = false;
                }
                else
                {
                    player.Top += 5;
                }*/
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }


        }

        

     


        
    }
}
 
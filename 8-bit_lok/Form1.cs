using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_bit_lok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        bool jump;
        bool left;
        bool right;
        int g = 30;
        int force;
        //Form1 k = new Form1().ClientSize.Height;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (left == true)
            {
                p1.Left -= 30;
            }
            if (right == true)
            {
                p1.Left += 30;
            }


            if (jump == true)
            {
                p1.Top -= force;
                force -= 4;
                if (force == 0)
                {
                    force = 30;
                    jump = false;
                }
            }


            if (p1.Top + p1.Height >= this.Size.Height )
            {
                p1.Top = this.Size.Height - p1.Height - 30;
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
                this.Close();
            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = 30;
                }
                
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

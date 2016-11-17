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

        bool left;
        bool right;
        bool up;
        bool down;

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

            if (up == true)
            {
                p1.Top += 30;
            }

            if (down == true)
            {
                p1.Top -= 30;
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


            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Down)
            {
             down = true;
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

            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
        } 
    }
}

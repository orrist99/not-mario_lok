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
        private Gcs game = new Gcs();

        public Form1()
        {
            InitializeComponent();
        }

        private void canv1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canv1.CreateGraphics();
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


        
    }
}
 
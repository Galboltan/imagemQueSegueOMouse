using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagemQueSegueOMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = MousePosition.X - pictureBox1.Width;
            pictureBox1.Top = MousePosition.Y - pictureBox1.Height;
        }
    }
}

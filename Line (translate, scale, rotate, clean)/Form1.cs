using System.Windows.Forms;
using System.Drawing;
using System;

namespace Line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 c1 = new Class1();
        Bitmap b = new Bitmap(1000, 1000);

        private void button1_Click(object sender, EventArgs e)
        {
            c1.clean(b);
            c1.line(b, 350, 50, 400, 300);
            pictureBox1.Image = b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1.clean(b);
            pictureBox1.Image = b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c1.clean(b);
            c1.translate(b, 50);
            pictureBox1.Image = b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c1.clean(b);
            c1.rotate(b, 3);
            pictureBox1.Image = b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c1.clean(b);
            c1.scale(b, 2);
            pictureBox1.Image = b;
        }
    }
}

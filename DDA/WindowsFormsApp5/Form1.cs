using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;// it is important for the class bitmap 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// this is a DDA Algorithm 
        {
            Bitmap p = new Bitmap(1000, 1000);
            
            Double x1 = 50,x2=200;
            Double y1 = 50, y2 = 500;
            double dx = x2 - x1;
            double dy = y2 - y1;
            double step;
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
            {
                step = Math.Abs(dy);
            }
            double xinc = dx / step;
            double yinc = dy / step;
            double x = x1, y = y1;
            int xx, yy;
            for (int i = 0; i < step; i++)
            {
                xx = (int)Math.Round(x);
                yy = (int)Math.Round(y);

                p.SetPixel(xx, yy, Color.Black);
                x = x + xinc;
                y = y + yinc;
            }

            pictureBox1.Image = p;
        }
		/*
Bitmap p = new Bitmap(1000, 1000);
// Create a graphics object
using (Graphics g = Graphics.FromImage(p))
{
    Pen pen = new Pen(Color.Black, 3); // black line with thickness = 3
    g.DrawLine(pen, 10, 10, 500, 500); // draw from (10,10) to (500,500)
}
// Show the bitmap in a picturebox (Windows Forms)
pictureBox1.Image = p;

       */
	}
}

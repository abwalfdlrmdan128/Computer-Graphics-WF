using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line
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
		void DrawLine(Bitmap b, int x1, int y1, int x2, int y2)
		{
			int dx = Math.Abs(x2 - x1);
			int dy = Math.Abs(y2 - y1);
			int sx = x1 < x2 ? 1 : -1;
			int sy = y1 < y2 ? 1 : -1;
			int err = dx - dy;

			while (true)
			{
				b.SetPixel(x1, y1, Color.Red);

				if (x1 == x2 && y1 == y2) break;

				int e2 = 2 * err;

				if (e2 > -dy)
				{
					err -= dy;
					x1 += sx;
				}

				if (e2 < dx)
				{
					err += dx;
					y1 += sy;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
        {

            Bitmap b = new Bitmap(1000, 1000);
			DrawLine(b, 350, 200, 50,50);
            //drow(b, 150, 200, 50);
            pictureBox1.Image = b;
        }
}
}

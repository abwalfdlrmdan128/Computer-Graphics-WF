using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line
{
    internal class Class1
    {
        int x_1, y_1, x_2, y_2;

        public void line(Bitmap b, int a1, int b1, int a2, int b2)
        {
            x_1 = a1;
            x_2 = a2;
            y_1 = b1;
            y_2 = b2;

            double dx = a2 - a1;
            double dy = b2 - b1;
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

            double x = a1, y = b1;

            int xx, yy;

            for (int i = 0; i < step; i++)
            {
                xx = (int)Math.Round(x);
                yy = (int)Math.Round(y);

                b.SetPixel(xx, yy, Color.Black);

                x = x + xinc;
                y = y + yinc;
            }
        }

        public void translate(Bitmap b, int t)
        {
            line(b, (x_1 + t), (y_1 + t), (x_2 + t), (y_2 + t));
        }

        public void scale(Bitmap b, int s)
        {
            line(b, (x_1 * s), (y_1 * s), (x_2 * s), (y_2 * s));
        }

        public void rotate(Bitmap b, double s)
        {
            double s_r = s * (3.14 / 180);
            x_2 = (int)(Math.Floor(((Math.Sin(s_r) * -1) * y_2) + (Math.Cos(s_r) * x_2)));
            y_2 = (int)(Math.Floor(((Math.Sin(s_r) * x_2)) + (Math.Cos(s_r) * y_2)));
            x_1 = (int)(Math.Floor(((Math.Sin(s_r) * -1) * y_1) + (Math.Cos(s_r) * x_1)));
            y_1 = (int)(Math.Floor(((Math.Sin(s_r) * x_1)) + (Math.Cos(s_r) * y_1)));
            line(b, x_1, y_1, x_2, y_2);
        }

        public void clean(Bitmap b)
        {
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.White);
        }
    }
}

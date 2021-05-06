using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Drawer
    {
        public static GraphicsPath RoundedRectangle(Rectangle rect, int Roundsize)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(rect.X, rect.Y, Roundsize, Roundsize, 180, 90);
            gp.AddArc(rect.X + rect.Width - Roundsize, rect.Y, Roundsize, Roundsize, 270, 90);
            gp.AddArc(rect.X + rect.Width - Roundsize, rect.Y + rect.Height - Roundsize, Roundsize, Roundsize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - Roundsize, Roundsize, Roundsize, 90, 90);

            gp.CloseFigure();

            return gp;
        }
    }
}

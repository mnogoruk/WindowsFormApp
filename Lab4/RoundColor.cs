using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public class RoundLabel : Label
    {
        private int roundRadius = 10;

        public Color HoverColor { get; set; } = ThemeColors.Hover;
        public Color UnActiveForeColor { get; set; } = ThemeColors.UnActiveForeColor;
        public Color DeafultForeColor { get; set; } = ThemeColors.DeafaultForeColor;
        public Color MainColor { get; set; } = Color.Transparent;
        private Color currentColor;

        private bool active;
        public bool Active
        {
            get => active;
            set
            {
                active = value;
                if (active)
                {
                    OnActivate();

                }
                else
                {
                    OnDeactivate();
                }
            }
        }
        private void OnActivate()
        {
            this.ForeColor = this.DeafultForeColor;
            this.Cursor = Cursors.Hand;
        }

        private void OnDeactivate()
        {
            this.ForeColor = this.UnActiveForeColor;
            this.Cursor = Cursors.Arrow;

        }
        public RoundLabel()
        {
            currentColor = MainColor;
            this.MouseHover += new System.EventHandler(this.MouseHover_Effect);
            this.MouseLeave += new System.EventHandler(this.MouseLeave_Effect);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Brush brush = new SolidBrush(currentColor);

            g.FillPath(brush, Drawer.RoundedRectangle(new Rectangle(0, 0, this.Width - 1, this.Height - 1), RoundRadius));
            brush.Dispose();

            SizeF stringSize = g.MeasureString(Text, Font);
            brush = new SolidBrush(ForeColor);

            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
            brush.Dispose();

        }

        public void MouseHover_Effect(object sender, EventArgs e)
        {
            if (Active)
            {
                this.CurrentColor = this.HoverColor;
            }
        }
        public void MouseLeave_Effect(object sender, EventArgs e)
        {
            if (Active)
            {
                this.CurrentColor = this.MainColor;
            }
        }


        public Color CurrentColor
        {
            get => currentColor;
            set
            {
                currentColor = value;
                Refresh();
            }
        }
        public int RoundRadius
        {
            get => roundRadius;
            set
            {
                if (value < Height && value < Width && value > 0)
                {
                    roundRadius = value;
                    Refresh();
                }
            }
        }
    }
}

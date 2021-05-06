using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        private int increaseWidth = 400;
        private bool increased = false;

        public MainForm()
        {
            InitializeComponent();
            SharedDataContainer.onActivateRectangle += this.activateRectanleButton;
        }

        private void AnimateResizeWidth(int period, int width)
        {
            for (int i = 0; i < 100; i++)
            {
                this.Width += width / 100;
                Task.Delay(period);
            }
            increased = true;

        }


        private void closingCross_MouseHover(object sender, EventArgs e)
        {
            this.closingCross.BackColor = ThemeColors.ActiveClosingCross;
        }

        private void closingCross_MouseLeave(object sender, EventArgs e)
        {
            this.closingCross.BackColor = ThemeColors.ManagingPanel;
        }

        private void closingCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rollUp_MouseHover(object sender, EventArgs e)
        {
            this.rollUp.BackColor = ThemeColors.HoverComponent;
        }

        private void rollUp_MouseLeave(object sender, EventArgs e)
        {
            this.rollUp.BackColor = ThemeColors.ManagingPanel;
        }

        private void rollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        Point lastPoint;
        private void managePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void managePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void siezeItem_Click(object sender, EventArgs e)
        {
            SharedDataContainer.SizeForm.Show();
        }

        private void quitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void activateRectanleButton()
        {
            rectItem.Active = true;
        }

        private void rectItem_Click(object sender, EventArgs e)
        {

            if (rectItem.Active)
            {
                UpdateDrawBox();
                if (SharedDataContainer.RectColorList().Count == 0)
                {
                    drawBoxErrorLabel.Text = Errors.NoColorChosen.Messge;
                    return;
                }
                if (SharedDataContainer.RectSize.Height > drawBox.Height || SharedDataContainer.RectSize.Width > drawBox.Width)
                {
                    drawBoxErrorLabel.Text = Errors.ToolargeForDisplay.Messge;
                    return;
                }
                DrawRectangle();

            }
        }

        private void UpdateDrawBox()
        {
            if (!increased) {
                AnimateResizeWidth(0, increaseWidth);
            }
            drawBox.Update();
            Graphics g = drawBox.CreateGraphics();
            g.Clear(ThemeColors.Background);
            drawBoxErrorLabel.Text = "";

        }

        private void DrawRectangle()
        {
            int count = 0;
            int brushWidth = 5;
            foreach (Color color in SharedDataContainer.RectColorList())
            {
                Size rectSize = SharedDataContainer.RectSize;
                Point initPosition = calcultaeRectStartPosition(rectSize);

                Point margin = new Point(brushWidth * count, brushWidth * count);
                Size marginSize = new Size(brushWidth * count * 2, brushWidth * count * 2);

                rectSize.Width -= marginSize.Width;
                rectSize.Height -= marginSize.Height;
                initPosition.X += margin.X;
                initPosition.Y += margin.Y;


                System.Drawing.Pen myPen = new System.Drawing.Pen(color, brushWidth);
                Graphics formGraphics = drawBox.CreateGraphics();
                formGraphics.DrawRectangle(myPen, new Rectangle(initPosition , rectSize));
                count++;
            }
            
            
        }

        private Point calcultaeRectStartPosition(Size rectSize)
        {
            int x = (drawBox.Width - rectSize.Width) / 2;
            int y =  (drawBox.Height - rectSize.Height) / 2;
            return new Point(x, y);
        }

        private void inputItem_Click(object sender, EventArgs e)
        {
            SharedDataContainer.InputForm.Show();
        }

        private void quitItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void circleItem_Click(object sender, EventArgs e)
        {
            UpdateDrawBox();
            if (SharedDataContainer.CircleRadius > drawBox.Height * 2 || SharedDataContainer.CircleRadius > drawBox.Width * 2)
            {
                drawBoxErrorLabel.Text = Errors.ToolargeForDisplay.Messge;
                return;

            }
            DrawCircle();
        }

        private void DrawCircle()
        {
            int radius = SharedDataContainer.CircleRadius;
            Graphics g = drawBox.CreateGraphics();
            Size size = new Size(radius * 2, radius * 2);
            Point start = calcultaeRectStartPosition(size);
            Rectangle rect = new Rectangle(start, size);
            Pen myPen = new System.Drawing.Pen(Color.AliceBlue, 5);
            g.DrawEllipse(myPen, rect);

        }

        private void calcItem_Click(object sender, EventArgs e)
        {
            SharedDataContainer.CalcForm.Show();
        }

        private void reverseItem_Click(object sender, EventArgs e)
        {
            SharedDataContainer.ReverseForm.Show();
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            SharedDataContainer.AboutForm.Show();
        }
    }
}

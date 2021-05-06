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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
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
            this.Hide();
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

    }
}

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
    public partial class InputForm : Form
    {
        private int radius;
        private bool activeSquare = false;
        private bool activeLength = false;

        private bool correctRadius;

        public InputForm()
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

        private void squareCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            activeSquare = !activeSquare;
        }

        private void radiusTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rad = int.Parse(radiusTextBox.Text);
                if (rad < 0)
                {
                    radiusErrorLabel.Text = Errors.WrongNumberFormat.Messge;
                    correctRadius = false;
                }
                else
                {
                    radius = rad;
                    radiusErrorLabel.Text = "";
                    correctRadius = true;
                }
            }
            catch (FormatException)
            {
                radiusErrorLabel.Text = Errors.WrongNumberFormat.Messge;
                correctRadius = false;
            }
            catch (OverflowException)
            {
                radiusErrorLabel.Text = Errors.TooLargeNumber.Messge;
                correctRadius = false;
            }
        }

        private void lengthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            activeLength = !activeLength;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (correctRadius)
            {
                SharedDataContainer.CircleRadius = radius;
                SharedDataContainer.ActiveLength = activeLength;
                SharedDataContainer.ActiveSquare = activeSquare;
                this.Close();
            }
            else
            {
                enterErrorlabel.Text = Errors.InputError.Messge;
            }
        }
    }
}

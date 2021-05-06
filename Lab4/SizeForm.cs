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
    public partial class SizeForm : Form
    { 
        private Size rectSize = new Size(0, 0);
        private bool activeRed = false;
        private bool activeGreen = false;
        private bool activeBlue = false;

        private bool correctWidth;
        private bool correctHegth;


        public SizeForm()
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

        private void rectangleWidthInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int width = int.Parse(rectangleWidthInput.Text);
                if (width < 0)
                {
                    widthErrorLabel.Text = Errors.WrongNumberFormat.Messge;
                    correctWidth = false;
                }
                else
                {
                    rectSize.Width = width;
                    widthErrorLabel.Text = "";
                    correctWidth = true;
                }
            } catch (FormatException)
            {
                widthErrorLabel.Text = Errors.WrongNumberFormat.Messge;
                correctWidth = false;
            } catch (OverflowException)
            {
                widthErrorLabel.Text = Errors.TooLargeNumber.Messge;
                correctWidth = false;
            }
        }

        private void rectangleLengthInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int height = int.Parse(rectangleLengthInput.Text);
                if (height < 0)
                {
                    legthErrorLabel.Text = Errors.WrongNumberFormat.Messge;
                    correctHegth = false;
                }
                else
                {
                    rectSize.Height = height;
                    legthErrorLabel.Text = "";
                    correctHegth = true;
                }
            }
            catch (FormatException)
            {
                legthErrorLabel.Text =  Errors.WrongNumberFormat.Messge;
                correctHegth = false;
            }
            catch (OverflowException)
            {
                legthErrorLabel.Text = Errors.TooLargeNumber.Messge;
                correctHegth = false;
            }
        }

        private void greenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            activeGreen = !activeGreen;
        }

        private void redCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            activeRed = !activeRed;
        }

        private void blueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            activeBlue = !activeBlue;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (correctHegth && correctWidth)
            {
                SharedDataContainer.ActiveBlue = activeBlue;
                SharedDataContainer.ActiveGreen = activeGreen;
                SharedDataContainer.ActiveRed = activeRed;
                SharedDataContainer.RectSize = rectSize;
                SharedDataContainer.ActiveRectangle = true;
                enterErrorLabel.Text = "";
                this.Close();
            }
            else
            {
                enterErrorLabel.Text = Errors.InputError.Messge;
            }
        }
    }
}

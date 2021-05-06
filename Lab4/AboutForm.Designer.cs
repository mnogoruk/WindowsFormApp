namespace Lab4
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.managePanel = new System.Windows.Forms.Panel();
            this.closingCross = new System.Windows.Forms.PictureBox();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.managePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closingCross)).BeginInit();
            this.SuspendLayout();
            // 
            // managePanel
            // 
            this.managePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.managePanel.Controls.Add(this.closingCross);
            this.managePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.managePanel.Location = new System.Drawing.Point(0, 0);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(320, 32);
            this.managePanel.TabIndex = 4;
            this.managePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.managePanel_MouseDown);
            this.managePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.managePanel_MouseMove);
            // 
            // closingCross
            // 
            this.closingCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closingCross.Dock = System.Windows.Forms.DockStyle.Right;
            this.closingCross.Image = global::Lab4.Properties.Resources.closingCross;
            this.closingCross.Location = new System.Drawing.Point(288, 0);
            this.closingCross.Name = "closingCross";
            this.closingCross.Size = new System.Drawing.Size(32, 32);
            this.closingCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closingCross.TabIndex = 1;
            this.closingCross.TabStop = false;
            this.closingCross.Click += new System.EventHandler(this.closingCross_Click);
            this.closingCross.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closingCross_Click);
            this.closingCross.MouseLeave += new System.EventHandler(this.closingCross_MouseLeave);
            this.closingCross.MouseHover += new System.EventHandler(this.closingCross_MouseHover);
            // 
            // aboutLabel
            // 
            this.aboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.aboutLabel.Location = new System.Drawing.Point(0, 32);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(320, 288);
            this.aboutLabel.TabIndex = 11;
            this.aboutLabel.Text = "Литвиненко Даниил Дмитриевич К3221";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.managePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.managePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closingCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel managePanel;
        private System.Windows.Forms.PictureBox closingCross;
        private System.Windows.Forms.Label aboutLabel;
    }
}
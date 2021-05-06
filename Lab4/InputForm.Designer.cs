namespace Lab4
{
    partial class InputForm
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
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new Lab4.RoundLabel();
            this.lengthCheckBox = new System.Windows.Forms.CheckBox();
            this.squareCheckBox = new System.Windows.Forms.CheckBox();
            this.radiusLablel = new System.Windows.Forms.Label();
            this.radiusErrorLabel = new System.Windows.Forms.Label();
            this.enterErrorlabel = new System.Windows.Forms.Label();
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
            this.managePanel.TabIndex = 3;
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
            this.closingCross.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closingCross_Click);
            this.closingCross.MouseLeave += new System.EventHandler(this.closingCross_MouseLeave);
            this.closingCross.MouseHover += new System.EventHandler(this.closingCross_MouseHover);
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(40, 82);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(225, 22);
            this.radiusTextBox.TabIndex = 4;
            this.radiusTextBox.TextChanged += new System.EventHandler(this.radiusTextBox_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.Active = true;
            this.enterButton.CurrentColor = System.Drawing.Color.Transparent;
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.enterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.enterButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.enterButton.Location = new System.Drawing.Point(56, 241);
            this.enterButton.MainColor = System.Drawing.Color.Transparent;
            this.enterButton.Name = "enterButton";
            this.enterButton.RoundRadius = 10;
            this.enterButton.Size = new System.Drawing.Size(200, 42);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Enter";
            this.enterButton.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // lengthCheckBox
            // 
            this.lengthCheckBox.AutoSize = true;
            this.lengthCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lengthCheckBox.Location = new System.Drawing.Point(40, 178);
            this.lengthCheckBox.Name = "lengthCheckBox";
            this.lengthCheckBox.Size = new System.Drawing.Size(99, 32);
            this.lengthCheckBox.TabIndex = 8;
            this.lengthCheckBox.Text = "Length";
            this.lengthCheckBox.UseVisualStyleBackColor = true;
            this.lengthCheckBox.CheckedChanged += new System.EventHandler(this.lengthCheckBox_CheckedChanged);
            // 
            // squareCheckBox
            // 
            this.squareCheckBox.AutoSize = true;
            this.squareCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.squareCheckBox.Location = new System.Drawing.Point(40, 140);
            this.squareCheckBox.Name = "squareCheckBox";
            this.squareCheckBox.Size = new System.Drawing.Size(99, 32);
            this.squareCheckBox.TabIndex = 9;
            this.squareCheckBox.Text = "Square";
            this.squareCheckBox.UseVisualStyleBackColor = true;
            this.squareCheckBox.CheckedChanged += new System.EventHandler(this.squareCheckBox_CheckedChanged);
            // 
            // radiusLablel
            // 
            this.radiusLablel.AutoSize = true;
            this.radiusLablel.BackColor = System.Drawing.Color.Transparent;
            this.radiusLablel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiusLablel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.radiusLablel.Location = new System.Drawing.Point(35, 51);
            this.radiusLablel.Name = "radiusLablel";
            this.radiusLablel.Size = new System.Drawing.Size(75, 28);
            this.radiusLablel.TabIndex = 10;
            this.radiusLablel.Text = "Radius";
            // 
            // radiusErrorLabel
            // 
            this.radiusErrorLabel.AutoSize = true;
            this.radiusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiusErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.radiusErrorLabel.Location = new System.Drawing.Point(36, 107);
            this.radiusErrorLabel.Name = "radiusErrorLabel";
            this.radiusErrorLabel.Size = new System.Drawing.Size(0, 23);
            this.radiusErrorLabel.TabIndex = 11;
            // 
            // enterErrorlabel
            // 
            this.enterErrorlabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterErrorlabel.ForeColor = System.Drawing.Color.Red;
            this.enterErrorlabel.Location = new System.Drawing.Point(49, 213);
            this.enterErrorlabel.Name = "enterErrorlabel";
            this.enterErrorlabel.Size = new System.Drawing.Size(216, 23);
            this.enterErrorlabel.TabIndex = 12;
            this.enterErrorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(320, 306);
            this.Controls.Add(this.enterErrorlabel);
            this.Controls.Add(this.radiusErrorLabel);
            this.Controls.Add(this.radiusLablel);
            this.Controls.Add(this.squareCheckBox);
            this.Controls.Add(this.lengthCheckBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.managePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.managePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closingCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel managePanel;
        private System.Windows.Forms.PictureBox closingCross;
        private System.Windows.Forms.TextBox radiusTextBox;
        private RoundLabel enterButton;
        private System.Windows.Forms.CheckBox lengthCheckBox;
        private System.Windows.Forms.CheckBox squareCheckBox;
        private System.Windows.Forms.Label radiusLablel;
        private System.Windows.Forms.Label radiusErrorLabel;
        private System.Windows.Forms.Label enterErrorlabel;
    }
}
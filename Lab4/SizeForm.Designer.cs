namespace Lab4
{
    partial class SizeForm
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
            this.rectangleWidthInput = new System.Windows.Forms.TextBox();
            this.rectangleLengthInput = new System.Windows.Forms.TextBox();
            this.greenCheckBox = new System.Windows.Forms.CheckBox();
            this.redCheckBox = new System.Windows.Forms.CheckBox();
            this.blueCheckBox = new System.Windows.Forms.CheckBox();
            this.widthLable = new System.Windows.Forms.Label();
            this.legthLabel = new System.Windows.Forms.Label();
            this.legthErrorLabel = new System.Windows.Forms.Label();
            this.widthErrorLabel = new System.Windows.Forms.Label();
            this.enterErrorLabel = new System.Windows.Forms.Label();
            this.enterButton = new Lab4.RoundLabel();
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
            this.managePanel.Size = new System.Drawing.Size(302, 32);
            this.managePanel.TabIndex = 2;
            this.managePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.managePanel_MouseDown);
            this.managePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.managePanel_MouseMove);
            // 
            // closingCross
            // 
            this.closingCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closingCross.Dock = System.Windows.Forms.DockStyle.Right;
            this.closingCross.Image = global::Lab4.Properties.Resources.closingCross;
            this.closingCross.Location = new System.Drawing.Point(270, 0);
            this.closingCross.Name = "closingCross";
            this.closingCross.Size = new System.Drawing.Size(32, 32);
            this.closingCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closingCross.TabIndex = 1;
            this.closingCross.TabStop = false;
            this.closingCross.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closingCross_Click);
            this.closingCross.MouseLeave += new System.EventHandler(this.closingCross_MouseLeave);
            this.closingCross.MouseHover += new System.EventHandler(this.closingCross_MouseHover);
            // 
            // rectangleWidthInput
            // 
            this.rectangleWidthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rectangleWidthInput.Location = new System.Drawing.Point(28, 66);
            this.rectangleWidthInput.Name = "rectangleWidthInput";
            this.rectangleWidthInput.Size = new System.Drawing.Size(244, 22);
            this.rectangleWidthInput.TabIndex = 4;
            this.rectangleWidthInput.Text = "0";
            this.rectangleWidthInput.TextChanged += new System.EventHandler(this.rectangleWidthInput_TextChanged);
            // 
            // rectangleLengthInput
            // 
            this.rectangleLengthInput.Location = new System.Drawing.Point(28, 144);
            this.rectangleLengthInput.Name = "rectangleLengthInput";
            this.rectangleLengthInput.Size = new System.Drawing.Size(244, 22);
            this.rectangleLengthInput.TabIndex = 5;
            this.rectangleLengthInput.Text = "0";
            this.rectangleLengthInput.TextChanged += new System.EventHandler(this.rectangleLengthInput_TextChanged);
            // 
            // greenCheckBox
            // 
            this.greenCheckBox.AutoSize = true;
            this.greenCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.greenCheckBox.Location = new System.Drawing.Point(28, 195);
            this.greenCheckBox.Name = "greenCheckBox";
            this.greenCheckBox.Size = new System.Drawing.Size(90, 32);
            this.greenCheckBox.TabIndex = 6;
            this.greenCheckBox.Text = "Green";
            this.greenCheckBox.UseVisualStyleBackColor = true;
            this.greenCheckBox.CheckedChanged += new System.EventHandler(this.greenCheckBox_CheckedChanged);
            // 
            // redCheckBox
            // 
            this.redCheckBox.AutoSize = true;
            this.redCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.redCheckBox.Location = new System.Drawing.Point(28, 233);
            this.redCheckBox.Name = "redCheckBox";
            this.redCheckBox.Size = new System.Drawing.Size(70, 32);
            this.redCheckBox.TabIndex = 7;
            this.redCheckBox.Text = "Red";
            this.redCheckBox.UseVisualStyleBackColor = true;
            this.redCheckBox.CheckedChanged += new System.EventHandler(this.redCheckBox_CheckedChanged);
            // 
            // blueCheckBox
            // 
            this.blueCheckBox.AutoSize = true;
            this.blueCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.blueCheckBox.Location = new System.Drawing.Point(28, 271);
            this.blueCheckBox.Name = "blueCheckBox";
            this.blueCheckBox.Size = new System.Drawing.Size(76, 32);
            this.blueCheckBox.TabIndex = 8;
            this.blueCheckBox.Text = "Blue";
            this.blueCheckBox.UseVisualStyleBackColor = true;
            this.blueCheckBox.CheckedChanged += new System.EventHandler(this.blueCheckBox_CheckedChanged);
            // 
            // widthLable
            // 
            this.widthLable.AutoSize = true;
            this.widthLable.BackColor = System.Drawing.Color.Transparent;
            this.widthLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.widthLable.Location = new System.Drawing.Point(23, 35);
            this.widthLable.Name = "widthLable";
            this.widthLable.Size = new System.Drawing.Size(70, 28);
            this.widthLable.TabIndex = 9;
            this.widthLable.Text = "Width";
            // 
            // legthLabel
            // 
            this.legthLabel.AutoSize = true;
            this.legthLabel.BackColor = System.Drawing.Color.Transparent;
            this.legthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.legthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.legthLabel.Location = new System.Drawing.Point(23, 113);
            this.legthLabel.Name = "legthLabel";
            this.legthLabel.Size = new System.Drawing.Size(77, 28);
            this.legthLabel.TabIndex = 10;
            this.legthLabel.Text = "Length";
            // 
            // legthErrorLabel
            // 
            this.legthErrorLabel.AutoSize = true;
            this.legthErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.legthErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.legthErrorLabel.Location = new System.Drawing.Point(25, 169);
            this.legthErrorLabel.Name = "legthErrorLabel";
            this.legthErrorLabel.Size = new System.Drawing.Size(0, 23);
            this.legthErrorLabel.TabIndex = 11;
            // 
            // widthErrorLabel
            // 
            this.widthErrorLabel.AutoSize = true;
            this.widthErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.widthErrorLabel.Location = new System.Drawing.Point(25, 90);
            this.widthErrorLabel.Name = "widthErrorLabel";
            this.widthErrorLabel.Size = new System.Drawing.Size(0, 23);
            this.widthErrorLabel.TabIndex = 12;
            // 
            // enterErrorLabel
            // 
            this.enterErrorLabel.AutoSize = true;
            this.enterErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.enterErrorLabel.Location = new System.Drawing.Point(40, 306);
            this.enterErrorLabel.Name = "enterErrorLabel";
            this.enterErrorLabel.Size = new System.Drawing.Size(0, 23);
            this.enterErrorLabel.TabIndex = 13;
            // 
            // enterButton
            // 
            this.enterButton.Active = true;
            this.enterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.CurrentColor = System.Drawing.Color.Transparent;
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.enterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.enterButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.enterButton.Location = new System.Drawing.Point(35, 332);
            this.enterButton.MainColor = System.Drawing.Color.Transparent;
            this.enterButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.enterButton.Name = "enterButton";
            this.enterButton.RoundRadius = 10;
            this.enterButton.Size = new System.Drawing.Size(223, 43);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // SizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(302, 400);
            this.ControlBox = false;
            this.Controls.Add(this.enterErrorLabel);
            this.Controls.Add(this.widthErrorLabel);
            this.Controls.Add(this.legthErrorLabel);
            this.Controls.Add(this.legthLabel);
            this.Controls.Add(this.widthLable);
            this.Controls.Add(this.blueCheckBox);
            this.Controls.Add(this.redCheckBox);
            this.Controls.Add(this.greenCheckBox);
            this.Controls.Add(this.rectangleLengthInput);
            this.Controls.Add(this.rectangleWidthInput);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.managePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SizeForm";
            this.managePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closingCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel managePanel;
        private System.Windows.Forms.PictureBox closingCross;
        private RoundLabel enterButton;
        private System.Windows.Forms.TextBox rectangleWidthInput;
        private System.Windows.Forms.TextBox rectangleLengthInput;
        private System.Windows.Forms.CheckBox greenCheckBox;
        private System.Windows.Forms.CheckBox redCheckBox;
        private System.Windows.Forms.CheckBox blueCheckBox;
        private System.Windows.Forms.Label widthLable;
        private System.Windows.Forms.Label legthLabel;
        private System.Windows.Forms.Label legthErrorLabel;
        private System.Windows.Forms.Label widthErrorLabel;
        private System.Windows.Forms.Label enterErrorLabel;
    }
}
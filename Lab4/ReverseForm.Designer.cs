namespace Lab4
{
    partial class ReverseForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.revreseCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new Lab4.RoundLabel();
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
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 65);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(296, 113);
            this.inputTextBox.TabIndex = 4;
            // 
            // revreseCheckBox
            // 
            this.revreseCheckBox.AutoSize = true;
            this.revreseCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.revreseCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.revreseCheckBox.Location = new System.Drawing.Point(28, 194);
            this.revreseCheckBox.Name = "revreseCheckBox";
            this.revreseCheckBox.Size = new System.Drawing.Size(108, 32);
            this.revreseCheckBox.TabIndex = 7;
            this.revreseCheckBox.Text = "Reverse";
            this.revreseCheckBox.UseVisualStyleBackColor = true;
            this.revreseCheckBox.CheckedChanged += new System.EventHandler(this.revreseCheckBox_CheckedChanged);
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upperCaseCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.upperCaseCheckBox.Location = new System.Drawing.Point(28, 241);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Size = new System.Drawing.Size(138, 32);
            this.upperCaseCheckBox.TabIndex = 8;
            this.upperCaseCheckBox.Text = "Upper case";
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            this.upperCaseCheckBox.CheckedChanged += new System.EventHandler(this.upperCaseCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Active = true;
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.CurrentColor = System.Drawing.Color.Transparent;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.okButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.okButton.Location = new System.Drawing.Point(45, 289);
            this.okButton.MainColor = System.Drawing.Color.Transparent;
            this.okButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.okButton.Name = "okButton";
            this.okButton.RoundRadius = 10;
            this.okButton.Size = new System.Drawing.Size(223, 43);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ReverseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(320, 362);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.upperCaseCheckBox);
            this.Controls.Add(this.revreseCheckBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.managePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReverseForm";
            this.managePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closingCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel managePanel;
        private System.Windows.Forms.PictureBox closingCross;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.CheckBox revreseCheckBox;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private RoundLabel okButton;
    }
}
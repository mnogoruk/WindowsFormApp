namespace Lab4
{
    partial class CalcForm
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
            this.lengthLabel = new System.Windows.Forms.Label();
            this.squareLabel = new System.Windows.Forms.Label();
            this.lengthValueLabel = new System.Windows.Forms.Label();
            this.squareValueLabel = new System.Windows.Forms.Label();
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
            this.managePanel.Size = new System.Drawing.Size(444, 32);
            this.managePanel.TabIndex = 3;
            this.managePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.managePanel_MouseDown);
            this.managePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.managePanel_MouseMove);
            // 
            // closingCross
            // 
            this.closingCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closingCross.Dock = System.Windows.Forms.DockStyle.Right;
            this.closingCross.Image = global::Lab4.Properties.Resources.closingCross;
            this.closingCross.Location = new System.Drawing.Point(412, 0);
            this.closingCross.Name = "closingCross";
            this.closingCross.Size = new System.Drawing.Size(32, 32);
            this.closingCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closingCross.TabIndex = 1;
            this.closingCross.TabStop = false;
            this.closingCross.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closingCross_Click);
            this.closingCross.MouseLeave += new System.EventHandler(this.closingCross_MouseLeave);
            this.closingCross.MouseHover += new System.EventHandler(this.closingCross_MouseHover);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lengthLabel.Location = new System.Drawing.Point(36, 77);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(124, 38);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Length: ";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.squareLabel.Location = new System.Drawing.Point(36, 158);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(116, 38);
            this.squareLabel.TabIndex = 4;
            this.squareLabel.Text = "Square:";
            this.squareLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lengthValueLabel
            // 
            this.lengthValueLabel.AutoSize = true;
            this.lengthValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lengthValueLabel.Location = new System.Drawing.Point(152, 77);
            this.lengthValueLabel.Name = "lengthValueLabel";
            this.lengthValueLabel.Size = new System.Drawing.Size(124, 38);
            this.lengthValueLabel.TabIndex = 5;
            this.lengthValueLabel.Text = "Length: ";
            this.lengthValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // squareValueLabel
            // 
            this.squareValueLabel.AutoSize = true;
            this.squareValueLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.squareValueLabel.Location = new System.Drawing.Point(152, 158);
            this.squareValueLabel.Name = "squareValueLabel";
            this.squareValueLabel.Size = new System.Drawing.Size(124, 38);
            this.squareValueLabel.TabIndex = 6;
            this.squareValueLabel.Text = "Length: ";
            this.squareValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(444, 250);
            this.Controls.Add(this.squareValueLabel);
            this.Controls.Add(this.lengthValueLabel);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.managePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalcForm";
            this.Text = "CalcForm";
            this.managePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closingCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel managePanel;
        private System.Windows.Forms.PictureBox closingCross;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.Label lengthValueLabel;
        private System.Windows.Forms.Label squareValueLabel;
    }
}
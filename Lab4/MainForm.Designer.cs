namespace Lab4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.managePanel = new System.Windows.Forms.Panel();
            this.rollUp = new System.Windows.Forms.PictureBox();
            this.closingCross = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.quitItem = new Lab4.RoundLabel();
            this.circleItem = new Lab4.RoundLabel();
            this.inputItem = new Lab4.RoundLabel();
            this.rectItem = new Lab4.RoundLabel();
            this.siezeItem = new Lab4.RoundLabel();
            this.calcItem = new Lab4.RoundLabel();
            this.reverseItem = new Lab4.RoundLabel();
            this.aboutItem = new Lab4.RoundLabel();
            this.drawBox = new System.Windows.Forms.Panel();
            this.drawBoxErrorLabel = new System.Windows.Forms.Label();
            this.managePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingCross)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.drawBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // managePanel
            // 
            this.managePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.managePanel.Controls.Add(this.rollUp);
            this.managePanel.Controls.Add(this.closingCross);
            this.managePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.managePanel.Location = new System.Drawing.Point(0, 0);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(320, 32);
            this.managePanel.TabIndex = 1;
            this.managePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.managePanel_MouseDown);
            this.managePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.managePanel_MouseMove);
            // 
            // rollUp
            // 
            this.rollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.rollUp.Image = global::Lab4.Properties.Resources.rollUp;
            this.rollUp.Location = new System.Drawing.Point(256, 0);
            this.rollUp.Name = "rollUp";
            this.rollUp.Size = new System.Drawing.Size(32, 32);
            this.rollUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollUp.TabIndex = 0;
            this.rollUp.TabStop = false;
            this.rollUp.Click += new System.EventHandler(this.rollUp_Click);
            this.rollUp.MouseLeave += new System.EventHandler(this.rollUp_MouseLeave);
            this.rollUp.MouseHover += new System.EventHandler(this.rollUp_MouseHover);
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
            this.closingCross.MouseLeave += new System.EventHandler(this.closingCross_MouseLeave);
            this.closingCross.MouseHover += new System.EventHandler(this.closingCross_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.quitItem, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.circleItem, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.inputItem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rectItem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.siezeItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.calcItem, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.reverseItem, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.aboutItem, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 370);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // quitItem
            // 
            this.quitItem.Active = true;
            this.quitItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quitItem.BackColor = System.Drawing.Color.Transparent;
            this.quitItem.CurrentColor = System.Drawing.Color.Transparent;
            this.quitItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitItem.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.quitItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.quitItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.quitItem.Location = new System.Drawing.Point(5, 321);
            this.quitItem.MainColor = System.Drawing.Color.Transparent;
            this.quitItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.quitItem.Name = "quitItem";
            this.quitItem.RoundRadius = 10;
            this.quitItem.Size = new System.Drawing.Size(310, 43);
            this.quitItem.TabIndex = 7;
            this.quitItem.Text = "Quit";
            this.quitItem.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.quitItem.Click += new System.EventHandler(this.quitItem_Click_1);
            // 
            // circleItem
            // 
            this.circleItem.Active = true;
            this.circleItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.circleItem.BackColor = System.Drawing.Color.Transparent;
            this.circleItem.CurrentColor = System.Drawing.Color.Transparent;
            this.circleItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleItem.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.circleItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.circleItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.circleItem.Location = new System.Drawing.Point(5, 136);
            this.circleItem.MainColor = System.Drawing.Color.Transparent;
            this.circleItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.circleItem.Name = "circleItem";
            this.circleItem.RoundRadius = 10;
            this.circleItem.Size = new System.Drawing.Size(310, 43);
            this.circleItem.TabIndex = 3;
            this.circleItem.Text = "Circle";
            this.circleItem.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.circleItem.Click += new System.EventHandler(this.circleItem_Click);
            // 
            // inputItem
            // 
            this.inputItem.Active = true;
            this.inputItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputItem.BackColor = System.Drawing.Color.Transparent;
            this.inputItem.CurrentColor = System.Drawing.Color.Transparent;
            this.inputItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputItem.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.inputItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.inputItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.inputItem.Location = new System.Drawing.Point(5, 91);
            this.inputItem.MainColor = System.Drawing.Color.Transparent;
            this.inputItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.inputItem.Name = "inputItem";
            this.inputItem.RoundRadius = 10;
            this.inputItem.Size = new System.Drawing.Size(310, 43);
            this.inputItem.TabIndex = 2;
            this.inputItem.Text = "Input";
            this.inputItem.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.inputItem.Click += new System.EventHandler(this.inputItem_Click);
            // 
            // rectItem
            // 
            this.rectItem.Active = false;
            this.rectItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rectItem.BackColor = System.Drawing.Color.Transparent;
            this.rectItem.CurrentColor = System.Drawing.Color.Transparent;
            this.rectItem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rectItem.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.rectItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rectItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.rectItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.rectItem.Location = new System.Drawing.Point(5, 46);
            this.rectItem.MainColor = System.Drawing.Color.Transparent;
            this.rectItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rectItem.Name = "rectItem";
            this.rectItem.RoundRadius = 10;
            this.rectItem.Size = new System.Drawing.Size(310, 43);
            this.rectItem.TabIndex = 1;
            this.rectItem.Text = "Rectangle";
            this.rectItem.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.rectItem.Click += new System.EventHandler(this.rectItem_Click);
            // 
            // siezeItem
            // 
            this.siezeItem.Active = true;
            this.siezeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.siezeItem.BackColor = System.Drawing.Color.Transparent;
            this.siezeItem.CurrentColor = System.Drawing.Color.Transparent;
            this.siezeItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siezeItem.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.siezeItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siezeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.siezeItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.siezeItem.Location = new System.Drawing.Point(5, 1);
            this.siezeItem.MainColor = System.Drawing.Color.Transparent;
            this.siezeItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.siezeItem.Name = "siezeItem";
            this.siezeItem.RoundRadius = 10;
            this.siezeItem.Size = new System.Drawing.Size(310, 43);
            this.siezeItem.TabIndex = 0;
            this.siezeItem.Text = "Size";
            this.siezeItem.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.siezeItem.Click += new System.EventHandler(this.siezeItem_Click);
            // 
            // calcItem
            // 
            this.calcItem.Active = true;
            this.calcItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calcItem.BackColor = System.Drawing.Color.Transparent;
            this.calcItem.CurrentColor = System.Drawing.Color.Transparent;
            this.calcItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcItem.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.calcItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.calcItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.calcItem.Location = new System.Drawing.Point(5, 181);
            this.calcItem.MainColor = System.Drawing.Color.Transparent;
            this.calcItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.calcItem.Name = "calcItem";
            this.calcItem.RoundRadius = 10;
            this.calcItem.Size = new System.Drawing.Size(310, 43);
            this.calcItem.TabIndex = 4;
            this.calcItem.Text = "Calc";
            this.calcItem.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.calcItem.Click += new System.EventHandler(this.calcItem_Click);
            // 
            // reverseItem
            // 
            this.reverseItem.Active = true;
            this.reverseItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reverseItem.BackColor = System.Drawing.Color.Transparent;
            this.reverseItem.CurrentColor = System.Drawing.Color.Transparent;
            this.reverseItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reverseItem.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.reverseItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reverseItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.reverseItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.reverseItem.Location = new System.Drawing.Point(5, 226);
            this.reverseItem.MainColor = System.Drawing.Color.Transparent;
            this.reverseItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reverseItem.Name = "reverseItem";
            this.reverseItem.RoundRadius = 10;
            this.reverseItem.Size = new System.Drawing.Size(310, 43);
            this.reverseItem.TabIndex = 5;
            this.reverseItem.Text = "Reverse";
            this.reverseItem.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.reverseItem.Click += new System.EventHandler(this.reverseItem_Click);
            // 
            // aboutItem
            // 
            this.aboutItem.Active = true;
            this.aboutItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutItem.BackColor = System.Drawing.Color.Transparent;
            this.aboutItem.CurrentColor = System.Drawing.Color.Transparent;
            this.aboutItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutItem.DeafultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.aboutItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.aboutItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.aboutItem.Location = new System.Drawing.Point(5, 271);
            this.aboutItem.MainColor = System.Drawing.Color.Transparent;
            this.aboutItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.RoundRadius = 10;
            this.aboutItem.Size = new System.Drawing.Size(310, 43);
            this.aboutItem.TabIndex = 6;
            this.aboutItem.Text = "About";
            this.aboutItem.UnActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // drawBox
            // 
            this.drawBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.drawBox.Controls.Add(this.drawBoxErrorLabel);
            this.drawBox.Location = new System.Drawing.Point(323, 38);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(0, 400);
            this.drawBox.TabIndex = 3;
            // 
            // drawBoxErrorLabel
            // 
            this.drawBoxErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.drawBoxErrorLabel.CausesValidation = false;
            this.drawBoxErrorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drawBoxErrorLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawBoxErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.drawBoxErrorLabel.Location = new System.Drawing.Point(0, 0);
            this.drawBoxErrorLabel.Name = "drawBoxErrorLabel";
            this.drawBoxErrorLabel.Size = new System.Drawing.Size(0, 38);
            this.drawBoxErrorLabel.TabIndex = 0;
            this.drawBoxErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drawBoxErrorLabel.UseMnemonic = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.ControlBox = false;
            this.Controls.Add(this.drawBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.managePanel);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.managePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rollUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingCross)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.drawBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel managePanel;
        private System.Windows.Forms.PictureBox closingCross;
        private System.Windows.Forms.PictureBox rollUp;
        private RoundLabel siezeItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundLabel quitItem;
        private RoundLabel circleItem;
        private RoundLabel inputItem;
        private RoundLabel rectItem;
        private RoundLabel calcItem;
        private RoundLabel reverseItem;
        private RoundLabel aboutItem;
        private System.Windows.Forms.Panel drawBox;
        private System.Windows.Forms.Label drawBoxErrorLabel;
    }
}
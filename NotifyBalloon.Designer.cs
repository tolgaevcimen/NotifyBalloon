namespace NotifyBalloon
{
    partial class NotifyBalloon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
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
        private void InitializeComponent ()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCloseBalloon = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 50);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.89918F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.10082F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.btnCloseBalloon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCaption, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCloseBalloon
            // 
            this.btnCloseBalloon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseBalloon.FlatAppearance.BorderSize = 0;
            this.btnCloseBalloon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseBalloon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseBalloon.Location = new System.Drawing.Point(256, 0);
            this.btnCloseBalloon.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseBalloon.Name = "btnCloseBalloon";
            this.btnCloseBalloon.Size = new System.Drawing.Size(34, 25);
            this.btnCloseBalloon.TabIndex = 0;
            this.btnCloseBalloon.Text = "x";
            this.btnCloseBalloon.UseVisualStyleBackColor = true;
            this.btnCloseBalloon.Click += new System.EventHandler(this.closeButton_Click);
            this.btnCloseBalloon.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.btnCloseBalloon.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCaption.Location = new System.Drawing.Point(32, 0);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(220, 25);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "label1";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCaption.Click += new System.EventHandler(this.NotifyBalloon_Clicked);
            this.lblCaption.MouseEnter += new System.EventHandler(this.NotifyBalloon_MouseEnter);
            this.lblCaption.MouseLeave += new System.EventHandler(this.NotifyBalloon_MouseLeave);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblText, 3);
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText.Location = new System.Drawing.Point(2, 27);
            this.lblText.Margin = new System.Windows.Forms.Padding(2);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(286, 19);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "label2";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblText.Click += new System.EventHandler(this.NotifyBalloon_Clicked);
            this.lblText.MouseEnter += new System.EventHandler(this.NotifyBalloon_MouseEnter);
            this.lblText.MouseLeave += new System.EventHandler(this.NotifyBalloon_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Image = global::NotifyBalloon.Properties.Resources.rsz_facebook_verified_account_logo;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.NotifyBalloon_Clicked);
            this.label1.MouseEnter += new System.EventHandler(this.NotifyBalloon_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.NotifyBalloon_MouseLeave);
            // 
            // NotifyBalloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 50);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(292, 300);
            this.MinimumSize = new System.Drawing.Size(292, 50);
            this.Name = "NotifyBalloon";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.MouseEnter += new System.EventHandler(this.NotifyBalloon_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NotifyBalloon_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCloseBalloon;
        private System.Windows.Forms.Label lblCaption;
        public System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label label1;
    }
}
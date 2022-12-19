namespace WWM
{
    partial class FinalAmountWon
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
            this.lblwon = new System.Windows.Forms.Label();
            this.btnplayagain = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwon
            // 
            this.lblwon.AutoSize = true;
            this.lblwon.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwon.ForeColor = System.Drawing.Color.Red;
            this.lblwon.Location = new System.Drawing.Point(35, 243);
            this.lblwon.Name = "lblwon";
            this.lblwon.Size = new System.Drawing.Size(374, 46);
            this.lblwon.TabIndex = 0;
            this.lblwon.Text = "Total Amount Won: ";
            // 
            // btnplayagain
            // 
            this.btnplayagain.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnplayagain.FlatAppearance.BorderSize = 0;
            this.btnplayagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplayagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplayagain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnplayagain.Location = new System.Drawing.Point(417, 337);
            this.btnplayagain.Margin = new System.Windows.Forms.Padding(0);
            this.btnplayagain.Name = "btnplayagain";
            this.btnplayagain.Size = new System.Drawing.Size(131, 43);
            this.btnplayagain.TabIndex = 8;
            this.btnplayagain.Text = "Play Again";
            this.btnplayagain.UseVisualStyleBackColor = false;
            this.btnplayagain.Click += new System.EventHandler(this.btnplayagain_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Location = new System.Drawing.Point(575, 337);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(101, 43);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.ForeColor = System.Drawing.Color.Red;
            this.TotalAmount.Location = new System.Drawing.Point(496, 243);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(75, 46);
            this.TotalAmount.TabIndex = 10;
            this.TotalAmount.Text = "$ 0";
            this.TotalAmount.Click += new System.EventHandler(this.Labelamount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WWM.Properties.Resources.WWM_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(43, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(238, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 69);
            this.label3.TabIndex = 12;
            this.label3.Text = "WWM  CHEQUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(232, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 69);
            this.label1.TabIndex = 12;
            this.label1.Text = "WWM  CHEQUE";
            // 
            // FinalAmountWon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(726, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnplayagain);
            this.Controls.Add(this.lblwon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinalAmountWon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalAmountWon";
            this.Load += new System.EventHandler(this.FinalAmountWon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplayagain;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label TotalAmount;
        public System.Windows.Forms.Label lblwon;
        private System.Windows.Forms.Label label1;
    }
}
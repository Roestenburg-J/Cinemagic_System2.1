namespace RandomProj
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnCommitSale = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCommitSale
            // 
            this.btnCommitSale.Location = new System.Drawing.Point(419, 385);
            this.btnCommitSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCommitSale.Name = "btnCommitSale";
            this.btnCommitSale.Size = new System.Drawing.Size(152, 62);
            this.btnCommitSale.TabIndex = 0;
            this.btnCommitSale.Text = "PERFORM A SNACK SALE";
            this.btnCommitSale.UseVisualStyleBackColor = true;
            this.btnCommitSale.Click += new System.EventHandler(this.btnCommitSale_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(276, 385);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(136, 65);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Movies";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pboxBackground
            // 
            this.pboxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackground.Image")));
            this.pboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(1039, 504);
            this.pboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBackground.TabIndex = 4;
            this.pboxBackground.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnCommitSale);
            this.Controls.Add(this.pboxBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCommitSale;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pboxBackground;
    }
}
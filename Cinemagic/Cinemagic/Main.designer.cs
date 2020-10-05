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
            this.btnCommitSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCommitSale
            // 
            this.btnCommitSale.Location = new System.Drawing.Point(418, 385);
            this.btnCommitSale.Name = "btnCommitSale";
            this.btnCommitSale.Size = new System.Drawing.Size(152, 62);
            this.btnCommitSale.TabIndex = 0;
            this.btnCommitSale.Text = "PERFORM A SNACK SALE";
            this.btnCommitSale.UseVisualStyleBackColor = true;
            this.btnCommitSale.Click += new System.EventHandler(this.btnCommitSale_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 503);
            this.Controls.Add(this.btnCommitSale);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCommitSale;
    }
}
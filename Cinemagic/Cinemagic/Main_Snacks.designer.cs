namespace RandomProj
{
    partial class Main_Snacks
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
            this.btnSnack_Sale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSnack_Sale
            // 
            this.btnSnack_Sale.Location = new System.Drawing.Point(170, 403);
            this.btnSnack_Sale.Name = "btnSnack_Sale";
            this.btnSnack_Sale.Size = new System.Drawing.Size(171, 52);
            this.btnSnack_Sale.TabIndex = 0;
            this.btnSnack_Sale.Text = "ADD SNACK SALE DATE";
            this.btnSnack_Sale.UseVisualStyleBackColor = true;
            this.btnSnack_Sale.Click += new System.EventHandler(this.btnSnack_Sale_Click);
            // 
            // Main_Snacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 494);
            this.Controls.Add(this.btnSnack_Sale);
            this.Name = "Main_Snacks";
            this.Text = "Main_Snacks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSnack_Sale;
    }
}
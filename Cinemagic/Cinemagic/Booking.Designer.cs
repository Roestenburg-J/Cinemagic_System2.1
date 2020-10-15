namespace Cinemagic
{
    partial class Booking
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbooking = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtseats = new System.Windows.Forms.TextBox();
            this.dtptickets = new System.Windows.Forms.DateTimePicker();
            this.btninsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 228);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Display database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbooking
            // 
            this.txtbooking.Location = new System.Drawing.Point(128, 389);
            this.txtbooking.Name = "txtbooking";
            this.txtbooking.Size = new System.Drawing.Size(100, 20);
            this.txtbooking.TabIndex = 4;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(348, 389);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 20);
            this.txtcost.TabIndex = 5;
            // 
            // txtseats
            // 
            this.txtseats.Location = new System.Drawing.Point(515, 389);
            this.txtseats.Name = "txtseats";
            this.txtseats.Size = new System.Drawing.Size(100, 20);
            this.txtseats.TabIndex = 6;
            // 
            // dtptickets
            // 
            this.dtptickets.Location = new System.Drawing.Point(548, 339);
            this.dtptickets.Name = "dtptickets";
            this.dtptickets.Size = new System.Drawing.Size(200, 20);
            this.dtptickets.TabIndex = 7;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(232, 339);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(91, 42);
            this.btninsert.TabIndex = 8;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 502);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dtptickets);
            this.Controls.Add(this.txtseats);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtbooking);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Booking";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbooking;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtseats;
        private System.Windows.Forms.DateTimePicker dtptickets;
        private System.Windows.Forms.Button btninsert;
    }
}
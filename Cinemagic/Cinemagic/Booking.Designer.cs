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
            this.btndisplay = new System.Windows.Forms.Button();
            this.txtseats = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtptickets = new System.Windows.Forms.DateTimePicker();
            this.btnbooking = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtbooking = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(74, 301);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(119, 43);
            this.btndisplay.TabIndex = 3;
            this.btndisplay.Text = "Display database";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtseats
            // 
            this.txtseats.Location = new System.Drawing.Point(107, 484);
            this.txtseats.Name = "txtseats";
            this.txtseats.Size = new System.Drawing.Size(100, 20);
            this.txtseats.TabIndex = 5;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(107, 415);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 20);
            this.txtcost.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Ticketcost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ticket Sale date";
            // 
            // dtptickets
            // 
            this.dtptickets.Location = new System.Drawing.Point(107, 541);
            this.dtptickets.Name = "dtptickets";
            this.dtptickets.Size = new System.Drawing.Size(200, 20);
            this.dtptickets.TabIndex = 10;
            this.dtptickets.ValueChanged += new System.EventHandler(this.dtptickets_ValueChanged);
            // 
            // btnbooking
            // 
            this.btnbooking.Location = new System.Drawing.Point(591, 301);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(119, 43);
            this.btnbooking.TabIndex = 13;
            this.btnbooking.Text = "Delete Booking";
            this.btnbooking.UseVisualStyleBackColor = true;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(417, 301);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(119, 43);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update Records";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(242, 301);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(119, 43);
            this.btninsert.TabIndex = 15;
            this.btninsert.Text = "Insert Record";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtbooking
            // 
            this.txtbooking.Location = new System.Drawing.Point(610, 370);
            this.txtbooking.Name = "txtbooking";
            this.txtbooking.Size = new System.Drawing.Size(100, 20);
            this.txtbooking.TabIndex = 16;
            this.txtbooking.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Booking";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbooking);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnbooking);
            this.Controls.Add(this.dtptickets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtseats);
            this.Controls.Add(this.btndisplay);
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
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.TextBox txtseats;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtptickets;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtbooking;
        private System.Windows.Forms.Label label4;
    }
}
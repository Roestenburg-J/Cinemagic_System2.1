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
            this.btninsert = new System.Windows.Forms.Button();
            this.btnbooking = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gpBooking = new System.Windows.Forms.GroupBox();
            this.txtbooking = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtseats = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.cbcost = new System.Windows.Forms.CheckBox();
            this.cbseats = new System.Windows.Forms.CheckBox();
            this.cbdate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpBooking.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 373);
            this.dataGridView1.TabIndex = 1;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(6, 214);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(139, 52);
            this.btninsert.TabIndex = 8;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click_1);
            // 
            // btnbooking
            // 
            this.btnbooking.Location = new System.Drawing.Point(6, 214);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(139, 52);
            this.btnbooking.TabIndex = 10;
            this.btnbooking.Text = "Delete Booking";
            this.btnbooking.UseVisualStyleBackColor = true;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search Booking";
            // 
            // gpBooking
            // 
            this.gpBooking.Controls.Add(this.txtbooking);
            this.gpBooking.Controls.Add(this.button1);
            this.gpBooking.Controls.Add(this.label6);
            this.gpBooking.Controls.Add(this.btnbooking);
            this.gpBooking.Controls.Add(this.label5);
            this.gpBooking.Controls.Add(this.label4);
            this.gpBooking.Controls.Add(this.txtMovie);
            this.gpBooking.Controls.Add(this.txtCustomer);
            this.gpBooking.Location = new System.Drawing.Point(41, 30);
            this.gpBooking.Name = "gpBooking";
            this.gpBooking.Size = new System.Drawing.Size(255, 272);
            this.gpBooking.TabIndex = 15;
            this.gpBooking.TabStop = false;
            this.gpBooking.Text = " Booking primary details";
            // 
            // txtbooking
            // 
            this.txtbooking.Location = new System.Drawing.Point(92, 50);
            this.txtbooking.Name = "txtbooking";
            this.txtbooking.Size = new System.Drawing.Size(100, 20);
            this.txtbooking.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 20;
            this.button1.Text = "Search Booking ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Movie ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Customer ID:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(92, 102);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 17;
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(92, 76);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(100, 20);
            this.txtMovie.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ticket Sale date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of seats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Ticketcost:";
            // 
            // txtseats
            // 
            this.txtseats.Location = new System.Drawing.Point(274, 59);
            this.txtseats.Name = "txtseats";
            this.txtseats.Size = new System.Drawing.Size(100, 20);
            this.txtseats.TabIndex = 6;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(6, 157);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 52);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update Records";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(274, 33);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 20);
            this.txtcost.TabIndex = 5;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(274, 86);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbdate);
            this.groupBox1.Controls.Add(this.cbseats);
            this.groupBox1.Controls.Add(this.cbcost);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtcost);
            this.groupBox1.Controls.Add(this.btndisplay);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btninsert);
            this.groupBox1.Controls.Add(this.txtseats);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(316, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 272);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display, update and add data";
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(6, 19);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(139, 129);
            this.btndisplay.TabIndex = 3;
            this.btndisplay.Text = "Display Database";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbcost
            // 
            this.cbcost.AutoSize = true;
            this.cbcost.Location = new System.Drawing.Point(380, 33);
            this.cbcost.Name = "cbcost";
            this.cbcost.Size = new System.Drawing.Size(68, 17);
            this.cbcost.TabIndex = 15;
            this.cbcost.Text = "Edit Cost";
            this.cbcost.UseVisualStyleBackColor = true;
            this.cbcost.CheckedChanged += new System.EventHandler(this.cbcost_CheckedChanged);
            // 
            // cbseats
            // 
            this.cbseats.AutoSize = true;
            this.cbseats.Location = new System.Drawing.Point(380, 62);
            this.cbseats.Name = "cbseats";
            this.cbseats.Size = new System.Drawing.Size(74, 17);
            this.cbseats.TabIndex = 16;
            this.cbseats.Text = "Edit Seats";
            this.cbseats.UseVisualStyleBackColor = true;
            this.cbseats.CheckedChanged += new System.EventHandler(this.cbseats_CheckedChanged);
            // 
            // cbdate
            // 
            this.cbdate.AutoSize = true;
            this.cbdate.Location = new System.Drawing.Point(380, 88);
            this.cbdate.Name = "cbdate";
            this.cbdate.Size = new System.Drawing.Size(68, 17);
            this.cbdate.TabIndex = 17;
            this.cbdate.Text = "Edit date";
            this.cbdate.UseVisualStyleBackColor = true;
            this.cbdate.CheckedChanged += new System.EventHandler(this.cbdate_CheckedChanged);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpBooking);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Booking";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpBooking.ResumeLayout(false);
            this.gpBooking.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpBooking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.TextBox txtbooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtseats;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbcost;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.CheckBox cbdate;
        private System.Windows.Forms.CheckBox cbseats;
    }
}
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
            this.dbooking = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aseats = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.acost = new System.Windows.Forms.TextBox();
            this.adate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ubooking = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbdate = new System.Windows.Forms.CheckBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.cbseats = new System.Windows.Forms.CheckBox();
            this.cbcost = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bseats = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.TextBox();
            this.bcost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpBooking.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 373);
            this.dataGridView1.TabIndex = 1;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(41, 214);
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
            this.gpBooking.Controls.Add(this.dbooking);
            this.gpBooking.Controls.Add(this.button1);
            this.gpBooking.Controls.Add(this.label6);
            this.gpBooking.Controls.Add(this.btnbooking);
            this.gpBooking.Controls.Add(this.label5);
            this.gpBooking.Controls.Add(this.label4);
            this.gpBooking.Controls.Add(this.txtMovie);
            this.gpBooking.Controls.Add(this.txtCustomer);
            this.gpBooking.Location = new System.Drawing.Point(41, 30);
            this.gpBooking.Name = "gpBooking";
            this.gpBooking.Size = new System.Drawing.Size(209, 272);
            this.gpBooking.TabIndex = 15;
            this.gpBooking.TabStop = false;
            this.gpBooking.Text = " Booking primary details";
            // 
            // dbooking
            // 
            this.dbooking.Location = new System.Drawing.Point(92, 50);
            this.dbooking.Name = "dbooking";
            this.dbooking.Size = new System.Drawing.Size(100, 20);
            this.dbooking.TabIndex = 21;
            this.dbooking.TextChanged += new System.EventHandler(this.dbooking_TextChanged);
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
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(92, 76);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(100, 20);
            this.txtMovie.TabIndex = 16;
            this.txtMovie.TextChanged += new System.EventHandler(this.txtMovie_TextChanged);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(92, 102);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ticket Sale date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of seats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Ticketcost:";
            // 
            // aseats
            // 
            this.aseats.Location = new System.Drawing.Point(254, 90);
            this.aseats.Name = "aseats";
            this.aseats.Size = new System.Drawing.Size(100, 20);
            this.aseats.TabIndex = 6;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(229, 214);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 52);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update Records";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // acost
            // 
            this.acost.Location = new System.Drawing.Point(254, 64);
            this.acost.Name = "acost";
            this.acost.Size = new System.Drawing.Size(100, 20);
            this.acost.TabIndex = 5;
            // 
            // adate
            // 
            this.adate.Location = new System.Drawing.Point(254, 117);
            this.adate.Name = "adate";
            this.adate.Size = new System.Drawing.Size(100, 20);
            this.adate.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ubooking);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbdate);
            this.groupBox1.Controls.Add(this.btndisplay);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.cbseats);
            this.groupBox1.Controls.Add(this.aseats);
            this.groupBox1.Controls.Add(this.cbcost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.adate);
            this.groupBox1.Controls.Add(this.acost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(256, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 272);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Update Records";
            // 
            // ubooking
            // 
            this.ubooking.Location = new System.Drawing.Point(254, 34);
            this.ubooking.Name = "ubooking";
            this.ubooking.Size = new System.Drawing.Size(100, 20);
            this.ubooking.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Booking _ID";
            // 
            // cbdate
            // 
            this.cbdate.AutoSize = true;
            this.cbdate.Location = new System.Drawing.Point(360, 119);
            this.cbdate.Name = "cbdate";
            this.cbdate.Size = new System.Drawing.Size(68, 17);
            this.cbdate.TabIndex = 17;
            this.cbdate.Text = "Edit date";
            this.cbdate.UseVisualStyleBackColor = true;
            this.cbdate.CheckedChanged += new System.EventHandler(this.cbdate_CheckedChanged);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(13, 19);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(139, 129);
            this.btndisplay.TabIndex = 3;
            this.btndisplay.Text = "Display Database";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbseats
            // 
            this.cbseats.AutoSize = true;
            this.cbseats.Location = new System.Drawing.Point(360, 93);
            this.cbseats.Name = "cbseats";
            this.cbseats.Size = new System.Drawing.Size(74, 17);
            this.cbseats.TabIndex = 16;
            this.cbseats.Text = "Edit Seats";
            this.cbseats.UseVisualStyleBackColor = true;
            this.cbseats.CheckedChanged += new System.EventHandler(this.cbseats_CheckedChanged);
            // 
            // cbcost
            // 
            this.cbcost.AutoSize = true;
            this.cbcost.Location = new System.Drawing.Point(360, 64);
            this.cbcost.Name = "cbcost";
            this.cbcost.Size = new System.Drawing.Size(68, 17);
            this.cbcost.TabIndex = 15;
            this.cbcost.Text = "Edit Cost";
            this.cbcost.UseVisualStyleBackColor = true;
            this.cbcost.CheckedChanged += new System.EventHandler(this.cbcost_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bseats);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btninsert);
            this.groupBox2.Controls.Add(this.bdate);
            this.groupBox2.Controls.Add(this.bcost);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(702, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 272);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a record";
            // 
            // bseats
            // 
            this.bseats.Location = new System.Drawing.Point(100, 60);
            this.bseats.Name = "bseats";
            this.bseats.Size = new System.Drawing.Size(100, 20);
            this.bseats.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Ticketcost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ticket Sale date:";
            // 
            // bdate
            // 
            this.bdate.Location = new System.Drawing.Point(100, 87);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(100, 20);
            this.bdate.TabIndex = 14;
            // 
            // bcost
            // 
            this.bcost.Location = new System.Drawing.Point(100, 34);
            this.bcost.Name = "bcost";
            this.bcost.Size = new System.Drawing.Size(100, 20);
            this.bcost.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Number of seats:";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinemagic.Properties.Resources.CinemagicBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 693);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox dbooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aseats;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox acost;
        private System.Windows.Forms.TextBox adate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbcost;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.CheckBox cbdate;
        private System.Windows.Forms.CheckBox cbseats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bseats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bdate;
        private System.Windows.Forms.TextBox bcost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ubooking;
        private System.Windows.Forms.Label label10;
    }
}
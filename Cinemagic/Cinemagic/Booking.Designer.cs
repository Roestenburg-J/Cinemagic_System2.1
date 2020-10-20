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
            this.btndelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gpBooking = new System.Windows.Forms.GroupBox();
            this.dbooking = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aseats = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.acost = new System.Windows.Forms.TextBox();
            this.gpupdate = new System.Windows.Forms.GroupBox();
            this.adate = new System.Windows.Forms.DateTimePicker();
            this.ubooking = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbdate = new System.Windows.Forms.CheckBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.cbseats = new System.Windows.Forms.CheckBox();
            this.cbcost = new System.Windows.Forms.CheckBox();
            this.gprecord = new System.Windows.Forms.GroupBox();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.bseats = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bcost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpBooking.SuspendLayout();
            this.gpupdate.SuspendLayout();
            this.gprecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 373);
            this.dataGridView1.TabIndex = 1;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(32, 195);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(139, 52);
            this.btninsert.TabIndex = 8;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(36, 195);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 52);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete Booking";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btnbooking_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search Booking";
            // 
            // gpBooking
            // 
            this.gpBooking.Controls.Add(this.dbooking);
            this.gpBooking.Controls.Add(this.btnsearch);
            this.gpBooking.Controls.Add(this.btndelete);
            this.gpBooking.Controls.Add(this.label4);
            this.gpBooking.Location = new System.Drawing.Point(41, 30);
            this.gpBooking.Name = "gpBooking";
            this.gpBooking.Size = new System.Drawing.Size(209, 272);
            this.gpBooking.TabIndex = 15;
            this.gpBooking.TabStop = false;
            this.gpBooking.Text = " Booking primary details";
            this.gpBooking.Enter += new System.EventHandler(this.gpBooking_Enter);
            // 
            // dbooking
            // 
            this.dbooking.Location = new System.Drawing.Point(38, 91);
            this.dbooking.Name = "dbooking";
            this.dbooking.Size = new System.Drawing.Size(137, 20);
            this.dbooking.TabIndex = 21;
            this.dbooking.TextChanged += new System.EventHandler(this.dbooking_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(36, 137);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(139, 52);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "Search Booking ID";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ticket Sale date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of seats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Ticketcost:";
            // 
            // aseats
            // 
            this.aseats.Enabled = false;
            this.aseats.Location = new System.Drawing.Point(253, 75);
            this.aseats.Name = "aseats";
            this.aseats.Size = new System.Drawing.Size(100, 20);
            this.aseats.TabIndex = 6;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(140, 137);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 52);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update Records";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // acost
            // 
            this.acost.Enabled = false;
            this.acost.Location = new System.Drawing.Point(253, 49);
            this.acost.Name = "acost";
            this.acost.Size = new System.Drawing.Size(100, 20);
            this.acost.TabIndex = 5;
            this.acost.TextChanged += new System.EventHandler(this.acost_TextChanged);
            // 
            // gpupdate
            // 
            this.gpupdate.Controls.Add(this.btnrefresh);
            this.gpupdate.Controls.Add(this.adate);
            this.gpupdate.Controls.Add(this.ubooking);
            this.gpupdate.Controls.Add(this.label10);
            this.gpupdate.Controls.Add(this.cbdate);
            this.gpupdate.Controls.Add(this.btnupdate);
            this.gpupdate.Controls.Add(this.cbseats);
            this.gpupdate.Controls.Add(this.aseats);
            this.gpupdate.Controls.Add(this.cbcost);
            this.gpupdate.Controls.Add(this.label1);
            this.gpupdate.Controls.Add(this.label3);
            this.gpupdate.Controls.Add(this.acost);
            this.gpupdate.Controls.Add(this.label2);
            this.gpupdate.Location = new System.Drawing.Point(256, 30);
            this.gpupdate.Name = "gpupdate";
            this.gpupdate.Size = new System.Drawing.Size(438, 272);
            this.gpupdate.TabIndex = 16;
            this.gpupdate.TabStop = false;
            this.gpupdate.Text = " Update Records";
            this.gpupdate.Enter += new System.EventHandler(this.gpupdate_Enter);
            // 
            // adate
            // 
            this.adate.Enabled = false;
            this.adate.Location = new System.Drawing.Point(253, 102);
            this.adate.Name = "adate";
            this.adate.Size = new System.Drawing.Size(100, 20);
            this.adate.TabIndex = 24;
            // 
            // ubooking
            // 
            this.ubooking.Location = new System.Drawing.Point(253, 19);
            this.ubooking.Name = "ubooking";
            this.ubooking.Size = new System.Drawing.Size(100, 20);
            this.ubooking.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Booking _ID";
            // 
            // cbdate
            // 
            this.cbdate.AutoSize = true;
            this.cbdate.Location = new System.Drawing.Point(359, 105);
            this.cbdate.Name = "cbdate";
            this.cbdate.Size = new System.Drawing.Size(68, 17);
            this.cbdate.TabIndex = 17;
            this.cbdate.Text = "Edit date";
            this.cbdate.UseVisualStyleBackColor = true;
            this.cbdate.CheckedChanged += new System.EventHandler(this.cbdate_CheckedChanged);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(711, 325);
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
            this.cbseats.Location = new System.Drawing.Point(359, 77);
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
            this.cbcost.Location = new System.Drawing.Point(359, 51);
            this.cbcost.Name = "cbcost";
            this.cbcost.Size = new System.Drawing.Size(68, 17);
            this.cbcost.TabIndex = 15;
            this.cbcost.Text = "Edit Cost";
            this.cbcost.UseVisualStyleBackColor = true;
            this.cbcost.CheckedChanged += new System.EventHandler(this.cbcost_CheckedChanged);
            // 
            // gprecord
            // 
            this.gprecord.Controls.Add(this.bdate);
            this.gprecord.Controls.Add(this.bseats);
            this.gprecord.Controls.Add(this.label7);
            this.gprecord.Controls.Add(this.label8);
            this.gprecord.Controls.Add(this.btninsert);
            this.gprecord.Controls.Add(this.bcost);
            this.gprecord.Controls.Add(this.label9);
            this.gprecord.Location = new System.Drawing.Point(702, 30);
            this.gprecord.Name = "gprecord";
            this.gprecord.Size = new System.Drawing.Size(209, 272);
            this.gprecord.TabIndex = 17;
            this.gprecord.TabStop = false;
            this.gprecord.Text = "Add a record";
            this.gprecord.Enter += new System.EventHandler(this.gprecord_Enter);
            // 
            // bdate
            // 
            this.bdate.Location = new System.Drawing.Point(100, 90);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(100, 20);
            this.bdate.TabIndex = 25;
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
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(285, 137);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(139, 52);
            this.btnrefresh.TabIndex = 25;
            this.btnrefresh.Text = "Refresh database";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(711, 479);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(139, 52);
            this.btnMain.TabIndex = 18;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinemagic.Properties.Resources.CinemagicBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 693);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.gprecord);
            this.Controls.Add(this.gpupdate);
            this.Controls.Add(this.gpBooking);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndisplay);
            this.Name = "Booking";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpBooking.ResumeLayout(false);
            this.gpBooking.PerformLayout();
            this.gpupdate.ResumeLayout(false);
            this.gpupdate.PerformLayout();
            this.gprecord.ResumeLayout(false);
            this.gprecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpBooking;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox dbooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aseats;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox acost;
        private System.Windows.Forms.GroupBox gpupdate;
        private System.Windows.Forms.CheckBox cbcost;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.CheckBox cbdate;
        private System.Windows.Forms.CheckBox cbseats;
        private System.Windows.Forms.GroupBox gprecord;
        private System.Windows.Forms.TextBox bseats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bcost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ubooking;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker adate;
        private System.Windows.Forms.DateTimePicker bdate;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnMain;
    }
}
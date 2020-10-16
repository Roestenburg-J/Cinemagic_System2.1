namespace Cinemagic
{
    partial class Movie
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
            this.moviesGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.aNameBox = new System.Windows.Forms.TextBox();
            this.aGenreBox = new System.Windows.Forms.TextBox();
            this.aDurationBox = new System.Windows.Forms.TextBox();
            this.aAgeBox = new System.Windows.Forms.TextBox();
            this.aReleaseBox = new System.Windows.Forms.TextBox();
            this.aWithdrawBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dIDBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.uAgeBox = new System.Windows.Forms.TextBox();
            this.uDurationBox = new System.Windows.Forms.TextBox();
            this.uGenreBox = new System.Windows.Forms.TextBox();
            this.uNameBox = new System.Windows.Forms.TextBox();
            this.uIDBox = new System.Windows.Forms.TextBox();
            this.uReleaseBox = new System.Windows.Forms.TextBox();
            this.uWithdrawBox = new System.Windows.Forms.TextBox();
            this.nameCB = new System.Windows.Forms.CheckBox();
            this.genreCB = new System.Windows.Forms.CheckBox();
            this.durationCB = new System.Windows.Forms.CheckBox();
            this.ageCB = new System.Windows.Forms.CheckBox();
            this.releaseCB = new System.Windows.Forms.CheckBox();
            this.withdrawCB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // moviesGrid
            // 
            this.moviesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesGrid.Location = new System.Drawing.Point(12, 42);
            this.moviesGrid.Name = "moviesGrid";
            this.moviesGrid.RowTemplate.Height = 24;
            this.moviesGrid.Size = new System.Drawing.Size(455, 485);
            this.moviesGrid.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aWithdrawBox);
            this.groupBox1.Controls.Add(this.aReleaseBox);
            this.groupBox1.Controls.Add(this.aAgeBox);
            this.groupBox1.Controls.Add(this.aDurationBox);
            this.groupBox1.Controls.Add(this.aGenreBox);
            this.groupBox1.Controls.Add(this.aNameBox);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(484, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Movie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Withdrawal Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Release Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age Restriction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(118, 222);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 47);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // aNameBox
            // 
            this.aNameBox.Location = new System.Drawing.Point(152, 24);
            this.aNameBox.Name = "aNameBox";
            this.aNameBox.Size = new System.Drawing.Size(100, 22);
            this.aNameBox.TabIndex = 10;
            // 
            // aGenreBox
            // 
            this.aGenreBox.Location = new System.Drawing.Point(152, 50);
            this.aGenreBox.Name = "aGenreBox";
            this.aGenreBox.Size = new System.Drawing.Size(100, 22);
            this.aGenreBox.TabIndex = 11;
            // 
            // aDurationBox
            // 
            this.aDurationBox.Location = new System.Drawing.Point(152, 78);
            this.aDurationBox.Name = "aDurationBox";
            this.aDurationBox.Size = new System.Drawing.Size(100, 22);
            this.aDurationBox.TabIndex = 1;
            // 
            // aAgeBox
            // 
            this.aAgeBox.Location = new System.Drawing.Point(152, 105);
            this.aAgeBox.Name = "aAgeBox";
            this.aAgeBox.Size = new System.Drawing.Size(100, 22);
            this.aAgeBox.TabIndex = 1;
            // 
            // aReleaseBox
            // 
            this.aReleaseBox.Location = new System.Drawing.Point(152, 133);
            this.aReleaseBox.Name = "aReleaseBox";
            this.aReleaseBox.Size = new System.Drawing.Size(100, 22);
            this.aReleaseBox.TabIndex = 1;
            // 
            // aWithdrawBox
            // 
            this.aWithdrawBox.Location = new System.Drawing.Point(152, 159);
            this.aWithdrawBox.Name = "aWithdrawBox";
            this.aWithdrawBox.Size = new System.Drawing.Size(100, 22);
            this.aWithdrawBox.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dIDBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.delBtn);
            this.groupBox4.Location = new System.Drawing.Point(1209, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 136);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Movie";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(75, 78);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(101, 44);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Movie ID:";
            // 
            // dIDBox
            // 
            this.dIDBox.Location = new System.Drawing.Point(129, 26);
            this.dIDBox.Name = "dIDBox";
            this.dIDBox.Size = new System.Drawing.Size(100, 22);
            this.dIDBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.withdrawCB);
            this.groupBox3.Controls.Add(this.releaseCB);
            this.groupBox3.Controls.Add(this.ageCB);
            this.groupBox3.Controls.Add(this.durationCB);
            this.groupBox3.Controls.Add(this.genreCB);
            this.groupBox3.Controls.Add(this.nameCB);
            this.groupBox3.Controls.Add(this.uWithdrawBox);
            this.groupBox3.Controls.Add(this.uReleaseBox);
            this.groupBox3.Controls.Add(this.uIDBox);
            this.groupBox3.Controls.Add(this.uNameBox);
            this.groupBox3.Controls.Add(this.uGenreBox);
            this.groupBox3.Controls.Add(this.uDurationBox);
            this.groupBox3.Controls.Add(this.uAgeBox);
            this.groupBox3.Controls.Add(this.updateBtn);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(848, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 292);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Movie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Movie ID:";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(135, 222);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(101, 47);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // uAgeBox
            // 
            this.uAgeBox.Location = new System.Drawing.Point(151, 133);
            this.uAgeBox.Name = "uAgeBox";
            this.uAgeBox.Size = new System.Drawing.Size(100, 22);
            this.uAgeBox.TabIndex = 14;
            // 
            // uDurationBox
            // 
            this.uDurationBox.Location = new System.Drawing.Point(151, 105);
            this.uDurationBox.Name = "uDurationBox";
            this.uDurationBox.Size = new System.Drawing.Size(100, 22);
            this.uDurationBox.TabIndex = 6;
            // 
            // uGenreBox
            // 
            this.uGenreBox.Location = new System.Drawing.Point(151, 78);
            this.uGenreBox.Name = "uGenreBox";
            this.uGenreBox.Size = new System.Drawing.Size(100, 22);
            this.uGenreBox.TabIndex = 5;
            // 
            // uNameBox
            // 
            this.uNameBox.Location = new System.Drawing.Point(151, 50);
            this.uNameBox.Name = "uNameBox";
            this.uNameBox.Size = new System.Drawing.Size(100, 22);
            this.uNameBox.TabIndex = 4;
            // 
            // uIDBox
            // 
            this.uIDBox.Location = new System.Drawing.Point(151, 24);
            this.uIDBox.Name = "uIDBox";
            this.uIDBox.Size = new System.Drawing.Size(100, 22);
            this.uIDBox.TabIndex = 3;
            // 
            // uReleaseBox
            // 
            this.uReleaseBox.Location = new System.Drawing.Point(151, 159);
            this.uReleaseBox.Name = "uReleaseBox";
            this.uReleaseBox.Size = new System.Drawing.Size(100, 22);
            this.uReleaseBox.TabIndex = 2;
            // 
            // uWithdrawBox
            // 
            this.uWithdrawBox.Location = new System.Drawing.Point(151, 185);
            this.uWithdrawBox.Name = "uWithdrawBox";
            this.uWithdrawBox.Size = new System.Drawing.Size(100, 22);
            this.uWithdrawBox.TabIndex = 1;
            // 
            // nameCB
            // 
            this.nameCB.AutoSize = true;
            this.nameCB.Location = new System.Drawing.Point(6, 54);
            this.nameCB.Name = "nameCB";
            this.nameCB.Size = new System.Drawing.Size(71, 21);
            this.nameCB.TabIndex = 15;
            this.nameCB.Text = "Name:";
            this.nameCB.UseVisualStyleBackColor = true;
            // 
            // genreCB
            // 
            this.genreCB.AutoSize = true;
            this.genreCB.Location = new System.Drawing.Point(6, 80);
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(74, 21);
            this.genreCB.TabIndex = 16;
            this.genreCB.Text = "Genre:";
            this.genreCB.UseVisualStyleBackColor = true;
            // 
            // durationCB
            // 
            this.durationCB.AutoSize = true;
            this.durationCB.Location = new System.Drawing.Point(6, 107);
            this.durationCB.Name = "durationCB";
            this.durationCB.Size = new System.Drawing.Size(88, 21);
            this.durationCB.TabIndex = 17;
            this.durationCB.Text = "Duration:";
            this.durationCB.UseVisualStyleBackColor = true;
            this.durationCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ageCB
            // 
            this.ageCB.AutoSize = true;
            this.ageCB.Location = new System.Drawing.Point(6, 135);
            this.ageCB.Name = "ageCB";
            this.ageCB.Size = new System.Drawing.Size(130, 21);
            this.ageCB.TabIndex = 18;
            this.ageCB.Text = "Age Restriction:";
            this.ageCB.UseVisualStyleBackColor = true;
            // 
            // releaseCB
            // 
            this.releaseCB.AutoSize = true;
            this.releaseCB.Location = new System.Drawing.Point(6, 161);
            this.releaseCB.Name = "releaseCB";
            this.releaseCB.Size = new System.Drawing.Size(120, 21);
            this.releaseCB.TabIndex = 19;
            this.releaseCB.Text = "Release Date:";
            this.releaseCB.UseVisualStyleBackColor = true;
            // 
            // withdrawCB
            // 
            this.withdrawCB.AutoSize = true;
            this.withdrawCB.Location = new System.Drawing.Point(6, 185);
            this.withdrawCB.Name = "withdrawCB";
            this.withdrawCB.Size = new System.Drawing.Size(133, 21);
            this.withdrawCB.TabIndex = 20;
            this.withdrawCB.Text = "Withdrawal Date";
            this.withdrawCB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1274, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return To Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinemagic.Properties.Resources.CinemagicBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1456, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moviesGrid);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Movie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView moviesGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox aWithdrawBox;
        private System.Windows.Forms.TextBox aReleaseBox;
        private System.Windows.Forms.TextBox aAgeBox;
        private System.Windows.Forms.TextBox aDurationBox;
        private System.Windows.Forms.TextBox aGenreBox;
        private System.Windows.Forms.TextBox aNameBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox dIDBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox withdrawCB;
        private System.Windows.Forms.CheckBox releaseCB;
        private System.Windows.Forms.CheckBox ageCB;
        private System.Windows.Forms.CheckBox durationCB;
        private System.Windows.Forms.CheckBox genreCB;
        private System.Windows.Forms.CheckBox nameCB;
        private System.Windows.Forms.TextBox uWithdrawBox;
        private System.Windows.Forms.TextBox uReleaseBox;
        private System.Windows.Forms.TextBox uIDBox;
        private System.Windows.Forms.TextBox uNameBox;
        private System.Windows.Forms.TextBox uGenreBox;
        private System.Windows.Forms.TextBox uDurationBox;
        private System.Windows.Forms.TextBox uAgeBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}
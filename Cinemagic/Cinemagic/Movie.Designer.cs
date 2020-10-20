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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.withdrawCB = new System.Windows.Forms.CheckBox();
            this.releaseCB = new System.Windows.Forms.CheckBox();
            this.ageCB = new System.Windows.Forms.CheckBox();
            this.durationCB = new System.Windows.Forms.CheckBox();
            this.genreCB = new System.Windows.Forms.CheckBox();
            this.nameCB = new System.Windows.Forms.CheckBox();
            this.uWithdrawBox = new System.Windows.Forms.TextBox();
            this.uReleaseBox = new System.Windows.Forms.TextBox();
            this.uIDBox = new System.Windows.Forms.TextBox();
            this.uNameBox = new System.Windows.Forms.TextBox();
            this.uGenreBox = new System.Windows.Forms.TextBox();
            this.uDurationBox = new System.Windows.Forms.TextBox();
            this.uAgeBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dIDBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aWithdrawBox = new System.Windows.Forms.TextBox();
            this.aReleaseBox = new System.Windows.Forms.TextBox();
            this.aAgeBox = new System.Windows.Forms.TextBox();
            this.aDurationBox = new System.Windows.Forms.TextBox();
            this.aGenreBox = new System.Windows.Forms.TextBox();
            this.aNameBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.moviesGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Cinemagic.Properties.Resources.CinemagicBackground;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(355, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(728, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maintain Movies";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Return To Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBox3.Location = new System.Drawing.Point(280, 39);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(254, 237);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Movie";
            // 
            // withdrawCB
            // 
            this.withdrawCB.AutoSize = true;
            this.withdrawCB.Location = new System.Drawing.Point(4, 150);
            this.withdrawCB.Margin = new System.Windows.Forms.Padding(2);
            this.withdrawCB.Name = "withdrawCB";
            this.withdrawCB.Size = new System.Drawing.Size(105, 17);
            this.withdrawCB.TabIndex = 20;
            this.withdrawCB.Text = "Withdrawal Date";
            this.withdrawCB.UseVisualStyleBackColor = true;
            // 
            // releaseCB
            // 
            this.releaseCB.AutoSize = true;
            this.releaseCB.Location = new System.Drawing.Point(4, 131);
            this.releaseCB.Margin = new System.Windows.Forms.Padding(2);
            this.releaseCB.Name = "releaseCB";
            this.releaseCB.Size = new System.Drawing.Size(94, 17);
            this.releaseCB.TabIndex = 19;
            this.releaseCB.Text = "Release Date:";
            this.releaseCB.UseVisualStyleBackColor = true;
            // 
            // ageCB
            // 
            this.ageCB.AutoSize = true;
            this.ageCB.Location = new System.Drawing.Point(4, 110);
            this.ageCB.Margin = new System.Windows.Forms.Padding(2);
            this.ageCB.Name = "ageCB";
            this.ageCB.Size = new System.Drawing.Size(101, 17);
            this.ageCB.TabIndex = 18;
            this.ageCB.Text = "Age Restriction:";
            this.ageCB.UseVisualStyleBackColor = true;
            // 
            // durationCB
            // 
            this.durationCB.AutoSize = true;
            this.durationCB.Location = new System.Drawing.Point(4, 87);
            this.durationCB.Margin = new System.Windows.Forms.Padding(2);
            this.durationCB.Name = "durationCB";
            this.durationCB.Size = new System.Drawing.Size(69, 17);
            this.durationCB.TabIndex = 17;
            this.durationCB.Text = "Duration:";
            this.durationCB.UseVisualStyleBackColor = true;
            this.durationCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // genreCB
            // 
            this.genreCB.AutoSize = true;
            this.genreCB.Location = new System.Drawing.Point(4, 65);
            this.genreCB.Margin = new System.Windows.Forms.Padding(2);
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(58, 17);
            this.genreCB.TabIndex = 16;
            this.genreCB.Text = "Genre:";
            this.genreCB.UseVisualStyleBackColor = true;
            // 
            // nameCB
            // 
            this.nameCB.AutoSize = true;
            this.nameCB.Location = new System.Drawing.Point(4, 44);
            this.nameCB.Margin = new System.Windows.Forms.Padding(2);
            this.nameCB.Name = "nameCB";
            this.nameCB.Size = new System.Drawing.Size(57, 17);
            this.nameCB.TabIndex = 15;
            this.nameCB.Text = "Name:";
            this.nameCB.UseVisualStyleBackColor = true;
            // 
            // uWithdrawBox
            // 
            this.uWithdrawBox.Location = new System.Drawing.Point(113, 150);
            this.uWithdrawBox.Margin = new System.Windows.Forms.Padding(2);
            this.uWithdrawBox.Name = "uWithdrawBox";
            this.uWithdrawBox.Size = new System.Drawing.Size(76, 20);
            this.uWithdrawBox.TabIndex = 1;
            // 
            // uReleaseBox
            // 
            this.uReleaseBox.Location = new System.Drawing.Point(113, 129);
            this.uReleaseBox.Margin = new System.Windows.Forms.Padding(2);
            this.uReleaseBox.Name = "uReleaseBox";
            this.uReleaseBox.Size = new System.Drawing.Size(76, 20);
            this.uReleaseBox.TabIndex = 2;
            // 
            // uIDBox
            // 
            this.uIDBox.Location = new System.Drawing.Point(113, 20);
            this.uIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.uIDBox.Name = "uIDBox";
            this.uIDBox.Size = new System.Drawing.Size(76, 20);
            this.uIDBox.TabIndex = 3;
            // 
            // uNameBox
            // 
            this.uNameBox.Location = new System.Drawing.Point(113, 41);
            this.uNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.uNameBox.Name = "uNameBox";
            this.uNameBox.Size = new System.Drawing.Size(76, 20);
            this.uNameBox.TabIndex = 4;
            // 
            // uGenreBox
            // 
            this.uGenreBox.Location = new System.Drawing.Point(113, 63);
            this.uGenreBox.Margin = new System.Windows.Forms.Padding(2);
            this.uGenreBox.Name = "uGenreBox";
            this.uGenreBox.Size = new System.Drawing.Size(76, 20);
            this.uGenreBox.TabIndex = 5;
            // 
            // uDurationBox
            // 
            this.uDurationBox.Location = new System.Drawing.Point(113, 85);
            this.uDurationBox.Margin = new System.Windows.Forms.Padding(2);
            this.uDurationBox.Name = "uDurationBox";
            this.uDurationBox.Size = new System.Drawing.Size(76, 20);
            this.uDurationBox.TabIndex = 6;
            // 
            // uAgeBox
            // 
            this.uAgeBox.Location = new System.Drawing.Point(113, 108);
            this.uAgeBox.Margin = new System.Windows.Forms.Padding(2);
            this.uAgeBox.Name = "uAgeBox";
            this.uAgeBox.Size = new System.Drawing.Size(76, 20);
            this.uAgeBox.TabIndex = 14;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(101, 180);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(76, 38);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Movie ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dIDBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.delBtn);
            this.groupBox4.Location = new System.Drawing.Point(13, 288);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(176, 110);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Movie";
            // 
            // dIDBox
            // 
            this.dIDBox.Location = new System.Drawing.Point(97, 21);
            this.dIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.dIDBox.Name = "dIDBox";
            this.dIDBox.Size = new System.Drawing.Size(76, 20);
            this.dIDBox.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Movie ID:";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(56, 63);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(76, 36);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(254, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Movie";
            // 
            // aWithdrawBox
            // 
            this.aWithdrawBox.Location = new System.Drawing.Point(114, 129);
            this.aWithdrawBox.Margin = new System.Windows.Forms.Padding(2);
            this.aWithdrawBox.Name = "aWithdrawBox";
            this.aWithdrawBox.Size = new System.Drawing.Size(76, 20);
            this.aWithdrawBox.TabIndex = 2;
            // 
            // aReleaseBox
            // 
            this.aReleaseBox.Location = new System.Drawing.Point(114, 108);
            this.aReleaseBox.Margin = new System.Windows.Forms.Padding(2);
            this.aReleaseBox.Name = "aReleaseBox";
            this.aReleaseBox.Size = new System.Drawing.Size(76, 20);
            this.aReleaseBox.TabIndex = 1;
            // 
            // aAgeBox
            // 
            this.aAgeBox.Location = new System.Drawing.Point(114, 85);
            this.aAgeBox.Margin = new System.Windows.Forms.Padding(2);
            this.aAgeBox.Name = "aAgeBox";
            this.aAgeBox.Size = new System.Drawing.Size(76, 20);
            this.aAgeBox.TabIndex = 1;
            // 
            // aDurationBox
            // 
            this.aDurationBox.Location = new System.Drawing.Point(114, 63);
            this.aDurationBox.Margin = new System.Windows.Forms.Padding(2);
            this.aDurationBox.Name = "aDurationBox";
            this.aDurationBox.Size = new System.Drawing.Size(76, 20);
            this.aDurationBox.TabIndex = 1;
            this.aDurationBox.TextChanged += new System.EventHandler(this.aDurationBox_TextChanged);
            // 
            // aGenreBox
            // 
            this.aGenreBox.Location = new System.Drawing.Point(114, 41);
            this.aGenreBox.Margin = new System.Windows.Forms.Padding(2);
            this.aGenreBox.Name = "aGenreBox";
            this.aGenreBox.Size = new System.Drawing.Size(76, 20);
            this.aGenreBox.TabIndex = 11;
            // 
            // aNameBox
            // 
            this.aNameBox.Location = new System.Drawing.Point(114, 20);
            this.aNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.aNameBox.Name = "aNameBox";
            this.aNameBox.Size = new System.Drawing.Size(76, 20);
            this.aNameBox.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(88, 180);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(76, 38);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age Restriction:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Release Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Withdrawal Date:";
            // 
            // moviesGrid
            // 
            this.moviesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesGrid.Location = new System.Drawing.Point(9, 15);
            this.moviesGrid.Margin = new System.Windows.Forms.Padding(2);
            this.moviesGrid.Name = "moviesGrid";
            this.moviesGrid.RowTemplate.Height = 24;
            this.moviesGrid.Size = new System.Drawing.Size(341, 394);
            this.moviesGrid.TabIndex = 1;
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 421);
            this.Controls.Add(this.moviesGrid);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Movie";
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.Movie_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView moviesGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aGenreBox;
        private System.Windows.Forms.TextBox aNameBox;
        private System.Windows.Forms.TextBox uAgeBox;
        private System.Windows.Forms.TextBox dIDBox;
        private System.Windows.Forms.TextBox aReleaseBox;
        private System.Windows.Forms.TextBox aAgeBox;
        private System.Windows.Forms.TextBox aDurationBox;
        private System.Windows.Forms.TextBox aWithdrawBox;
        private System.Windows.Forms.TextBox uWithdrawBox;
        private System.Windows.Forms.TextBox uReleaseBox;
        private System.Windows.Forms.TextBox uIDBox;
        private System.Windows.Forms.TextBox uNameBox;
        private System.Windows.Forms.TextBox uGenreBox;
        private System.Windows.Forms.TextBox uDurationBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox durationCB;
        private System.Windows.Forms.CheckBox genreCB;
        private System.Windows.Forms.CheckBox nameCB;
        private System.Windows.Forms.CheckBox withdrawCB;
        private System.Windows.Forms.CheckBox releaseCB;
        private System.Windows.Forms.CheckBox ageCB;
        private System.Windows.Forms.Button button1;
    }
}
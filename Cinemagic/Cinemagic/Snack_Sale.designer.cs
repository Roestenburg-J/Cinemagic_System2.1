namespace RandomProj
{
    partial class Snack_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snack_Sale));
            this.groupBox_SnackSale = new System.Windows.Forms.GroupBox();
            this.lblBack = new System.Windows.Forms.Button();
            this.groupBox_Delete = new System.Windows.Forms.GroupBox();
            this.btnDelete_Date = new System.Windows.Forms.Button();
            this.lblDeleteDate = new System.Windows.Forms.Label();
            this.spinDeleteDate = new System.Windows.Forms.NumericUpDown();
            this.lblDelete = new System.Windows.Forms.Label();
            this.groupBox_Edit = new System.Windows.Forms.GroupBox();
            this.numDate_ID = new System.Windows.Forms.NumericUpDown();
            this.lblFill_ID = new System.Windows.Forms.Label();
            this.btnEdit_Date = new System.Windows.Forms.Button();
            this.Transact_Date_Edit = new System.Windows.Forms.DateTimePicker();
            this.lblDate_Edit = new System.Windows.Forms.Label();
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.btnAdd_Date = new System.Windows.Forms.Button();
            this.Transact_Date = new System.Windows.Forms.DateTimePicker();
            this.lblAddDate = new System.Windows.Forms.Label();
            this.dbGrid_Dates = new System.Windows.Forms.DataGridView();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            this.groupBox_SnackSale.SuspendLayout();
            this.groupBox_Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeleteDate)).BeginInit();
            this.groupBox_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDate_ID)).BeginInit();
            this.groupBox_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_Dates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SnackSale
            // 
            this.groupBox_SnackSale.Controls.Add(this.lblBack);
            this.groupBox_SnackSale.Controls.Add(this.groupBox_Delete);
            this.groupBox_SnackSale.Controls.Add(this.groupBox_Edit);
            this.groupBox_SnackSale.Controls.Add(this.groupBox_Add);
            this.groupBox_SnackSale.Controls.Add(this.dbGrid_Dates);
            this.groupBox_SnackSale.Location = new System.Drawing.Point(31, 25);
            this.groupBox_SnackSale.Name = "groupBox_SnackSale";
            this.groupBox_SnackSale.Size = new System.Drawing.Size(996, 484);
            this.groupBox_SnackSale.TabIndex = 0;
            this.groupBox_SnackSale.TabStop = false;
            this.groupBox_SnackSale.Text = "ADD DATE TO SNACK TRANSACTION";
            // 
            // lblBack
            // 
            this.lblBack.Location = new System.Drawing.Point(722, 365);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(249, 55);
            this.lblBack.TabIndex = 26;
            this.lblBack.Text = "BACK TO SNACK TRANSACTIONS";
            this.lblBack.UseVisualStyleBackColor = true;
            this.lblBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox_Delete
            // 
            this.groupBox_Delete.Controls.Add(this.btnDelete_Date);
            this.groupBox_Delete.Controls.Add(this.lblDeleteDate);
            this.groupBox_Delete.Controls.Add(this.spinDeleteDate);
            this.groupBox_Delete.Controls.Add(this.lblDelete);
            this.groupBox_Delete.Location = new System.Drawing.Point(415, 317);
            this.groupBox_Delete.Name = "groupBox_Delete";
            this.groupBox_Delete.Size = new System.Drawing.Size(277, 136);
            this.groupBox_Delete.TabIndex = 0;
            this.groupBox_Delete.TabStop = false;
            this.groupBox_Delete.Text = "DELETE DATE";
            // 
            // btnDelete_Date
            // 
            this.btnDelete_Date.Location = new System.Drawing.Point(9, 95);
            this.btnDelete_Date.Name = "btnDelete_Date";
            this.btnDelete_Date.Size = new System.Drawing.Size(102, 23);
            this.btnDelete_Date.TabIndex = 27;
            this.btnDelete_Date.Text = "DELETE";
            this.btnDelete_Date.UseVisualStyleBackColor = true;
            this.btnDelete_Date.Click += new System.EventHandler(this.btnDelete_Date_Click);
            // 
            // lblDeleteDate
            // 
            this.lblDeleteDate.AutoSize = true;
            this.lblDeleteDate.Location = new System.Drawing.Point(6, 25);
            this.lblDeleteDate.Name = "lblDeleteDate";
            this.lblDeleteDate.Size = new System.Drawing.Size(247, 17);
            this.lblDeleteDate.TabIndex = 26;
            this.lblDeleteDate.Text = "DELETE SALE DATE WITH DATE_ID:";
            // 
            // spinDeleteDate
            // 
            this.spinDeleteDate.Location = new System.Drawing.Point(97, 54);
            this.spinDeleteDate.Name = "spinDeleteDate";
            this.spinDeleteDate.Size = new System.Drawing.Size(100, 22);
            this.spinDeleteDate.TabIndex = 25;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(6, 56);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(63, 17);
            this.lblDelete.TabIndex = 24;
            this.lblDelete.Text = "Date_ID:";
            // 
            // groupBox_Edit
            // 
            this.groupBox_Edit.Controls.Add(this.numDate_ID);
            this.groupBox_Edit.Controls.Add(this.lblFill_ID);
            this.groupBox_Edit.Controls.Add(this.btnEdit_Date);
            this.groupBox_Edit.Controls.Add(this.Transact_Date_Edit);
            this.groupBox_Edit.Controls.Add(this.lblDate_Edit);
            this.groupBox_Edit.Location = new System.Drawing.Point(57, 231);
            this.groupBox_Edit.Name = "groupBox_Edit";
            this.groupBox_Edit.Size = new System.Drawing.Size(285, 204);
            this.groupBox_Edit.TabIndex = 0;
            this.groupBox_Edit.TabStop = false;
            this.groupBox_Edit.Text = "EDIT DATE";
            // 
            // numDate_ID
            // 
            this.numDate_ID.Location = new System.Drawing.Point(81, 59);
            this.numDate_ID.Name = "numDate_ID";
            this.numDate_ID.Size = new System.Drawing.Size(120, 22);
            this.numDate_ID.TabIndex = 2;
            // 
            // lblFill_ID
            // 
            this.lblFill_ID.AutoSize = true;
            this.lblFill_ID.Location = new System.Drawing.Point(96, 39);
            this.lblFill_ID.Name = "lblFill_ID";
            this.lblFill_ID.Size = new System.Drawing.Size(97, 17);
            this.lblFill_ID.TabIndex = 6;
            this.lblFill_ID.Text = "Enter Date ID:";
            // 
            // btnEdit_Date
            // 
            this.btnEdit_Date.Location = new System.Drawing.Point(81, 166);
            this.btnEdit_Date.Name = "btnEdit_Date";
            this.btnEdit_Date.Size = new System.Drawing.Size(96, 23);
            this.btnEdit_Date.TabIndex = 5;
            this.btnEdit_Date.Text = "UPDATE";
            this.btnEdit_Date.UseVisualStyleBackColor = true;
            this.btnEdit_Date.Click += new System.EventHandler(this.btnEdit_Date_Click);
            // 
            // Transact_Date_Edit
            // 
            this.Transact_Date_Edit.Location = new System.Drawing.Point(45, 125);
            this.Transact_Date_Edit.Name = "Transact_Date_Edit";
            this.Transact_Date_Edit.Size = new System.Drawing.Size(200, 22);
            this.Transact_Date_Edit.TabIndex = 4;
            // 
            // lblDate_Edit
            // 
            this.lblDate_Edit.AutoSize = true;
            this.lblDate_Edit.Location = new System.Drawing.Point(124, 105);
            this.lblDate_Edit.Name = "lblDate_Edit";
            this.lblDate_Edit.Size = new System.Drawing.Size(42, 17);
            this.lblDate_Edit.TabIndex = 3;
            this.lblDate_Edit.Text = "Date:";
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.btnAdd_Date);
            this.groupBox_Add.Controls.Add(this.Transact_Date);
            this.groupBox_Add.Controls.Add(this.lblAddDate);
            this.groupBox_Add.Location = new System.Drawing.Point(57, 40);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Size = new System.Drawing.Size(245, 156);
            this.groupBox_Add.TabIndex = 1;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "ADD DATE";
            // 
            // btnAdd_Date
            // 
            this.btnAdd_Date.Location = new System.Drawing.Point(81, 106);
            this.btnAdd_Date.Name = "btnAdd_Date";
            this.btnAdd_Date.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Date.TabIndex = 2;
            this.btnAdd_Date.Text = "ADD";
            this.btnAdd_Date.UseVisualStyleBackColor = true;
            this.btnAdd_Date.Click += new System.EventHandler(this.btnAdd_Date_Click);
            // 
            // Transact_Date
            // 
            this.Transact_Date.Location = new System.Drawing.Point(21, 67);
            this.Transact_Date.Name = "Transact_Date";
            this.Transact_Date.Size = new System.Drawing.Size(200, 22);
            this.Transact_Date.TabIndex = 1;
            // 
            // lblAddDate
            // 
            this.lblAddDate.AutoSize = true;
            this.lblAddDate.Location = new System.Drawing.Point(100, 47);
            this.lblAddDate.Name = "lblAddDate";
            this.lblAddDate.Size = new System.Drawing.Size(42, 17);
            this.lblAddDate.TabIndex = 0;
            this.lblAddDate.Text = "Date:";
            // 
            // dbGrid_Dates
            // 
            this.dbGrid_Dates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid_Dates.Location = new System.Drawing.Point(415, 40);
            this.dbGrid_Dates.Name = "dbGrid_Dates";
            this.dbGrid_Dates.RowTemplate.Height = 24;
            this.dbGrid_Dates.Size = new System.Drawing.Size(556, 247);
            this.dbGrid_Dates.TabIndex = 0;
            // 
            // pboxBackground
            // 
            this.pboxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackground.Image")));
            this.pboxBackground.Location = new System.Drawing.Point(-6, -3);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(1075, 542);
            this.pboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBackground.TabIndex = 5;
            this.pboxBackground.TabStop = false;
            // 
            // Snack_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 536);
            this.Controls.Add(this.groupBox_SnackSale);
            this.Controls.Add(this.pboxBackground);
            this.Name = "Snack_Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snack_Sale";
            this.Load += new System.EventHandler(this.Snack_Sale_Load);
            this.groupBox_SnackSale.ResumeLayout(false);
            this.groupBox_Delete.ResumeLayout(false);
            this.groupBox_Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeleteDate)).EndInit();
            this.groupBox_Edit.ResumeLayout(false);
            this.groupBox_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDate_ID)).EndInit();
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_Dates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SnackSale;
        private System.Windows.Forms.DataGridView dbGrid_Dates;
        private System.Windows.Forms.GroupBox groupBox_Delete;
        private System.Windows.Forms.GroupBox groupBox_Edit;
        private System.Windows.Forms.GroupBox groupBox_Add;
        private System.Windows.Forms.Label lblAddDate;
        private System.Windows.Forms.Button btnAdd_Date;
        private System.Windows.Forms.DateTimePicker Transact_Date;
        private System.Windows.Forms.Button btnEdit_Date;
        private System.Windows.Forms.DateTimePicker Transact_Date_Edit;
        private System.Windows.Forms.Label lblDate_Edit;
        private System.Windows.Forms.Label lblFill_ID;
        private System.Windows.Forms.NumericUpDown numDate_ID;
        private System.Windows.Forms.Button btnDelete_Date;
        private System.Windows.Forms.Label lblDeleteDate;
        private System.Windows.Forms.NumericUpDown spinDeleteDate;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button lblBack;
        private System.Windows.Forms.PictureBox pboxBackground;
    }
}
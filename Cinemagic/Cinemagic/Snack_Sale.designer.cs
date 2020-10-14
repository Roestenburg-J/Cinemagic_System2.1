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
            this.groupBox_SnackSale = new System.Windows.Forms.GroupBox();
            this.groupBox_Delete = new System.Windows.Forms.GroupBox();
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
            this.groupBox_SnackSale.SuspendLayout();
            this.groupBox_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDate_ID)).BeginInit();
            this.groupBox_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_Dates)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SnackSale
            // 
            this.groupBox_SnackSale.Controls.Add(this.groupBox_Delete);
            this.groupBox_SnackSale.Controls.Add(this.groupBox_Edit);
            this.groupBox_SnackSale.Controls.Add(this.groupBox_Add);
            this.groupBox_SnackSale.Controls.Add(this.dbGrid_Dates);
            this.groupBox_SnackSale.Location = new System.Drawing.Point(9, 10);
            this.groupBox_SnackSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_SnackSale.Name = "groupBox_SnackSale";
            this.groupBox_SnackSale.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_SnackSale.Size = new System.Drawing.Size(747, 404);
            this.groupBox_SnackSale.TabIndex = 0;
            this.groupBox_SnackSale.TabStop = false;
            this.groupBox_SnackSale.Text = "ADD DATE TO SNACK TRANSACTION";
            this.groupBox_SnackSale.Enter += new System.EventHandler(this.groupBox_SnackSale_Enter);
            // 
            // groupBox_Delete
            // 
            this.groupBox_Delete.Location = new System.Drawing.Point(540, 272);
            this.groupBox_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Delete.Name = "groupBox_Delete";
            this.groupBox_Delete.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Delete.Size = new System.Drawing.Size(150, 81);
            this.groupBox_Delete.TabIndex = 0;
            this.groupBox_Delete.TabStop = false;
            this.groupBox_Delete.Text = "DELETE DATE";
            this.groupBox_Delete.Enter += new System.EventHandler(this.groupBox_Delete_Enter);
            // 
            // groupBox_Edit
            // 
            this.groupBox_Edit.Controls.Add(this.numDate_ID);
            this.groupBox_Edit.Controls.Add(this.lblFill_ID);
            this.groupBox_Edit.Controls.Add(this.btnEdit_Date);
            this.groupBox_Edit.Controls.Add(this.Transact_Date_Edit);
            this.groupBox_Edit.Controls.Add(this.lblDate_Edit);
            this.groupBox_Edit.Location = new System.Drawing.Point(43, 188);
            this.groupBox_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Edit.Name = "groupBox_Edit";
            this.groupBox_Edit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Edit.Size = new System.Drawing.Size(214, 166);
            this.groupBox_Edit.TabIndex = 0;
            this.groupBox_Edit.TabStop = false;
            this.groupBox_Edit.Text = "EDIT DATE";
            // 
            // numDate_ID
            // 
            this.numDate_ID.Location = new System.Drawing.Point(61, 48);
            this.numDate_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numDate_ID.Name = "numDate_ID";
            this.numDate_ID.Size = new System.Drawing.Size(90, 20);
            this.numDate_ID.TabIndex = 2;
            // 
            // lblFill_ID
            // 
            this.lblFill_ID.AutoSize = true;
            this.lblFill_ID.Location = new System.Drawing.Point(72, 32);
            this.lblFill_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFill_ID.Name = "lblFill_ID";
            this.lblFill_ID.Size = new System.Drawing.Size(75, 13);
            this.lblFill_ID.TabIndex = 6;
            this.lblFill_ID.Text = "Enter Date ID:";
            // 
            // btnEdit_Date
            // 
            this.btnEdit_Date.Location = new System.Drawing.Point(61, 135);
            this.btnEdit_Date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit_Date.Name = "btnEdit_Date";
            this.btnEdit_Date.Size = new System.Drawing.Size(72, 19);
            this.btnEdit_Date.TabIndex = 5;
            this.btnEdit_Date.Text = "UPDATE";
            this.btnEdit_Date.UseVisualStyleBackColor = true;
            this.btnEdit_Date.Click += new System.EventHandler(this.btnEdit_Date_Click);
            // 
            // Transact_Date_Edit
            // 
            this.Transact_Date_Edit.Location = new System.Drawing.Point(34, 102);
            this.Transact_Date_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Transact_Date_Edit.Name = "Transact_Date_Edit";
            this.Transact_Date_Edit.Size = new System.Drawing.Size(151, 20);
            this.Transact_Date_Edit.TabIndex = 4;
            // 
            // lblDate_Edit
            // 
            this.lblDate_Edit.AutoSize = true;
            this.lblDate_Edit.Location = new System.Drawing.Point(93, 85);
            this.lblDate_Edit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate_Edit.Name = "lblDate_Edit";
            this.lblDate_Edit.Size = new System.Drawing.Size(33, 13);
            this.lblDate_Edit.TabIndex = 3;
            this.lblDate_Edit.Text = "Date:";
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.btnAdd_Date);
            this.groupBox_Add.Controls.Add(this.Transact_Date);
            this.groupBox_Add.Controls.Add(this.lblAddDate);
            this.groupBox_Add.Location = new System.Drawing.Point(43, 32);
            this.groupBox_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Add.Size = new System.Drawing.Size(184, 127);
            this.groupBox_Add.TabIndex = 1;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "ADD DATE";
            // 
            // btnAdd_Date
            // 
            this.btnAdd_Date.Location = new System.Drawing.Point(61, 86);
            this.btnAdd_Date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd_Date.Name = "btnAdd_Date";
            this.btnAdd_Date.Size = new System.Drawing.Size(56, 19);
            this.btnAdd_Date.TabIndex = 2;
            this.btnAdd_Date.Text = "ADD";
            this.btnAdd_Date.UseVisualStyleBackColor = true;
            this.btnAdd_Date.Click += new System.EventHandler(this.btnAdd_Date_Click);
            // 
            // Transact_Date
            // 
            this.Transact_Date.Location = new System.Drawing.Point(16, 54);
            this.Transact_Date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Transact_Date.Name = "Transact_Date";
            this.Transact_Date.Size = new System.Drawing.Size(151, 20);
            this.Transact_Date.TabIndex = 1;
            // 
            // lblAddDate
            // 
            this.lblAddDate.AutoSize = true;
            this.lblAddDate.Location = new System.Drawing.Point(75, 38);
            this.lblAddDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddDate.Name = "lblAddDate";
            this.lblAddDate.Size = new System.Drawing.Size(33, 13);
            this.lblAddDate.TabIndex = 0;
            this.lblAddDate.Text = "Date:";
            // 
            // dbGrid_Dates
            // 
            this.dbGrid_Dates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid_Dates.Location = new System.Drawing.Point(311, 32);
            this.dbGrid_Dates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dbGrid_Dates.Name = "dbGrid_Dates";
            this.dbGrid_Dates.RowTemplate.Height = 24;
            this.dbGrid_Dates.Size = new System.Drawing.Size(417, 201);
            this.dbGrid_Dates.TabIndex = 0;
            // 
            // Snack_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 423);
            this.Controls.Add(this.groupBox_SnackSale);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Snack_Sale";
            this.Text = "Snack_Sale";
            this.Load += new System.EventHandler(this.Snack_Sale_Load);
            this.groupBox_SnackSale.ResumeLayout(false);
            this.groupBox_Edit.ResumeLayout(false);
            this.groupBox_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDate_ID)).EndInit();
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_Dates)).EndInit();
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
    }
}
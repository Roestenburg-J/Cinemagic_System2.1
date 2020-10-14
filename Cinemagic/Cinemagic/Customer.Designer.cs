namespace Cinemagic
{
    partial class frmCustomer
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
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.udCustomerID = new System.Windows.Forms.NumericUpDown();
            this.gbCustomerFields = new System.Windows.Forms.GroupBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.cbSurname = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udCustomerID)).BeginInit();
            this.gbCustomerFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCustomers
            // 
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Location = new System.Drawing.Point(87, 278);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.Size = new System.Drawing.Size(655, 150);
            this.dgCustomers.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteCustomer);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.btnEditCustomer);
            this.groupBox1.Controls.Add(this.btnSearchCustomer);
            this.groupBox1.Controls.Add(this.udCustomerID);
            this.groupBox1.Location = new System.Drawing.Point(87, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(45, 99);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 41);
            this.btnDeleteCustomer.TabIndex = 4;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(45, 146);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(171, 42);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(141, 99);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(75, 41);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(45, 55);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(171, 38);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // udCustomerID
            // 
            this.udCustomerID.Location = new System.Drawing.Point(45, 29);
            this.udCustomerID.Name = "udCustomerID";
            this.udCustomerID.Size = new System.Drawing.Size(171, 20);
            this.udCustomerID.TabIndex = 0;
            // 
            // gbCustomerFields
            // 
            this.gbCustomerFields.Controls.Add(this.txtEditEmail);
            this.gbCustomerFields.Controls.Add(this.txtEditPhone);
            this.gbCustomerFields.Controls.Add(this.txtEditSurname);
            this.gbCustomerFields.Controls.Add(this.txtEditName);
            this.gbCustomerFields.Controls.Add(this.cbEmail);
            this.gbCustomerFields.Controls.Add(this.cbPhone);
            this.gbCustomerFields.Controls.Add(this.cbSurname);
            this.gbCustomerFields.Controls.Add(this.cbName);
            this.gbCustomerFields.Location = new System.Drawing.Point(431, 35);
            this.gbCustomerFields.Name = "gbCustomerFields";
            this.gbCustomerFields.Size = new System.Drawing.Size(311, 222);
            this.gbCustomerFields.TabIndex = 2;
            this.gbCustomerFields.TabStop = false;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(125, 153);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEditEmail.TabIndex = 7;
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Location = new System.Drawing.Point(125, 120);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(161, 20);
            this.txtEditPhone.TabIndex = 6;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Location = new System.Drawing.Point(125, 88);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(161, 20);
            this.txtEditSurname.TabIndex = 5;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(125, 53);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(161, 20);
            this.txtEditName.TabIndex = 4;
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(43, 155);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(55, 17);
            this.cbEmail.TabIndex = 3;
            this.cbEmail.Text = "E-Mail";
            this.cbEmail.UseVisualStyleBackColor = true;
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Location = new System.Drawing.Point(43, 122);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(57, 17);
            this.cbPhone.TabIndex = 2;
            this.cbPhone.Text = "Phone";
            this.cbPhone.UseVisualStyleBackColor = true;
            // 
            // cbSurname
            // 
            this.cbSurname.AutoSize = true;
            this.cbSurname.Location = new System.Drawing.Point(43, 90);
            this.cbSurname.Name = "cbSurname";
            this.cbSurname.Size = new System.Drawing.Size(68, 17);
            this.cbSurname.TabIndex = 1;
            this.cbSurname.Text = "Surname";
            this.cbSurname.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(43, 55);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(54, 17);
            this.cbName.TabIndex = 0;
            this.cbName.Text = "Name";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCustomerFields);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgCustomers);
            this.Name = "frmCustomer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udCustomerID)).EndInit();
            this.gbCustomerFields.ResumeLayout(false);
            this.gbCustomerFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.NumericUpDown udCustomerID;
        private System.Windows.Forms.GroupBox gbCustomerFields;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.CheckBox cbSurname;
        private System.Windows.Forms.CheckBox cbName;
    }
}
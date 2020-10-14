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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.gbCustomerFields = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbSurname = new System.Windows.Forms.CheckBox();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.gbCustomerFields.SuspendLayout();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(29, 192);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(172, 65);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(126, 124);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(75, 51);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(29, 19);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(172, 20);
            this.txtSearchCustomer.TabIndex = 2;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(29, 124);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 51);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(29, 55);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(172, 51);
            this.btnSearchCustomer.TabIndex = 4;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // gbCustomerFields
            // 
            this.gbCustomerFields.Controls.Add(this.btnUpdate);
            this.gbCustomerFields.Controls.Add(this.cbName);
            this.gbCustomerFields.Controls.Add(this.cbSurname);
            this.gbCustomerFields.Controls.Add(this.cbPhone);
            this.gbCustomerFields.Controls.Add(this.cbEmail);
            this.gbCustomerFields.Controls.Add(this.txtEditSurname);
            this.gbCustomerFields.Controls.Add(this.txtEditName);
            this.gbCustomerFields.Controls.Add(this.txtEditPhone);
            this.gbCustomerFields.Controls.Add(this.txtEditEmail);
            this.gbCustomerFields.Enabled = false;
            this.gbCustomerFields.Location = new System.Drawing.Point(372, 12);
            this.gbCustomerFields.Name = "gbCustomerFields";
            this.gbCustomerFields.Size = new System.Drawing.Size(355, 268);
            this.gbCustomerFields.TabIndex = 5;
            this.gbCustomerFields.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(37, 176);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(259, 44);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(37, 21);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(54, 17);
            this.cbName.TabIndex = 6;
            this.cbName.Text = "Name";
            this.cbName.UseVisualStyleBackColor = true;
            this.cbName.CheckedChanged += new System.EventHandler(this.cbName_CheckedChanged);
            // 
            // cbSurname
            // 
            this.cbSurname.AutoSize = true;
            this.cbSurname.Location = new System.Drawing.Point(37, 54);
            this.cbSurname.Name = "cbSurname";
            this.cbSurname.Size = new System.Drawing.Size(68, 17);
            this.cbSurname.TabIndex = 7;
            this.cbSurname.Text = "Surname";
            this.cbSurname.UseVisualStyleBackColor = true;
            this.cbSurname.CheckedChanged += new System.EventHandler(this.cbSurname_CheckedChanged);
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Location = new System.Drawing.Point(37, 93);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(57, 17);
            this.cbPhone.TabIndex = 8;
            this.cbPhone.Text = "Phone";
            this.cbPhone.UseVisualStyleBackColor = true;
            this.cbPhone.CheckedChanged += new System.EventHandler(this.cbPhone_CheckedChanged);
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(37, 131);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(55, 17);
            this.cbEmail.TabIndex = 9;
            this.cbEmail.Text = "E-Mail";
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.CheckedChanged += new System.EventHandler(this.cbEmail_CheckedChanged);
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Enabled = false;
            this.txtEditSurname.Location = new System.Drawing.Point(163, 52);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(133, 20);
            this.txtEditSurname.TabIndex = 10;
            // 
            // txtEditName
            // 
            this.txtEditName.Enabled = false;
            this.txtEditName.Location = new System.Drawing.Point(163, 19);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(133, 20);
            this.txtEditName.TabIndex = 7;
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Enabled = false;
            this.txtEditPhone.Location = new System.Drawing.Point(163, 91);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(133, 20);
            this.txtEditPhone.TabIndex = 8;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Enabled = false;
            this.txtEditEmail.Location = new System.Drawing.Point(163, 129);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(133, 20);
            this.txtEditEmail.TabIndex = 6;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.txtSearchCustomer);
            this.gbControls.Controls.Add(this.btnAddCustomer);
            this.gbControls.Controls.Add(this.btnSearchCustomer);
            this.gbControls.Controls.Add(this.btnEditCustomer);
            this.gbControls.Controls.Add(this.btnDeleteCustomer);
            this.gbControls.Location = new System.Drawing.Point(92, 12);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(225, 268);
            this.gbControls.TabIndex = 6;
            this.gbControls.TabStop = false;
            // 
            // dgCustomers
            // 
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Location = new System.Drawing.Point(92, 286);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.Size = new System.Drawing.Size(635, 142);
            this.dgCustomers.TabIndex = 7;
            this.dgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellContentClick);
            this.dgCustomers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellValueChanged);
            this.dgCustomers.SizeChanged += new System.EventHandler(this.dgCustomers_SizeChanged);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgCustomers);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbCustomerFields);
            this.Name = "frmCustomer";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.gbCustomerFields.ResumeLayout(false);
            this.gbCustomerFields.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.GroupBox gbCustomerFields;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.CheckBox cbSurname;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.DataGridView dgCustomers;
    }
}
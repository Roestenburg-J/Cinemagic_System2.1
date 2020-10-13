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
            this.gbCustomerFields.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(39, 236);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(229, 80);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(168, 153);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(100, 63);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(39, 23);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(228, 22);
            this.txtSearchCustomer.TabIndex = 2;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(39, 153);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(100, 63);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(39, 68);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(229, 63);
            this.btnSearchCustomer.TabIndex = 4;
            this.btnSearchCustomer.Text = "Search Customer ID";
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
            this.gbCustomerFields.Location = new System.Drawing.Point(496, 62);
            this.gbCustomerFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCustomerFields.Name = "gbCustomerFields";
            this.gbCustomerFields.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCustomerFields.Size = new System.Drawing.Size(473, 330);
            this.gbCustomerFields.TabIndex = 5;
            this.gbCustomerFields.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(49, 217);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(345, 54);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(49, 26);
            this.cbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(67, 21);
            this.cbName.TabIndex = 6;
            this.cbName.Text = "Name";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // cbSurname
            // 
            this.cbSurname.AutoSize = true;
            this.cbSurname.Location = new System.Drawing.Point(49, 66);
            this.cbSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSurname.Name = "cbSurname";
            this.cbSurname.Size = new System.Drawing.Size(87, 21);
            this.cbSurname.TabIndex = 7;
            this.cbSurname.Text = "Surname";
            this.cbSurname.UseVisualStyleBackColor = true;
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Location = new System.Drawing.Point(49, 114);
            this.cbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(71, 21);
            this.cbPhone.TabIndex = 8;
            this.cbPhone.Text = "Phone";
            this.cbPhone.UseVisualStyleBackColor = true;
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(49, 161);
            this.cbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(69, 21);
            this.cbEmail.TabIndex = 9;
            this.cbEmail.Text = "E-Mail";
            this.cbEmail.UseVisualStyleBackColor = true;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Location = new System.Drawing.Point(217, 64);
            this.txtEditSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(176, 22);
            this.txtEditSurname.TabIndex = 10;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(217, 23);
            this.txtEditName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(176, 22);
            this.txtEditName.TabIndex = 7;
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Location = new System.Drawing.Point(217, 112);
            this.txtEditPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(176, 22);
            this.txtEditPhone.TabIndex = 8;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(217, 159);
            this.txtEditEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(176, 22);
            this.txtEditEmail.TabIndex = 6;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.txtSearchCustomer);
            this.gbControls.Controls.Add(this.btnAddCustomer);
            this.gbControls.Controls.Add(this.btnSearchCustomer);
            this.gbControls.Controls.Add(this.btnEditCustomer);
            this.gbControls.Controls.Add(this.btnDeleteCustomer);
            this.gbControls.Location = new System.Drawing.Point(123, 62);
            this.gbControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControls.Name = "gbControls";
            this.gbControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControls.Size = new System.Drawing.Size(300, 330);
            this.gbControls.TabIndex = 6;
            this.gbControls.TabStop = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbCustomerFields);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCustomer";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.gbCustomerFields.ResumeLayout(false);
            this.gbCustomerFields.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
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
    }
}
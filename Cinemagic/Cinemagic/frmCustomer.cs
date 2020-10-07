using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cinemagic
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }


        public static DialogResult AddCustomer(string title, string promptText)
        {
            Form form = new Form();

            Label lblID = new Label();
            Label lblName = new Label();
            Label lblSurname = new Label();
            Label lblEmail = new Label();
            Label lblPhone = new Label(); 

            TextBox txtName = new TextBox();
            TextBox txtSurname = new TextBox();
            TextBox txtID = new TextBox();
            TextBox txtEmail = new TextBox();
            TextBox txtPhone = new TextBox();


            Button btnAdd = new Button();
            Button btnCancel = new Button();
            btnAdd.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            lblID.SetBounds(10,10,100,13);
            lblName.SetBounds(40, 10, 100, 13);
            lblSurname.SetBounds(70, 10, 100, 13);
            lblPhone.SetBounds(100, 10, 100, 13);
            lblEmail.SetBounds(130, 10, 100, 13);

            txtID.SetBounds(20, 10, 100, 13);
            txtID.SetBounds(50, 10, 100, 13);
            txtID.SetBounds(80, 10, 100, 13);
            txtID.SetBounds(110, 10, 100, 13);
            txtID.SetBounds(140, 10, 100, 13);

            lblID.AutoSize = true;
            lblName.AutoSize = true;
            lblSurname.AutoSize = true;
            lblPhone.AutoSize = true;
            lblEmail.AutoSize = true;

            txtID.Anchor = txtID.Anchor | AnchorStyles.Right;
            txtName.Anchor = txtName.Anchor | AnchorStyles.Right;
            txtSurname.Anchor = txtSurname.Anchor | AnchorStyles.Right;
            txtPhone.Anchor = txtPhone.Anchor | AnchorStyles.Right;
            txtEmail.Anchor = txtEmail.Anchor | AnchorStyles.Right;

            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(300, 107);
            form.Controls.AddRange(new Control[] { lblID, lblName, lblSurname, lblPhone, lblEmail, txtID, txtName, txtSurname, txtID, txtSurname, txtEmail,btnAdd, btnCancel });
            form.ClientSize = new Size(Math.Max(300, lblID.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnAdd;
            form.CancelButton = btnCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer("customer", "add");
           
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}

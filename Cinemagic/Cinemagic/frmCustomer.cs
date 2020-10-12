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
        private string id;
        private string name;
        private string surname;
        private string phone;
        private string email;


        public frmCustomer()
        {
            InitializeComponent();
        }


        public DialogResult AddCustomer()
        {
            Form form = new Form();        

            Label lblName = new Label();
            Label lblSurname = new Label();
            Label lblEmail = new Label();
            Label lblPhone = new Label();

           
            lblName.Text = "Name:";
            lblSurname.Text = "Surname:";
            lblPhone.Text = "Phone:";
            lblEmail.Text = "E-Mail:";

            TextBox txtName = new TextBox();
            TextBox txtSurname = new TextBox();
         
            TextBox txtEmail = new TextBox();
            TextBox txtPhone = new TextBox();

            Button btnAdd = new Button();
            Button btnCancel = new Button();
            btnAdd.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            lblName.Location = new Point(60, 75);
            lblSurname.Location = new Point(60, 115);
            lblPhone.Location = new Point(60, 155);
            lblEmail.Location = new Point(60, 195);

            lblName.Size = new Size(80, 20);
            lblSurname.Size = new Size(80, 20);
            lblPhone.Size = new Size(80, 20);
            lblEmail.Size = new Size(80, 20);
            
            txtName.Location = new Point(150, 75);
            txtSurname.Location = new Point(150, 115);
            txtPhone.Location = new Point(150, 155);
            txtEmail.Location = new Point(150, 195);

            txtName.Size = new Size(140, 20);
            txtSurname.Size = new Size(140, 20);
            txtPhone.Size = new Size(140, 20);
            txtEmail.Size = new Size(140, 20);

            btnAdd.Size = new Size(80,40);
            btnCancel.Size = new Size(80, 40);
            btnAdd.Location = new Point(60, 300);
            btnCancel.Location = new Point(200, 300);
            btnAdd.Text = "Add customer";
            btnCancel.Text = "Cancel";

            form.Text = "Add Customer";
            form.ClientSize = new Size(500, 500);
            form.Controls.AddRange(new Control[] { lblName, lblSurname, lblPhone, lblEmail, txtName, txtSurname, txtPhone, txtEmail,btnAdd, btnCancel });

            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnAdd;
            form.CancelButton = btnCancel;

            DialogResult dialogResult = form.ShowDialog();
            
            name = txtName.Text;
            surname = txtSurname.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;

            if (dialogResult == DialogResult.Cancel)
            {
                form.Close();
            }
            else
            {              
                try
                {
                    Convert.ToInt32(txtPhone.Text);
                }
                catch
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        form.Close();
                    }
                    MessageBox.Show("Phone number can only contain numbers");
                    txtName.Enabled = false;
                    txtSurname.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPhone.Enabled = true;
                    txtPhone.Text = "";
                    form.ShowDialog();
                }
                if (txtPhone.Text.Length != 10)
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        form.Close();
                    }
                    else
                    {
                        MessageBox.Show("Phone number should be 10 digits", "Invalid Phone Number");                       
                        txtName.Enabled = false;
                        txtSurname.Enabled = false;
                        txtEmail.Enabled = false;
                        txtPhone.Enabled = true;
                        txtPhone.Text = "";
                        form.ShowDialog();
                    }

                }
            }
            if (dialogResult == DialogResult.Cancel)
            {
                form.Close();
            }
            

            return dialogResult;
        }

       

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer();
           
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}

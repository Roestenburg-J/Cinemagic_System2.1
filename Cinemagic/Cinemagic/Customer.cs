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
using System.Data.SqlClient;
using RandomProj;

namespace Cinemagic
{

    public partial class frmCustomer : Form
    {
        private string id;
        private string name;
        private string surname;
        private string phone;
        private string email;

        private string connection;
        private SqlCommand command;
        private DataTable dt = new DataTable();
        private SqlDataReader dr;


        public frmCustomer()
        {
            InitializeComponent();
        }


        public DialogResult AddCustomerFrom()
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

            btnAdd.Size = new Size(80, 40);
            btnCancel.Size = new Size(80, 40);
            btnAdd.Location = new Point(60, 300);
            btnCancel.Location = new Point(210, 300);
            btnAdd.Text = "Add customer";
            btnCancel.Text = "Cancel";

            form.Text = "Add Customer";
            form.ClientSize = new Size(380, 380);
            form.Controls.AddRange(new Control[] { lblName, lblSurname, lblPhone, lblEmail, txtName, txtSurname, txtPhone, txtEmail, btnAdd, btnCancel });


            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = btnAdd;
            form.CancelButton = btnCancel;

            DialogResult dialogResult = form.ShowDialog();

            name = txtName.Text;
            surname = txtSurname.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;


            if (dialogResult == DialogResult.OK)
            {
                if (txtName.Text.Length == 0)
                {
                   
                        MessageBox.Show("Name cannot be empty", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);                       
                        form.ShowDialog();
                  

                }
                if (txtSurname.Text.Length == 0)
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        form.Close();
                    }
                    else
                    {
                        MessageBox.Show("Surname cannot be empty", "Invalid Surame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        form.ShowDialog();
                    }

                }
                if (txtPhone.Text.Length != 10)
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        form.Close();
                    }
                    else
                    {
                        MessageBox.Show("Phone number should be 10 digits", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        form.ShowDialog();
                    }

                }
                if (txtEmail.Text.Length == 0)
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        form.Close();
                    }
                    else
                    {
                        MessageBox.Show("E-mail cannot be empty", "Invalid E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        form.ShowDialog();
                    }

                }

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
                    form.ShowDialog();
                }
                return dialogResult;

            }
           
            else
            {
                return dialogResult; 
            }
             
        }
  

    

    private void AddCustomer(string name, string surname, string phone, string email)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string insert_Customer = "INSERT INTO CUSTOMER (Customer_Name,Customer_Surname,Customer_Phone,Customer_Email) values(@name,@surname,@phone,@email)";

            cinema.com = new SqlCommand(insert_Customer, cinema.conn);
            cinema.com.Parameters.AddWithValue("@name", name);
            cinema.com.Parameters.AddWithValue("@surname", surname);
            cinema.com.Parameters.AddWithValue("@phone", phone);
            cinema.com.Parameters.AddWithValue("@email", email);

            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
        }

        private Boolean TestValidPhone(string phone)
        {
            Boolean valid = true;
            try
            {
                Convert.ToInt32(phone);
            }
            catch
            {
                valid = false;
            }
            if (valid == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void DisplayCustomers()
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Customers = "SELECT * FROM CUSTOMER";
            cinema.com = new SqlCommand(select_Customers, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_Customers, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Customers");
            dgCustomers.DataSource = cinema.ds;
            dgCustomers.DataMember = "Customers";
            cinema.conn.Close();
        }

        private void SearchCustomer(string id)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Customers = "SELECT * FROM CUSTOMER WHERE Customer_ID = '" + id + "'";
            cinema.com = new SqlCommand(select_Customers, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_Customers, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Customers");
            dgCustomers.DataSource = cinema.ds;
            dgCustomers.DataMember = "Customers";
            cinema.conn.Close();
        }

        private void EditName(string id, string newName)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_Name = "UPDATE CUSTOMER SET Customer_Name=@name WHERE Customer_ID = '"+id+"'";
            cinema.com = new SqlCommand(update_Name, cinema.conn);
            cinema.com.Parameters.AddWithValue("@Name", newName);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
          
        }

        private void EditSurname(string id, string newSurname)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_Surname = "UPDATE CUSTOMER SET Customer_Surname=@Surname WHERE Customer_ID = '" + id + "'";
            cinema.com = new SqlCommand(update_Surname, cinema.conn);
            cinema.com.Parameters.AddWithValue("@Surname", newSurname);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
            
        }

        private void EditPhone(string id, string newPhone)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_Phone = "UPDATE CUSTOMER SET Customer_Phone=@Phone WHERE Customer_ID = '" + id + "'";
            cinema.com = new SqlCommand(update_Phone, cinema.conn);
            cinema.com.Parameters.AddWithValue("@Phone", newPhone);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
          
        }

        private void EditEmail(string id, string newEmail)
        {
            
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_Email = "UPDATE CUSTOMER SET Customer_Email=@Email WHERE Customer_ID = '" + id + "'";
            cinema.com = new SqlCommand(update_Email, cinema.conn);
            cinema.com.Parameters.AddWithValue("@Email", newEmail);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
           
        }

        private void DeleteCustomer(string id)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string delete_Customer = "DELETE CUSTOMER WHERE Customer_ID = '" + id + "'";
            cinema.com = new SqlCommand(delete_Customer, cinema.conn);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Boolean TestValidSearch(string id)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Customers = "SELECT * FROM CUSTOMER WHERE Customer_ID = '" + id + "'";
            cinema.com = new SqlCommand(select_Customers, cinema.conn);
            cinema.adap = new SqlDataAdapter();

            SqlDataReader dr = cinema.com.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
            }
            dr.Close();
            cinema.conn.Close();

            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (AddCustomerFrom() == DialogResult.OK)
            {
                AddCustomer(name, surname, phone, email);
            }
            
            


        }

        private void Customer_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void btnSearchCustomer_Click_1(object sender, EventArgs e)
        {
            string customerID = "";
            customerID = udCustomerID.Text;
            id = udCustomerID.Text;
            try
            {
                SearchCustomer(customerID);
            }
            catch
            {

            }
            if (TestValidSearch(customerID) == false)
            {
                MessageBox.Show("Customer ID not found", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEditCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = false;
            }
            else
            {
                btnEditCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;
            }

        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCustomers_SizeChanged(object sender, EventArgs e)
        {

        }

        private void dgCustomers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            gbCustomerFields.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Boolean sucsess = true;
            if (cbName.Checked == true)
            {
                if (txtEditName.Text == "")
                {
                    MessageBox.Show("Name cannot be empty!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sucsess = false;
                }
                else
                {
                    try
                    {
                        EditName(udCustomerID.Text, txtEditName.Text);
                    }
                    catch
                    {
                        sucsess = false;
                    }
                }

            }
            if (cbSurname.Checked == true)
            {
                if (txtEditName.Text == "")
                {
                    MessageBox.Show("Surname cannot be empty!", "Invalid Surname", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sucsess = false;
                }
                else
                {
                    try
                    {
                        EditSurname(udCustomerID.Text, txtEditSurname.Text);
                    }
                    catch
                    {
                        sucsess = false;
                    }
                }
            }
            if (cbPhone.Checked == true)
            {
                if (txtEditPhone.Text.Length != 10)
                {
                    MessageBox.Show("Phone number entered should be 10 characters!", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sucsess = false;
                }
                else
                {
                    try
                    {
                        EditPhone(udCustomerID.Text, txtEditPhone.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Phone entered is invalid!", "Invalid Phone",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sucsess = false;
                    }
                }
            }
            if (cbEmail.Checked == true)
            {
                try
                {
                    EditEmail(udCustomerID.Text, txtEditEmail.Text);
                }
                catch
                {
                    MessageBox.Show("E-Mail Entered is invalid!", "Invalid Email",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sucsess = false;
                }
            }
            if (sucsess == true)
            {
                MessageBox.Show("Record Updated Successfully", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbCustomerFields.Enabled = false;

                txtEditName.Text = "";
                txtEditSurname.Text = "";
                txtEditPhone.Text = "";
                txtEditSurname.Text = "";

                SearchCustomer(id);
            }
        }

        private void cbName_CheckedChanged(object sender, EventArgs e)
        {
            if(cbName.Checked == true)
            {
                txtEditName.Enabled = true;
            }
            else
            {
                txtEditName.Enabled = false;
                txtEditName.Text = "";
            }
        }

        private void cbSurname_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbSurname.Checked == true)
            {
                txtEditSurname.Enabled = true;
            }
            else
            {
                txtEditSurname.Enabled = false;
                txtEditSurname.Text = "";
            }
        }

        private void cbPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPhone.Checked == true)
            {
                txtEditPhone.Enabled = true;
            }
            else
            {
                txtEditPhone.Enabled = false;
                txtEditPhone.Text = "";
            }
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmail.Checked == true)
            {
                txtEditEmail.Enabled = true;
            }
            else
            {
                txtEditEmail.Enabled = false;
                txtEditEmail.Text = "";
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string customerID = "";
            customerID = udCustomerID.Text;
            if (MessageBox.Show("Are your sure you want to delete customer "+ udCustomerID.Text ,"Delete Customer", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DeleteCustomer(customerID);
                DisplayCustomers();
                btnDeleteCustomer.Enabled = false;
            }

            
            
        }


        private void frmCustomer_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void gbCustomerFields_Enter(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
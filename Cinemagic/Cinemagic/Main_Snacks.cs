using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RandomProj;

namespace RandomProj
{
    public partial class Main_Snacks : Form
    {
        private string connection;
        private SqlCommand command;
        private DataTable dt = new DataTable();

        public Main_Snacks()
        {
            InitializeComponent();
        }

        private void btnSnack_Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snack_Sale snack_Sale = new Snack_Sale();
            snack_Sale.ShowDialog();
        }

        private void Main_Snacks_Load(object sender, EventArgs e)
        {
            spinID.Maximum = Int32.MaxValue;
            spinQuantity.Maximum = 300; 
            DisplayDates();
            DisplaySnacks();
            DisplayTransact_Details();
        }

        private void DisplaySnacks()
        {
            dbGridSnacks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_snacks = "SELECT * FROM SNACK";
            cinema.com = new SqlCommand(select_snacks, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_snacks, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Snacks");
            dbGridSnacks.DataSource = cinema.ds;
            dbGridSnacks.DataMember = "Snacks";
            cinema.conn.Close();
        }

        private void DisplayTransact_Details()
        {
            dbTransaction_Details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_details = "SELECT * FROM SNACK_TRANSACTION";
            cinema.com = new SqlCommand(select_details, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_details, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Transaction");
            dbTransaction_Details.DataSource = cinema.ds;
            dbTransaction_Details.DataMember = "Transaction";
            cinema.conn.Close();
        }

        private void DisplayDates()
        {
            dbGridTransact_Dates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_dates = "SELECT * FROM SNACK_SALE";
            cinema.com = new SqlCommand(select_dates, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_dates, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Dates");
            dbGridTransact_Dates.DataSource = cinema.ds;
            dbGridTransact_Dates.DataMember = "Dates";
            cinema.conn.Close();
        }

        private void AddSnacks()
        {
            Main cinema = new Main();
            connection = cinema.constr;
            try
            {
                string insert_snacks = @"INSERT INTO SNACK VALUES(@Snack_Name,@Snack_Description,@Snack_Quantity,@Snack_UnitCost,@Snack_Price)";
                cinema.conn = new SqlConnection(connection);
                cinema.conn.Open();
                cinema.com = new SqlCommand(insert_snacks, cinema.conn);
                cinema.com.Parameters.AddWithValue("@Snack_Name", txtItem.Text);
                cinema.com.Parameters.AddWithValue("@Snack_Description", txtDescription.Text);
                cinema.com.Parameters.AddWithValue("@Snack_Quantity", spinQuantity.Value);
                cinema.com.Parameters.AddWithValue("@Snack_UnitCost", decimal.Parse(txtUnit_Cost.Text));
                cinema.com.Parameters.AddWithValue("@Snack_Price", decimal.Parse(txtPrice.Text));
                cinema.com.ExecuteNonQuery();
                MessageBox.Show("Snack have been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cinema.conn.Close();
                DisplaySnacks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Failed to add snack... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSnacks()
        {
            Main cinema = new Main();
            cinema.conn = new SqlConnection(connection);
            string select_snacks = "SELECT * FROM SNACK WHERE Snack_ID = " + spinFill_SnackID.Value.ToString() + ";";
            string update_snacks = $"UPDATE SNACK SET Snack_Name = '{txtItem.Text}', Snack_Description = '{txtDescription.Text}', Snack_Quantity = {spinQuantity.Value.ToString()}," +
            $"Snack_UnitCost = CAST(REPLACE('{txtUnit_Cost.Text}', ',', '.') AS DECIMAL(10, 2)), " +
            $"Snack_Price = CAST(REPLACE('{txtPrice.Text}', ',', '.') AS DECIMAL(10, 2)) WHERE Snack_ID = {spinFill_SnackID.Value.ToString()}";
            cinema.com = new SqlCommand(update_snacks, cinema.conn);
            command = new SqlCommand(select_snacks, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.adap.SelectCommand = command;
            cinema.adap.Fill(dt);
         
            try
            {
                cinema.conn.Open();
                if (dt.Rows.Count > 0)
                {
                    cinema.com.ExecuteNonQuery();
                    cinema.conn.Close();
                    DisplaySnacks();
                    MessageBox.Show("Snack updates successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The selected Snack_ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " Failed to update snack...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSnacks()
        {
            Main cinema = new Main();
            string select_snacks = "SELECT * FROM SNACK WHERE Snack_Id = " + spinFill_SnackID.Value.ToString();
            try
            {
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_snacks, cinema.conn);
                SqlDataReader dr = cinema.com.ExecuteReader();
                if (dr.Read())
                {
                    txtItem.Text = dr.GetValue(1).ToString();
                    txtDescription.Text = dr.GetValue(2).ToString();
                    spinQuantity.Value = (int)dr.GetValue(3);
                    txtUnit_Cost.Text = dr.GetValue(4).ToString();
                    txtPrice.Text = dr.GetValue(5).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Snack_ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cinema.conn.Close();
            }
            catch (Exception err)

            {
                MessageBox.Show(err.Message+" Failed to fill textboxes with data from selected record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Snacks_Click(object sender, EventArgs e)
        {
            AddSnacks();
        }

        private void txtUnit_Cost_Validating(object sender, CancelEventArgs e)
        {
            decimal unit_cost;
            if (String.IsNullOrEmpty(txtUnit_Cost.Text))
            {
                MessageBox.Show("Please enter a value!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!decimal.TryParse(txtUnit_Cost.Text,out unit_cost))
                {
                    MessageBox.Show("Must enter a decimal value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFill_Snacks_Click(object sender, EventArgs e)
        {
            FillSnacks();
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            decimal price;
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please enter a value!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!decimal.TryParse(txtPrice.Text, out price))
                {
                    MessageBox.Show("Must enter a decimal value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Snacks_Click(object sender, EventArgs e)
        {
            UpdateSnacks();
        }
    }
}

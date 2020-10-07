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

namespace RandomProj
{
    public partial class Snack_Sale : Form
    {
        private string connection;
        private SqlCommand command;
        private DataTable dt = new DataTable();

        public Snack_Sale()
        {
            InitializeComponent();
        }

        private void DisplayDates()
        {
            dbGrid_Dates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select = "SELECT * FROM SNACK_SALE";
            cinema.com = new SqlCommand(select, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Snack_Sale");
            dbGrid_Dates.DataSource = cinema.ds;
            dbGrid_Dates.DataMember = "Snack_Sale";
            cinema.conn.Close();
        }

        private void AddDates()
        {
            Main cinema = new Main();
            connection = cinema.constr;
            try
            {
                string insert_query = @"INSERT INTO SNACK_SALE VALUES(@Snack_SaleDate)";
                cinema.conn = new SqlConnection(connection);
                cinema.conn.Open();
                cinema.com = new SqlCommand(insert_query, cinema.conn);
                cinema.com.Parameters.AddWithValue("@Snack_SaleDate", Transact_Date.Value.ToString("yyyy/MM/dd"));
                cinema.com.ExecuteNonQuery();
                MessageBox.Show("Transaction date added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cinema.conn.Close();
                DisplayDates();
            }
            catch
            {
                MessageBox.Show("Failed to insert record... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDates()
        {
            Main cinema = new Main();
            cinema.conn = new SqlConnection(connection);
            string select_date = "SELECT * FROM SNACK_SALE WHERE Snack_Sale_ID = " + numDate_ID.Value.ToString() + ";";
            string update_query = @"UPDATE SNACK_SALE SET Snack_SaleDate = '" + Transact_Date_Edit.Value.ToString("yyyy/MM/dd") + "' WHERE Snack_Sale_ID = "+ 
            numDate_ID.Value.ToString();
            cinema.com = new SqlCommand(update_query, cinema.conn);
            command = new SqlCommand(select_date, cinema.conn);
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
                    DisplayDates();
                    MessageBox.Show("Transaction date updated successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction Date ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + ". Failed to update record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            numDate_ID.Value = 0;
        }

        private void Snack_Sale_Load(object sender, EventArgs e)
        {
            DisplayDates();
        }

        private void btnAdd_Date_Click(object sender, EventArgs e)
        {
            AddDates();
        }
      
        private void btnEdit_Date_Click(object sender, EventArgs e)
        {
            UpdateDates();
        }
    }
}

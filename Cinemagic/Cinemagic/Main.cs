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
    public partial class Main : Form
    {
        // Re-use these public variables through OOP in your other Forms 
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CinemagicDB.mdf;Integrated Security=True;";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Use this code to test whether you can connect to the database
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                MessageBox.Show("Connection Successfull");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Could not connect to db");
            }
        }
    }
}

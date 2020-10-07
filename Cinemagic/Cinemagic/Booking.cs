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

namespace Cinemagic
{
    public partial class BookingID : Form
    {    
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derick\Desktop\GIT\Cinemagic_System\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
             

        public BookingID()
        {
            InitializeComponent();
        }

        private void BookingID_Load(object sender, EventArgs e)
        {
 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derick\Desktop\GIT\Cinemagic_System\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True");


            con.Open();


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select* FROM BOOKING";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            
        }
    }
}

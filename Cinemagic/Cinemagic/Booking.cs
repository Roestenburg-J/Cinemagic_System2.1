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
using System.Xml;

namespace Cinemagic
{
    public partial class Booking : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Derick\Desktop\GIT\New CIN\Cinemagic_System2.1\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        private void Delete()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Derick\Desktop\GIT\New CIN\Cinemagic_System2.1\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True");

            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM BOOKING  WHERE Booking_ID ='" + txtbooking.Text + "'";
            command.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data has been deleted off the database");




        }

        private void Insert()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Derick\Desktop\GIT\New CIN\Cinemagic_System2.1\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("insert into BOOKING values('" + txtcost.Text + "','" + txtseats.Text + "','" + dtptickets + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

        }

        private void Display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Derick\Desktop\GIT\New CIN\Cinemagic_System2.1\Cinemagic\Cinemagic\CinemagicDB.mdf;Integrated Security=True");
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

        private void Edit()
        {
            dataGridView1.CurrentRow.Cells[3].Value = txtcost.Text;
            dataGridView1.CurrentRow.Cells[4].Value = txtseats.Text;
            dataGridView1.CurrentRow.Cells[5].Value = dtptickets;
        }






        public Booking()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display();


        }


        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnbooking_Click(object sender, EventArgs e)
        {

            if (txtbooking.Text != "")
            {
                Delete();
            }

            else
            {
                MessageBox.Show("Please enter a ID that is valid");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (txtcost.Text != "" && txtseats.Text != "")
            {
                Insert();
            }

            else
            {
                MessageBox.Show("An error has accured, please try again.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtcost.Text != "" && txtseats.Text != "")
            {
                Update();
            }

            else
            {
                MessageBox.Show("An error has accured, please try again.");
            }
        }

        private void dtptickets_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


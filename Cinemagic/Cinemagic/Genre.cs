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

namespace Cinemagic
{
    public partial class Genre : Form
    {
        private string connection;
        private DataTable dt = new DataTable();
        int count = 0;
        

        public Genre()
        {
            InitializeComponent();
        }

        private void AddGenre()
        {
            try

            {
                Main cinema = new Main();
                connection = cinema.constr;
                cinema.conn = new SqlConnection(connection);
                cinema.conn.Open();
                string insert_Genre = "INSERT INTO GENRE VALUES(@Genre_Description)";
                cinema.com = new SqlCommand(insert_Genre, cinema.conn);
                cinema.com.Parameters.AddWithValue("@Genre_Description", textBox2.Text);
                cinema.com.ExecuteNonQuery();
                MessageBox.Show("Genre have been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cinema.conn.Close();
                DisplayGenre();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Failed to add genre... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateGenre()
        {

            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_Genre = " UPDATE GENRE SET GENRE_DESCRIPTION = '" + textBox2.Text + "' WHERE GENRE_ID= " + textBox3.Text + ""; 
            cinema.com = new SqlCommand(update_Genre, cinema.conn);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
            DisplayGenre();
            MessageBox.Show("Record Updated Successfully");

        }
        private void DisplayGenre()
        {
            Main cinema = new Main();
            connection = cinema.constr; 
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Genre = "SELECT * FROM GENRE";
            cinema.com = new SqlCommand(select_Genre, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_Genre, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Genre");
            GenreGridView.DataSource = cinema.ds;
            GenreGridView.DataMember = "Genre";
            cinema.conn.Close();
        }

        private void DeleteGenre()
        {

            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string delete_Genre = "DELETE FROM GENRE WHERE GENRE_ID = '" + textBox1.Text + "'";
            cinema.com = new SqlCommand(delete_Genre, cinema.conn);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
            DisplayGenre();
            MessageBox.Show("Record Deleted Successfully");

        }


        private void Genre_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteGenre();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayGenre();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddGenre();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGenre();
        }

        private void textBox2_FontChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Genre = "SELECT * FROM GENRE WHERE GENRE_ID='"+txtSearch.Text+"'";
            cinema.com = new SqlCommand(select_Genre, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_Genre, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Genre");
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            GenreGridView.DataSource = cinema.ds;
            GenreGridView.DataMember = "Genre";
            cinema.conn.Close();

            if (count!=0)
            {
                MessageBox.Show("Record was found!"); 
            }

        }
    }
} 
 
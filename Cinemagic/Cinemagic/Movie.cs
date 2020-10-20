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
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private string id;
        private string name;
        private string genre;
        private string duration;
        private string ageRes;
        private string relDate;
        private string withdrawDate;

        private string connection;
        private SqlCommand command;
        private DataTable dt = new DataTable();

        private void DisplayMovies()
        {
            moviesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select = "SELECT * FROM MOVIE";
            cinema.com = new SqlCommand(select,cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select, cinema.conn);
            cinema.adap.Fill(cinema.ds, "MOVIE");
            moviesGrid.DataSource = cinema.ds;
            moviesGrid.DataMember = "MOVIE";
            cinema.conn.Close();
        }

        private bool CheckEmptyAddInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(aNameBox.Text) || String.IsNullOrEmpty(aGenreBox.Text) || String.IsNullOrEmpty(aDurationBox.Text) || String.IsNullOrEmpty(aAgeBox.Text) || String.IsNullOrEmpty(aReleaseBox.Text) || String.IsNullOrEmpty(aWithdrawBox.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        private void AddMovie(string name, string genre, string duration, string ageRes, string relDate, string withdrawDate)
        {
            try
            {
                if (CheckEmptyAddInputs())
                {
                    MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Main cinema = new Main();
                    connection = cinema.constr;
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    string insert_Movie = "INSERT INTO MOVIE (Movie_Name,Genre_ID,Movie_Duration,Age_Restriction,Release_Date, Withdrawal_Date) values(@name,@genre,@duration,@ageRes,@relDate,@withdrawDate)";

                    cinema.com = new SqlCommand(insert_Movie, cinema.conn);
                    cinema.com.Parameters.AddWithValue("@name", name);
                    cinema.com.Parameters.AddWithValue("@genre", genre);
                    cinema.com.Parameters.AddWithValue("@duration", duration);
                    cinema.com.Parameters.AddWithValue("@ageRes", ageRes);
                    cinema.com.Parameters.AddWithValue("@relDate", relDate);
                    cinema.com.Parameters.AddWithValue("@withdrawDate", withdrawDate);

                    cinema.com.ExecuteNonQuery();
                    cinema.conn.Close();

                    MessageBox.Show("Movie Added Successfully!");

                    aNameBox.Text = "";
                    aGenreBox.Text = "";
                    aDurationBox.Text = "";
                    aAgeBox.Text = "";
                    aReleaseBox.Text = "";
                    aWithdrawBox.Text = "";
                }
            }

            catch
            {
                MessageBox.Show("Ensure dates are in the format yyyy/mm/dd , Times are in the format 00:00:00 and Genre is a numeric value.");
            }

        }

        private bool CheckEmptyDeleteInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(dIDBox.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }


        private void DeleteMovie(string id)
        {
            try
            {
                if (CheckEmptyDeleteInputs())
                {
                    MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Main cinema = new Main();
                    connection = cinema.constr;
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    string delete_Movie = "DELETE MOVIE WHERE Movie_ID = '" + id + "'";
                    cinema.com = new SqlCommand(delete_Movie, cinema.conn);
                    cinema.com.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Movie Deleted Successfully");
                }
            }

            catch
            {
                MessageBox.Show("Ensure that you have entered valid values.");
            }
        }

        private void EditName(string newName)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_name = "UPDATE MOVIE SET Movie_Name=@name WHERE Movie_ID = '" + id+ "'";
            cinema.com = new SqlCommand(update_name, cinema.conn);
            cinema.com.Parameters.AddWithValue("@name", newName);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();

            uNameBox.Text = "";
            nameCB.Checked = false;
        }

        private void EditGenre(string newGenre)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_genre = "UPDATE MOVIE SET Genre_ID=@genre WHERE Movie_ID = '" + id + "'";
            cinema.com = new SqlCommand(update_genre, cinema.conn);
            cinema.com.Parameters.AddWithValue("@genre", newGenre);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();

            uGenreBox.Text = "";
            genreCB.Checked = false;
        }

        private void EditDuration(string newDuration)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_duration = "UPDATE MOVIE SET Movie_Duration=@duration WHERE Movie_ID = '" + id + "'";
            cinema.com = new SqlCommand(update_duration, cinema.conn);
            cinema.com.Parameters.AddWithValue("@duration", newDuration);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();

            uDurationBox.Text = "";
            durationCB.Checked = false;
        }

        private void EditAge(string newAgeRes)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_age = "UPDATE MOVIE SET Age_Restriction=@ageRes WHERE Movie_ID = '" + id + "'";
            cinema.com = new SqlCommand(update_age, cinema.conn);
            cinema.com.Parameters.AddWithValue("@ageRes", newAgeRes);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();

            uAgeBox.Text = "";
            ageCB.Checked = false;
        }

        private void EditRelease(string newrelDate)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_date = "UPDATE MOVIE SET Release_Date=@relDate WHERE Movie_ID = '" + id + "'";
            cinema.com = new SqlCommand(update_date, cinema.conn);
            cinema.com.Parameters.AddWithValue("@relDate", newrelDate);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();

            uReleaseBox.Text = "";
            releaseCB.Checked = false;
        }

        private void EditWithdraw(string newWithdrawDate)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string update_date = "UPDATE MOVIE SET Withdrawal_Date=@withdrawDate WHERE Movie_ID = '" + id + "'";
            cinema.com = new SqlCommand(update_date, cinema.conn);
            cinema.com.Parameters.AddWithValue("@withdrawDate", newWithdrawDate);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();

            uWithdrawBox.Text = "";
            withdrawCB.Checked = false;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            name = aNameBox.Text;
            genre = aGenreBox.Text;
            duration = aDurationBox.Text;
            ageRes = aAgeBox.Text;
            relDate = aReleaseBox.Text;
            withdrawDate = aWithdrawBox.Text;

            AddMovie(name,genre,duration,ageRes,relDate,withdrawDate);
            DisplayMovies();
    }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private Boolean TestValidID(string id)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Customers = "SELECT * FROM MOVIE WHERE Movie_ID = '" + id + "'";
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


        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean updated = false;
                id = uIDBox.Text;

                if (TestValidID(id) == false)
                {
                    MessageBox.Show("ID Entered is invalid! ", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    updated = false;
                }

                if (nameCB.Checked == true)
                {

                    try
                    {
                        EditName(uNameBox.Text);
                        updated = true;
                    }
                    catch
                    {
                        MessageBox.Show("Movie Name Entered is invalid!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        updated = false; ;
                    }

                }

                if (genreCB.Checked == true)
                {

                    try
                    {
                        EditGenre(uGenreBox.Text);
                        updated = true;
                    }
                    catch
                    {
                        MessageBox.Show("Genre Entered is invalid!", "Invalid Genre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        updated = false;
                    }

                }

                if (durationCB.Checked == true)
                {

                    try
                    {
                        EditDuration(uDurationBox.Text);
                        updated = true;
                    }
                    catch
                    {
                        MessageBox.Show("Duration Entered is invalid! Must be in the form 00:00:00", "Invalid Duration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        updated = false;
                    }

                }

                if (ageCB.Checked == true)
                {

                    try
                    {
                        EditAge(uAgeBox.Text);
                        updated = true;
                    }
                    catch
                    {
                        MessageBox.Show("Age Restriction Entered is invalid!", "Invalid Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        updated = false;
                    }

                }

                if (releaseCB.Checked == true)
                {

                    try
                    {
                        EditRelease(uReleaseBox.Text);
                        updated = true;
                    }
                    catch
                    {
                        MessageBox.Show("Release Date Entered is invalid! Must be in the form: yyyy/mm/dd.", "Invalid Release Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        updated = false;
                    }

                }

                if (withdrawCB.Checked == true)
                {

                    try
                    {
                        EditWithdraw(uWithdrawBox.Text);
                        updated = true;
                    }
                    catch
                    {
                        MessageBox.Show("Withdrawal Date Entered is invalid! Must be in the form: yyyy/mm/dd.", "Invalid Withdrawal Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        updated = false;
                    }

                }

                if (updated == true)
                {
                    MessageBox.Show("Movie updated successfully.");
                }
                DisplayMovies();
            }

            catch
            {
                MessageBox.Show("Ensure that you have entered valid values.");
            }

        }


        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                id = dIDBox.Text;
                if (TestValidID(id) == false)
                {
                    MessageBox.Show("ID Entered is invalid! ", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else if (MessageBox.Show("Are your sure you want to delete movie " + dIDBox.Text, "Delete Movie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DeleteMovie(id);
                    DisplayMovies();
                }
            }

            catch
            {
                MessageBox.Show("Movie ID Entered is invalid!", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dIDBox.Text = "";
        }

        private void Movie_Load(object sender, EventArgs e)
        {
            DisplayMovies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void aDurationBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

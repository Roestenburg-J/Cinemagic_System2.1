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
    public partial class Main : Form
    {
        // Re-use these public variables through OOP in your other Forms 
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CinemagicDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;";

        public Main()
        {
            InitializeComponent();
        }

        private void TotalSnacks()
        {
            string all_snacks = "SELECT MAX(SNACK_ID) FROM SNACK";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_snacks, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtVSnack.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void MostExpensive()
        {
            string all_snacks = "SELECT Snack_Name FROM SNACK ORDER BY Snack_Price DESC";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_snacks, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtMost.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void LeastExpensive()
        {
            string all_snacks = "SELECT Snack_Name FROM SNACK ORDER BY Snack_Price ASC";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_snacks, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtLeast.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void TotalBookings()
        {
            string all_Bookings = "SELECT MAX(Booking_ID) FROM BOOKING";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_Bookings, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtTBookings.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void BigestBooking()
        {
            string all_snacks = "SELECT Total_TicketCost FROM BOOKING ORDER BY Total_TicketCost DESC";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_snacks, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtBBooking.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void SmallestBooking()
        {
            string all_snacks = "SELECT Total_TicketCost FROM BOOKING ORDER BY Total_TicketCost ASC";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_snacks, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtSBooking.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void TotalCustomers()
        {
            string all_Customers = "SELECT MAX(Customer_ID) FROM CUSTOMER";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_Customers, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtTCustomers.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void TotalMovies()
        {
            string all_Movies = "SELECT MAX(Movie_ID) FROM MOVIE";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_Movies, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtTMovies.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void LongestMovie()
        {
            string all_snacks = "SELECT Movie_Duration FROM MOVIE ORDER BY Movie_Duration DESC";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_snacks, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtLMovie.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void ShortestMovie()
        {
            string all_snacks = "SELECT Movie_Duration FROM MOVIE ORDER BY Movie_Duration ASC";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_snacks, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtSMovie.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void TotalGenre()
        {
            string all_Genre = "SELECT MAX(Genre_ID) FROM GENRE";
            conn = new SqlConnection(constr);
            conn.Open();
            com = new SqlCommand(all_Genre, conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtTGenre.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Use this code to test whether you can connect to the database
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
               // MessageBox.Show("Connection Successfull");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Could not connect to db");
            }

            TotalSnacks();
            MostExpensive();
            LeastExpensive();
            TotalBookings();
            BigestBooking();
            SmallestBooking();
            TotalCustomers();
            TotalMovies();
            LongestMovie();
            ShortestMovie();
            TotalGenre();
        }

        private void btnCommitSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Snacks main_snacks = new Main_Snacks();
            main_snacks.ShowDialog();
        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Cinemagic.frmCustomer movie = new Cinemagic.frmCustomer();
            movie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cinemagic.Booking booking = new Cinemagic.Booking();
            booking.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cinemagic.Movie movie = new Cinemagic.Movie();
            movie.Show();
        }
             

        private void btnGenre_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Cinemagic.Genre genre = new Cinemagic.Genre();
            genre.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cinemagic.Form1 Login = new Cinemagic.Form1();
            Login.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

 
}

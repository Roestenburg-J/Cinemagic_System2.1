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
using RandomProj;
using System.Data.SqlTypes;
using System.Windows.Forms.VisualStyles;

namespace Cinemagic
{
    public partial class Booking : Form
    {
        private string seats;
        private string booking;
        private string cost;
        private string date;
        
       

        private string connection;
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;




        private bool CheckSecondaryTBoxes()
        {   
            bool isEmpty = false;

            if (String.IsNullOrEmpty(acost.Text)|| String.IsNullOrEmpty( aseats.Text) || String.IsNullOrEmpty(aseats.Text))
            {
                isEmpty = true;
            }

            
            return isEmpty;
           

        }
        private bool CheckDelete()
        {
            bool isEmpty = false;

            if (String.IsNullOrEmpty(dbooking.Text))
            {
                isEmpty = true;
            }


            return isEmpty;


        }


        private void Search(string booking)
        {

         
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Booking = "SELECT * FROM BOOKING WHERE Booking_ID = '"+ booking +"'";
            cinema.com = new SqlCommand(select_Booking, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_Booking, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Booking");
            dataGridView1.DataSource = cinema.ds;
            dataGridView1.DataMember = "Booking";
            cinema.conn.Close();

        }
        private Boolean TestSearch(string booking)
        {

            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Booking = "SELECT * FROM BOOKING where Booking_ID = '" + booking + "'";
            cinema.com = new SqlCommand(select_Booking, cinema.conn);
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


        private void Delete(string booking)
        {

            if (CheckDelete())
            {
                MessageBox.Show("Please make sure all inputs are filled");
            }
            else
            {   
                   Main cinema = new Main();
                    connection = cinema.constr;
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    string delete_Booking = "DELETE BOOKING WHERE Booking_ID = '"+ booking + "'";
                    cinema.com = new SqlCommand(delete_Booking, cinema.conn);
                    cinema.adap = new SqlDataAdapter();
                    cinema.ds = new DataSet();
                    cinema.adap = new SqlDataAdapter(delete_Booking, cinema.conn);
                    cinema.com.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Booking successfully deleted");
                    


            }



        }

        private void Insert(string cost, string seats, string date, string customer, string movie)
        {
                try
                {   
                    Main cinema = new Main();
                    connection = cinema.constr;
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    string insert_booking = @"INSERT INTO BOOKING (Total_TicketCost,NumberOfSeats,Tickets_SaleDate, Movie_ID, Customer_ID) values(@cost,@seats,@date, @movie, @customer)";

                    cinema.com = new SqlCommand(insert_booking, cinema.conn);
                    cinema.com.Parameters.AddWithValue("@cost", cost);
                    cinema.com.Parameters.AddWithValue("@seats",seats );
                    cinema.com.Parameters.AddWithValue("@date", date);
                    cinema.com.Parameters.AddWithValue("@customer", customer);
                    cinema.com.Parameters.AddWithValue("@movie", movie);

                    cinema.com.ExecuteNonQuery();
                    cinema.conn.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + " Could not insert data ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            
         

        }

        private void Display()
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Booking = "SELECT * FROM BOOKING";
            cinema.com = new SqlCommand(select_Booking, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_Booking, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Booking");
            dataGridView1.DataSource = cinema.ds;
            dataGridView1.DataMember = "Booking";
            cinema.conn.Close();



        }

        private void EditTicketCost(string booking, string newCost)
        {
           
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string edit_cost = "UPDATE BOOKING SET Total_TicketCost=@cost WHERE Booking_ID = '" + booking +"'";
            cinema.com = new SqlCommand(edit_cost, cinema.conn);
            cinema.com.Parameters.AddWithValue("@cost", newCost);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
      
        }

        private void EditSeats(string booking ,string newSeats)
        {
            
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string edit_seats = "UPDATE BOOKING SET NumberOfSeats=@seats WHERE Booking_ID = '" + booking +"'";
            cinema.com = new SqlCommand(edit_seats, cinema.conn);
            cinema.com.Parameters.AddWithValue("@seats", newSeats);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
  
        }

        private void EditDate(string booking ,string newDate)
        {
            
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string edit_date = "UPDATE BOOKING SET Tickets_SaleDate=@date WHERE Booking_ID = '" + booking + "'";
            cinema.com = new SqlCommand(edit_date, cinema.conn);
            cinema.com.Parameters.AddWithValue("@date", newDate);
            cinema.com.ExecuteNonQuery();
            cinema.conn.Close();
     
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
         
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
          
        }

        private void dtptickets_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BookingID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string booking = "";
            booking = dbooking.Text;

            if(dbooking.Text != "")
            {
                TestSearch(booking);

                if(TestSearch(booking) == true)
                {
                    Search(booking);
                }


            }
            if(TestSearch(booking)==false)
            {

                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                MessageBox.Show("Booking ID could not be found", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                btnupdate.Enabled = true;
                btndelete.Enabled = true;
            }



          
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {   

            seats = bseats.Text;
            cost = bcost.Text;
            date = bdate.Value.ToString();
            string customerID = udCustomerID.Text;
            string movieID = udMovieID.Text;
            
            if(bseats.Text == "" || bcost.Text == "" )
            {
                MessageBox.Show(" Please fill in the necessary textboxes ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Insert(cost, seats, date, customerID, movieID);
                MessageBox.Show("Booking made sucsesfully", "SUCSESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

            



        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {

            Boolean istrue = true;

            if(cbcost.Checked == true)
            {
                if(acost.Text == "")
                {
                    MessageBox.Show(" Please fill in the textbox ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    istrue = false;
                    
                }

                else
                {
                    try
                    {
                        EditTicketCost(ubooking.Text, acost.Text);

                    }
                    catch
                    {
                        istrue = false;
                    }
                }
            }
            if (cbseats.Checked == true)
            {
                if (aseats.Text == "")
                {
                    MessageBox.Show(" Please fill in the textbox", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    istrue = false;

                }


                else
                {
                    try
                    {
                        EditSeats(ubooking.Text, aseats.Text);

                    }
                    catch
                    {
                        istrue = false;
                    }
                }
            }
            if (cbdate.Checked == true)
            {

                    try
                    {
                        EditDate(ubooking.Text, adate.Value.ToString());

                    }
                    catch
                    {
                        istrue = false;
                    }
                
            }

            if (istrue == true)
            {
                MessageBox.Show("Booking updated Successfully", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

                ubooking.Text = "";
                acost.Text = "";
                aseats.Text = "";
            

                Search(booking);
                Display();
            }

           








            
        }

        private void btnbooking_Click_1(object sender, EventArgs e)
        {
            string booking = "";
            booking = dbooking.Text;
            Delete(booking);
            Display();
        }

        private void cbcost_CheckedChanged(object sender, EventArgs e)
        {
            if(cbcost.Checked)
            {
                acost.Enabled = true;
            }

            else
            {
                acost.Enabled = false;
                acost.Text = "";
            }
        }

        private void cbseats_CheckedChanged(object sender, EventArgs e)
        {
            if (cbseats.Checked)
            {
                aseats.Enabled = true;
            }

            else
            {
                aseats.Enabled = false;
                aseats.Text = "";
            }
        }

        private void cbdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdate.Checked)
            {
                adate.Enabled = true;
            }

            else
            {
                adate.Enabled = false;
                adate.Text = "";
            }
        }

        private void txtMovie_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void dbooking_TextChanged(object sender, EventArgs e)
        {
           

       
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Booking = "SELECT * FROM BOOKING";
            cinema.com = new SqlCommand(select_Booking, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_Booking, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Booking");
            dataGridView1.DataSource = cinema.ds;
            dataGridView1.DataMember = "Booking";
            cinema.conn.Close();
        }

        private void gpBooking_Enter(object sender, EventArgs e)
        {
           
        }

        private void gpupdate_Enter(object sender, EventArgs e)
        {
           

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void gprecord_Enter(object sender, EventArgs e)
        {
            
        }

        private void acost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}       


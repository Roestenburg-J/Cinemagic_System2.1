﻿using System;
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
        private string customer;
        private string movie;

        



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

            booking = dbooking.Text;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Booking = "SELECT * FROM BOOKING where Booking_ID'"+booking+"'";
            cinema.com = new SqlCommand(select_Booking, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_Booking, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Booking");
            dataGridView1.DataSource = cinema.ds;
            dataGridView1.DataMember = "Booking";
            cinema.conn.Close();

        }
        private bool TestSearch(string booking)
        {

            booking = dbooking.Text;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_Booking = "SELECT * FROM BOOKING where Booking_ID'" + booking + "'";
            cinema.com = new SqlCommand(select_Booking, cinema.conn);

          
            int i = ds.Tables[0].Rows.Count;

            if (i>0)
            {   
                MessageBox.Show("The Booking_ID " + booking + " was found in the database ");
                return true;
            }

            else
            {   
                MessageBox.Show("The Booking_ID " + booking + "was not found in the database");
                return false;
                
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
                    booking = dbooking.Text;
                    Main cinema = new Main();
                    connection = cinema.constr;
                try
                {
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    string delete_Booking = "delete * FROM BOOKING where Booking_ID '"+booking+ "'";
                    cinema.com = new SqlCommand(delete_Booking, cinema.conn);
                    cinema.adap = new SqlDataAdapter();
                    cinema.ds = new DataSet();
                    cinema.adap = new SqlDataAdapter(delete_Booking, cinema.conn);
                    cinema.conn.Close();
                    MessageBox.Show("Booking successfully deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Could not delete booking ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }





            }



        }

        private void Insert(string cost, string seats, string date)
        {

            if(CheckSecondaryTBoxes())
            {
                MessageBox.Show("Please make sure all inputs are filled");
            }
            else
            {
                Main cinema = new Main();
                connection = cinema.constr;

                try
                {
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    string insert_booking = @"INSERT INTO BOOKING (Total_Ticketcost,NumberOfSeats,Tickets_saleDate) values(@cost,@seats,@date)";

                    cinema.com = new SqlCommand(insert_booking, cinema.conn);
                    cinema.com.Parameters.AddWithValue("@Total_Ticketcost", cost);
                    cinema.com.Parameters.AddWithValue("@NumberOfSeats",seats );
                    cinema.com.Parameters.AddWithValue("@Tickets_saleDate", date);

                    cinema.com.ExecuteNonQuery();
                    cinema.conn.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + " Could not insert data ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
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

        private void EditTicketCost(string newCost)
        {
            cost = bcost.Text;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string edit_cost = "UPDATE BOOKING SETTotal_Ticketcost=@cost'";
            cinema.com = new SqlCommand(edit_cost, cinema.conn);
            cinema.com.Parameters.AddWithValue("@cost", newCost);
            cinema.conn.Close();
      
        }

        private void EditSeats(string newseats)
        {
            seats = bseats.Text;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string edit_seats = "UPDATE BOOKING SET NumberOfSeats=@seats'";
            cinema.com = new SqlCommand(edit_seats, cinema.conn);
            cinema.com.Parameters.AddWithValue("@seats", newseats);
            cinema.conn.Close();
  
        }

        private void EditDate(string newDate)
        {
            date = bdate.Text;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string edit_date = "UPDATE BOOKING SET Tickets_SaleDate=@date'";
            cinema.com = new SqlCommand(edit_date, cinema.conn);
            cinema.com.Parameters.AddWithValue("@date", newDate);
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
            dbooking.Text = "";
            booking = dbooking.Text;

            if(dbooking.Text != "")
            {
                TestSearch(booking);

                if(TestSearch(booking) == true)
                {
                    Search(booking);
                }


            }



          
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            seats = aseats.Text;
            cost = acost.Text;
            movie = txtMovie.Text;
            date = adate.Text;

            Insert(cost, seats, date);

            



        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            booking = ubooking.Text;

            if(cbcost.Checked == true)
            {
                try
                {
                    EditTicketCost(bcost.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a correct value.");
                }
            }
            if (cbseats.Checked == true)
            {
                try
                {
                    EditSeats(bseats.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a correct value.");
                }
            if (cbdate.Checked == true)
            {
                try
                {
                    EditDate(bdate.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a correct value.");
                }
            }

                MessageBox.Show("Booking updated Successfully");
                Display();








            }
        }

        private void btnbooking_Click_1(object sender, EventArgs e)
        {
            booking = dbooking.Text;
            Delete(booking);
            Display();
        }

        private void cbcost_CheckedChanged(object sender, EventArgs e)
        {
            acost.Enabled = true;
        }

        private void cbseats_CheckedChanged(object sender, EventArgs e)
        {
            aseats.Enabled = true;
        }

        private void cbdate_CheckedChanged(object sender, EventArgs e)
        {
            adate.Enabled = true;
        }

        private void txtMovie_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void dbooking_TextChanged(object sender, EventArgs e)
        {
           

            if(dbooking.Text == "")
            {
                Main cinema = new Main();
                connection = cinema.constr;
                cinema.conn = new SqlConnection(connection);
                cinema.conn.Open();
                string select_booking = "Select Movie_ID from BOOKING where Booking_ID='"+dbooking.Text+"'";
                cinema.com = new SqlCommand(select_booking, cinema.conn);
                
                cinema.adap = new SqlDataAdapter();
                
                SqlDataReader dr = com.ExecuteReader();

                while(dr.Read())
                {  
                    txtMovie.Text = dr.GetValue(2).ToString();
                    txtCustomer.Text = dr.GetValue(1).ToString();

                }
                conn.Close();
            }
            
        }
    }
}       


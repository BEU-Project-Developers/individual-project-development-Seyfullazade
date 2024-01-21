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

namespace Airline
{
    public partial class FlightTbl : Form
    {
        // Create a SqlConnection object to connect to the database
        SqlConnection Con = new SqlConnection(@"Data Source=.; Initial Catalog=AirlineDB;Integrated Security=true;");

        public FlightTbl()
        {
            InitializeComponent();
        }

        // Event handler for the form load event
        private void FlightTBL_Load(object sender, EventArgs e)
        {
            // Load data into the FlightTbl table from the database
            this.flightTblTableAdapter.Fill(this.airlineDBDataSet3.FlightTbl);
        }

        // Event handler for the "Add Flight" button
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any required information is missing
            if (FcodeTb.Text == "" || Fsrc.Text == "" || FDest.Text == "" || FDate.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    // Open the database connection
                    Con.Open();

                    // SQL query to insert flight information into the database
                    string query = "insert into FlightTbl values('" + FcodeTb.Text + "','" + Fsrc.SelectedItem.ToString() + "', '" + FDest.SelectedItem.ToString() + "', '" + FDate.Value.ToString() + "', '" + SeatNum.Text + "')";

                    // Create a SqlCommand object and execute the query
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    // Display a success message
                    MessageBox.Show("Flight Recorded Successfully");

                    // Close the database connection
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    // Display an error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the "Clear" button
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the text in all input fields
            FcodeTb.Text = "";
            SeatNum.Text = "";
            Fsrc.Text = "";
            FDest.Text = "";
            FDate.Text = "";
        }

        // Event handler for the "View Flights" button
        private void button3_Click(object sender, EventArgs e)
        {
            // Open the ViewFlights form and hide the current FlightTbl form
            ViewFlights viewflt = new ViewFlights();
            viewflt.Show();
            this.Hide();
        }

        // Event handler for the close button (X) on the form
        private void label8_Click(object sender, EventArgs e)
        {
            // Exit the application when the close button is clicked
            Application.Exit();
        }

        // Event handler for the "Back to Home" button
        private void button4_Click(object sender, EventArgs e)
        {
            // Open the Home form and hide the current FlightTbl form
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

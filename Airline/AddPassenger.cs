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
    public partial class AddPassenger : Form
    {
        // Create a SqlConnection object to connect to the database
        SqlConnection Con = new SqlConnection(@"Data Source=.; Initial Catalog=AirlineDB;Integrated Security=true;");

        public AddPassenger()
        {
            InitializeComponent();
        }

        // Event handler for the close button (X) on the form
        private void label10_Click(object sender, EventArgs e)
        {
            // Exit the application when the close button is clicked
            Application.Exit();
        }

        // Event handler for the "Save" button
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any required information is missing
            if (PassId.Text == "" || PassAd.Text == "" || PassName.Text == "" || PassportTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    // Open the database connection
                    Con.Open();

                    // SQL query to insert passenger information into the database
                    string query = "insert into PassengerTbl values(" + PassId.Text + ",' " + PassName.Text + "', '" + PassportTb.Text + "', '" + PassAd.Text + "', '" + NationalityCb.SelectedItem.ToString() + "', '" + GenderCb.SelectedItem.ToString() + "','" + PhoneTb.Text + "')";

                    // Create a SqlCommand object and execute the query
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    // Display a success message
                    MessageBox.Show("Passenger Recorded Successfully");

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

        // Event handler for the "View Passengers" button
        private void button3_Click(object sender, EventArgs e)
        {
            // Open the ViewPassenger form and hide the current AddPassenger form
            ViewPassenger viewpas = new ViewPassenger();
            viewpas.Show();
            this.Hide();
        }

        // Event handler for the form load event
        private void AddPassenger_Load(object sender, EventArgs e)
        {
            // Load data into the PassengerTbl table from the database
            this.passengerTblTableAdapter1.Fill(this.airlineDBDataSet3.PassengerTbl);
        }

        // Event handler for the "Clear" button
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the text in all input fields
            PassId.Text = "";
            PassAd.Text = "";
            PassName.Text = "";
            PassportTb.Text = "";
            PhoneTb.Text = "";
            NationalityCb.Text = "";
            GenderCb.Text = "";
            PhoneTb.Text = "";
        }

        // Event handler for the "Back to Home" button
        private void button4_Click(object sender, EventArgs e)
        {
            // Open the Home form and hide the current AddPassenger form
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

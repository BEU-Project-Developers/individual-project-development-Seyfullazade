using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Event handler for the "Book Ticket" button
        private void button3_Click(object sender, EventArgs e)
        {
            // Open the Ticket form and hide the current Home form
            Ticket tick = new Ticket();
            tick.Show();
            this.Hide();
        }

        // Event handler for the "View Flights" button
        private void button1_Click(object sender, EventArgs e)
        {
            // Open the FlightTbl form and hide the current Home form
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        // Event handler for the "Add Passenger" button
        private void button2_Click(object sender, EventArgs e)
        {
            // Open the AddPassenger form and hide the current Home form
            AddPassenger Pass = new AddPassenger();
            Pass.Show();
            this.Hide();
        }

        // Event handler for the "Cancel Ticket" button
        private void button4_Click(object sender, EventArgs e)
        {
            // Open the CancellationTbl form and hide the current Home form
            CancellationTbl Can = new CancellationTbl();
            Can.Show();
            this.Hide();
        }

        // Event handler for the close button (X) on the form
        private void label10_Click(object sender, EventArgs e)
        {
            // Exit the application when the close button is clicked
            Application.Exit();
        }
    }
}

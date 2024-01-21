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

        // Event handler for the "Book Ticket" button: Open the Ticket form and hide the current Home form
        private void button3_Click(object sender, EventArgs e)
        {
            Ticket tick = new Ticket();
            tick.Show();
            this.Hide();
        }

        // Event handler for the "View Flights" button: Open the FlightTbl form and hide the current Home form
        private void button1_Click(object sender, EventArgs e)
        {
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        // Event handler for the "Add Passenger" button: Open the AddPassenger form and hide the current Home form
        private void button2_Click(object sender, EventArgs e)
        {
            AddPassenger Pass = new AddPassenger();
            Pass.Show();
            this.Hide();
        }

        // Event handler for the "Cancel Ticket" button: Open the CancellationTbl form and hide the current Home form
        private void button4_Click(object sender, EventArgs e)
        {
            CancellationTbl Can = new CancellationTbl();
            Can.Show();
            this.Hide();
        }

        // Event handler for the close button (X) on the form: Exit the application when the close button is clicked
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
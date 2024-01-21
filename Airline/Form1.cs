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
    public partial class Form1 : Form
    {
        // Variable to control the progress bar animation
        int startpoint = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the progress bar value
            startpoint += 2;
            Myprogress.Value = startpoint;

            // Check if the progress bar is complete
            if (Myprogress.Value == 100)
            {
                // Reset progress bar value and stop the timer
                Myprogress.Value = 0;
                timer1.Stop();

                // Open the login form and hide the current form
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }
    }
}

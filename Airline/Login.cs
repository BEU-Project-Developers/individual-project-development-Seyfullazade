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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Set the PasswordChar property for the password TextBox to display '*' for each character
            PassTb.PasswordChar = '*';
        }

        // Event handler for the close button (X) on the form
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the "Clear" button: Clear the text in both the User Id and Password textboxes
        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        // Event handler for the "Login" button
        private void button1_Click(object sender, EventArgs e)
        {

            if (UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter The User Id and Password");
            }
            else if (UidTb.Text == "Admin" && PassTb.Text == "Admin")
            {
                // Open the Home form and hide the current login form
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password");
            }
        }
    }
}

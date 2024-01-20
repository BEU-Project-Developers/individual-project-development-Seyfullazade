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
            // Set the PasswordChar property for the password TextBox
            PassTb.PasswordChar = '*';
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text=="" || PassTb.Text == "")
            {
                MessageBox.Show("Enter The User Id and Password");
            }
            else if(UidTb.Text=="Admin" && PassTb.Text == "Admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

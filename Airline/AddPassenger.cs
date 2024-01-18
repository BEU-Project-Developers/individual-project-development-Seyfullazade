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
        public AddPassenger()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus\OneDrive\İş masası\Sənədlər\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "" || PassAd.Text == "" || PassName.Text == "" || PassportTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query= "insert into PassengerTbl values(" + PassId.Text + ",' " + PassName.Text + "', '" + PassportTb.Text + "', '" + PassAd.Text + "', '" + NationalityCb.SelectedItem.ToString() + "', '" + GenderCb.SelectedItem.ToString() + "','" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Sucesssfully");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpas = new ViewPassenger();
            viewpas.Show();
            this.Hide();
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDbDataSet.PassengerTbl' table. You can move, or remove it, as needed.
            this.passengerTblTableAdapter.Fill(this.airlineDbDataSet.PassengerTbl);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassAd.Text = "";
            PassName.Text = "";
            PassportTb.Text = "";
            PhoneTb.Text = "";
            NationalityCb.Text = "";
            GenderCb.Text = "";
            PhoneTb.Text = "";
        }
    }
}

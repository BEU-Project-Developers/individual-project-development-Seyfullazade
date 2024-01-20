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
using System.Security.Cryptography;
using static System.Windows.Forms.AxHost;

namespace Airline
{
    public partial class CancellationTbl : Form
    {
        public CancellationTbl()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.; Initial Catalog=AirlineDB;Integrated Security=true;");
        private void fillTicketId()
        {
            Con.Open();
            // Select TicketIds from TicketTbl where the ticket is not canceled
            string query = "SELECT Tid FROM TicketTbl WHERE NOT EXISTS (SELECT 1 FROM CancelTbl WHERE CancelTbl.TicId = TicketTbl.Tid)";

            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tid", typeof(string));
            dt.Load(rdr);
            TidCb.ValueMember = "Tid";
            TidCb.DataSource = dt;
            Con.Close();
        }

        private void RefreshTicketIds()
        {
            fillTicketId(); // Call the fillTicketId method to repopulate the combobox
        }
        private void fetchfcode()
        {
            Con.Open();
            string query = "select * from TicketTbl where Tid=" + TidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FcodeTb.Text = dr["Fcode"].ToString();

            }
            Con.Close();
        }

        private void populate()
        {

            Con.Open();
            String query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancelDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
       

        private void CancellationTbl_Load(object sender, EventArgs e)
        {
            fillTicketId();
            populate();

        }

        private void TidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchfcode();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }


        private void deleteTicket()
        {
            try
            {
                if (TidCb.SelectedValue != null)
                {
                    Con.Open();
                    string query = "DELETE FROM TicketTbl WHERE Tid = @TicketId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@TicketId", TidCb.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Ticket Deleted Successfully");
                    Con.Close();

                    // Debug statements
                    Console.WriteLine("Deleted ticket with ID: " + TidCb.SelectedValue);

                    // Refresh the data in DataGridView and update ticket IDs in the combobox
                    populate();
                    RefreshTicketIds();
                }
                else
                {
                    MessageBox.Show("Please select a ticket to delete.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (CanId.Text == "" || FcodeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CancelTbl values(" + CanId.Text + ", " + TidCb.SelectedValue.ToString() + ",'" + FcodeTb.Text + "', '" + CancDate.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancelled Sucesssfully");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CanId.Text = "";
            FcodeTb.Text = "";
            TidCb.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TidCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
    }
}

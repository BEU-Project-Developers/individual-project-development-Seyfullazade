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
using System.Text.RegularExpressions;

namespace Airline
{
    public partial class Ticket : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.; Initial Catalog=AirlineDB;Integrated Security=true;");
        public Ticket()
        {
            InitializeComponent();
        }
        public void populate()
        {
            Con.Open();
            String query = "SELECT T.Tid, T.Fcode, T.Pid, T.PName, T.PPass, T.PNation, T.Amt " +
                           "FROM TicketTbl T " +
                           "LEFT JOIN CancelTbl C ON T.Tid = C.TicId " +
                           "WHERE C.TicId IS NULL";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        // Method to remove a ticket based on its ID
        public void RemoveTicket(int ticketId)
        {
            try
            {
                Con.Open();
                string query = "delete from TicketTbl where Tid=" + ticketId + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticket Removed Successfully");
                Con.Close();
                populate(); // Refresh the data after removing the ticket
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // Method to fill the Passenger ID ComboBox with data from the PassengerTbl table
        private void fillPassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PIdCb.ValueMember = "PassId";
            PIdCb.DataSource = dt;
            Con.Close();
        }

        // Method to fill the Flight Code ComboBox with data from the FlightTbl table
        private void fillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FCodeCb.ValueMember = "Fcode";
            FCodeCb.DataSource = dt;
            Con.Close();
        }

        // Variables to store passenger details
        string pname, ppass, pnat;

        // Method to fetch and display passenger details based on selected Passenger ID
        private void fetchpassenger()
        {
            Con.Open();
            string query = "select * from PassengerTbl where PassId=" + PIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassNat"].ToString();
                PNameTb.Text = pname;
                PPassTb.Text = ppass;
                PNatTb.Text = pnat;
            }
            Con.Close();
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the form load event
        private void Ticket_Load(object sender, EventArgs e)
        {
            // Fill the Passenger ID and Flight Code ComboBoxes
            fillPassenger();
            fillFlightCode();
            populate();
        }

        // Event handler for the "Book Ticket" button
        private void button1_Click(object sender, EventArgs e)
        {
            if (Tid.Text == "" || PNameTb.Text == "")
            {
                MessageBox.Show("Missing Information, fill required items");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into TicketTbl values(" + Tid.Text + ",'" + FCodeCb.SelectedValue.ToString() + "'," + PIdCb.SelectedValue.ToString() + ", '" + PNameTb.Text + "', '" + PPassTb.Text + "', '" + PNatTb.Text + "'," + PAmtTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    Con.Close();
                    populate(); // Refresh the DataGridView with updated data
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the "Clear" button
        private void button2_Click(object sender, EventArgs e)
        {
            PIdCb.Text = "";
            FCodeCb.Text = "";
            PNameTb.Text = "";
            PPassTb.Text = "";
            PNatTb.Text = "";
            PAmtTb.Text = "";
            Tid.Text = "";
        }

        // Event handler for the "Back" button
        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        // Event handler for the DataGridView cell click event
        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FlightDGV.ForeColor = System.Drawing.Color.Black;

            if (FlightDGV.SelectedRows.Count > 0)
            {
                Tid.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
                FCodeCb.Text = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
                PIdCb.Text = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
                PNameTb.Text = FlightDGV.SelectedRows[0].Cells[3].Value.ToString();
                PPassTb.Text = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();
                PNatTb.Text = FlightDGV.SelectedRows[0].Cells[5].Value.ToString();
                PAmtTb.Text = FlightDGV.SelectedRows[0].Cells[6].Value.ToString();
            }
            if (e.RowIndex >= 0 && e.RowIndex < FlightDGV.Rows.Count)
            {
                Tid.Text = FlightDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                FCodeCb.Text = FlightDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                PIdCb.Text = FlightDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                PNameTb.Text = FlightDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                PPassTb.Text = FlightDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                PNatTb.Text = FlightDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                PAmtTb.Text = FlightDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        // Event handler for the Passenger ID ComboBox selection change
        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpassenger();
        }
    }
}
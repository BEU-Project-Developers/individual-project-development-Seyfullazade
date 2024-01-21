using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class ViewFlights : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.; Initial Catalog=AirlineDB;Integrated Security=true;");

        public ViewFlights()
        {
            InitializeComponent();
        }

        // Method to populate the DataGridView with data from the database
        private void populate()
        {
            Con.Open();
            String query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        // Event handler for the "Update Flight" button
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any required information is missing
            if (FcodeTb.Text == "" || Seatnum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "update FlightTbl set Fsrc='" + SrcCb.SelectedItem.ToString() + "', Fdest='" + DstCb.SelectedItem.ToString() + "', FDate='" + FDate.Value.Date.ToString() + "', Fcap='" + Seatnum.Text + "' where Fcode='" + FcodeTb.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();                
                    MessageBox.Show("Flight Updated Successfully");
                    Con.Close();

                    // Populate the DataGridView with updated data
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the form load event
        private void ViewFlights_Load(object sender, EventArgs e)
        {
            // Load data into the FlightTbl table from the database
            this.flightTblTableAdapter.Fill(this.airlineDBDataSet3.FlightTbl);
            populate();
        }

        // Event handler for the "Add Flight" button
        private void button3_Click(object sender, EventArgs e)
        {
            // Open the FlightTbl form and hide the current ViewFlights form
            FlightTbl Addfl = new FlightTbl();
            Addfl.Show();
            this.Hide();
        }

        // Event handler for the "Clear" button
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the text in all input fields
            FcodeTb.Text = "";
            Seatnum.Text = "";
            SrcCb.Text = "";
            DstCb.Text = "";
            FDate.Value = DateTime.Today;
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected and within the valid range
            if (FlightDGV.SelectedRows.Count > 0)
            {
                FcodeTb.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
                SrcCb.Text = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
                DstCb.Text = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
                FDate.Text = FlightDGV.SelectedRows[0].Cells[3].Value.ToString();
                Seatnum.Text = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();
            }

            // Check if the clicked row is within the valid range
            if (e.RowIndex >= 0 && e.RowIndex < FlightDGV.Rows.Count)
            {
                FcodeTb.Text = FlightDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                SrcCb.Text = FlightDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                DstCb.Text = FlightDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                FDate.Text = FlightDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                Seatnum.Text = FlightDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        // Event handler for the "Delete Flight" button
        private void button4_Click(object sender, EventArgs e)
        {
            // Check if the Flight Code textbox is empty
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Enter The Flight to Delete");
            }
            else
            {
                try
                {                   
                    Con.Open();              
                    string query = "delete from FlightTbl where Fcode='" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    Con.Close();
                    // Populate the DataGridView with updated data
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}

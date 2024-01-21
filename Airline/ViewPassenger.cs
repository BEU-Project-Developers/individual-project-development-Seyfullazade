using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class ViewPassenger : Form
    {
        // Create a SqlConnection object to connect to the database
        SqlConnection Con = new SqlConnection(@"Data Source=.; Initial Catalog=AirlineDB;Integrated Security=true;");

        public ViewPassenger()
        {
            InitializeComponent();
        }

        // Method to populate the DataGridView with data from the database
        private void populate()
        {
            Con.Open();
            String query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        // Event handler for the form load event
        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            // Load data into the PassengerTbl table from the database
            this.passengerTblTableAdapter2.Fill(this.airlineDBDataSet3.PassengerTbl);
            // Populate the DataGridView with data
            populate();
        }

        // Event handler for the DataGridView cell click event
        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected and within the valid range
            if (PassengerDGV.SelectedRows.Count > 0 && e.RowIndex >= 0 && e.RowIndex < PassengerDGV.Rows.Count)
            {
                // Populate textboxes with selected row data
                PidTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
                PnameTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
                PpassTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
                PaddTb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
                natcb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
                GendCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
            }

            // Check if the clicked row is within the valid range
            if (e.RowIndex >= 0 && e.RowIndex < PassengerDGV.Rows.Count)
            {
                // Populate textboxes with clicked row data
                PidTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                PnameTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                PpassTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                PaddTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                natcb.Text = PassengerDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                GendCb.Text = PassengerDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                PphoneTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        // Event handler for the "Add Passenger" button
        private void button3_Click(object sender, EventArgs e)
        {
            // Open the AddPassenger form and hide the current ViewPassenger form
            AddPassenger addpas = new AddPassenger();
            addpas.Show();
            this.Hide();
        }

        // Event handler for the "Delete Passenger" button
        private void button4_Click(object sender, EventArgs e)
        {
            // Check if the Passenger ID textbox is empty
            if (PidTb.Text == "")
            {
                MessageBox.Show("Enter The Passenger to Delete");
            }
            else
            {
                try
                {
                    // Open the database connection
                    Con.Open();
                    // SQL query to delete a passenger based on the Passenger ID
                    string query = "delete from PassengerTbl where PassId=" + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    // Execute the query and display a success message
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Con.Close();
                    // Populate the DataGridView with updated data
                    populate();
                }
                catch (Exception Ex)
                {
                    // Display an error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the "Clear" button
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the text in all input fields
            PidTb.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddTb.Text = "";
            natcb.Text = "";
            GendCb.Text = "";
            PphoneTb.Text = "";
        }

        // Event handler for the "Update Passenger" button
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any required information is missing
            if (PidTb.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" || PaddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    // Open the database connection
                    Con.Open();
                    // SQL query to update passenger information based on the Passenger ID
                    string query = "update PassengerTbl set PassName='" + PnameTb.Text + "',Passport='" + PpassTb.Text + "',PassAd='" + PaddTb.Text + "',PassNat='" + natcb.SelectedItem.ToString() + "',PassGend='" + GendCb.SelectedItem.ToString() + "' ,PassPhone='" + PphoneTb.Text + "' where PassId=" + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    // Execute the query and display a success message
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
                    Con.Close();
                    // Populate the DataGridView with updated data
                    populate();
                }
                catch (Exception Ex)
                {
                    // Display an error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}

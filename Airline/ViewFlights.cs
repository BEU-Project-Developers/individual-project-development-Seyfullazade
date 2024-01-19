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
        public ViewFlights()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.; Initial Catalog=AirlineDB;Integrated Security=true;");

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

       
        private void button1_Click(object sender, EventArgs e)
        {

            if (FcodeTb.Text == "" || Seatnum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FlightTbl set Fsrc='" + SrcCb.SelectedItem.ToString() + "', Fdest='" + DstCb.SelectedItem.ToString() + "', FDate='" + FDate.Value.Date.ToString() + "', Fcap='" + Seatnum.Text + " where Fcode='" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDBDataSet3.FlightTbl' table. You can move, or remove it, as needed.
            this.flightTblTableAdapter.Fill(this.airlineDBDataSet3.FlightTbl);
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlightTbl Addfl = new FlightTbl();
            Addfl.Show();
            this.Hide();

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            Seatnum.Text = "";
            SrcCb.Text = "";
            DstCb.Text = "";
            FDate.Value = DateTime.Today;
            //FDate.Text = "";
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FlightDGV.SelectedRows.Count > 0)
            {
                FcodeTb.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
                SrcCb.Text = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
                DstCb.Text = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
                FDate.Text = FlightDGV.SelectedRows[0].Cells[3].Value.ToString();
                Seatnum.Text = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();

            }
            if (e.RowIndex >= 0 && e.RowIndex < FlightDGV.Rows.Count)
            {
                FcodeTb.Text = FlightDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                SrcCb.Text = FlightDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                DstCb.Text = FlightDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                FDate.Text = FlightDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                Seatnum.Text = FlightDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
               
            }

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
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

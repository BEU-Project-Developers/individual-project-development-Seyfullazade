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
        public ViewPassenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.; Initial Catalog=AirlineDB;Integrated Security=true;");
        private void populate() { 
            
            Con.Open();
            String query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            
            Con.Close();
            }
        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDBDataSet3.PassengerTbl' table. You can move, or remove it, as needed.
            this.passengerTblTableAdapter2.Fill(this.airlineDBDataSet3.PassengerTbl);
            populate();

        }

      

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PassengerDGV.SelectedRows.Count > 0 && e.RowIndex >= 0 && e.RowIndex < PassengerDGV.Rows.Count)
            {
                PidTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
                PnameTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
                PpassTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
                PaddTb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
                natcb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
                GendCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
            }

            if (e.RowIndex >= 0 && e.RowIndex < PassengerDGV.Rows.Count)
            {
                PidTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                PnameTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                PpassTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                PaddTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                natcb.Text = PassengerDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                GendCb.Text = PassengerDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                PphoneTb.Text = PassengerDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPassenger addpas = new AddPassenger();
            addpas.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == "")
            {
                MessageBox.Show("Enter The Passenger to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PassengerTbl where PassId=" + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex) {
                    MessageBox.Show(Ex.Message);
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PidTb.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddTb.Text="";
            natcb.Text = "";
            GendCb.Text= "";
            PphoneTb.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PidTb.Text=="" || PnameTb.Text == "" || PpassTb.Text == "" || PaddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengerTbl set PassName='" + PnameTb.Text + "',Passport='" + PpassTb.Text + "',PassAd='" + PaddTb.Text + "',PassNat='" + natcb.SelectedItem.ToString() + "',PassGend='" + GendCb.SelectedItem.ToString() + "' ,PassPhone='" + PphoneTb.Text + "' where PassId=" + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
               
            }
        }
    }
}

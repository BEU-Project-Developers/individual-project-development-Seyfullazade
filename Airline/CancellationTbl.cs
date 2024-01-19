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
            SqlCommand cmd = new SqlCommand("select Tid from TicketTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tid", typeof(string));
            dt.Load(rdr);
            TidCb.ValueMember = "Tid";
            TidCb.DataSource = dt;
            Con.Close();
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
        private void label2_Click(object sender, EventArgs e)
        {

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
                    Con.Open();
                string query = "delete from TicketTbl where Tid=" + TidCb.SelectedValue.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    Con.Close();
                    populate();
                deleteTicket();
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
                    MessageBox.Show("Ticekt Cancelled Sucesssfully");
                    Con.Close();
                    populate();
                    deleteTicket();

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

        private void CancelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

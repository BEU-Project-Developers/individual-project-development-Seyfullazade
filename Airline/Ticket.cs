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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus\OneDrive\İş masası\Sənədlər\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");
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
        private void fetchpassenger()
        {
             
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPassenger();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}

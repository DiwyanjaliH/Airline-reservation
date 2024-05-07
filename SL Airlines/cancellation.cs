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

namespace SL_Airlines
{
    public partial class cancellation : Form
    {
        public cancellation()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmrwg\OneDrive\Documents\SLAirlineDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Fill_Ticket_Bookings()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Ticket_No from Ticket", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Ticket_No", typeof(string));
            table.Load(reader);
            cmb_tktno.ValueMember = "Ticket_No";
            cmb_tktno.DataSource = table;
            Con.Close();

        }

        private void fetch_flight()
        {
            Con.Open();
            string query = "select*from Ticket where Ticket_No=" + cmb_tktno.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);

            foreach (DataRow dr in table.Rows)
            {
                mt_fcode.Text = dr["F_Code"].ToString();

            }
            Con.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancellation_Load(object sender, EventArgs e)
        {
            Fill_Ticket_Bookings();
            populate();

        }

        private void remove_ticket()
        {
           
                try
                {
                    Con.Open();
                    string query = "delete from Ticket where Ticket_No=" + cmb_tktno.SelectedValue.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Removed successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (mtxt_canclid.Text == "" )
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into cancellations values (" + mtxt_canclid.Text + ",'" + cmb_tktno.SelectedValue.ToString() + "','" + mt_fcode.Text + "','" +datetime_cancel.Value.Date+ "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancelled Successfully");
                    Con.Close();
                    populate();
                    remove_ticket();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select*from cancellations";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgview_cancel.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmb_tktno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_tktno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetch_flight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mt_fcode.Clear();
            mtxt_canclid.Clear();
            cmb_tktno.SelectedItem = null;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

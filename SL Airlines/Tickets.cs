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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmrwg\OneDrive\Documents\SLAirlineDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Fill_passengers()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select P_Id from passenger", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("P_Id", typeof(int));
            table.Load(reader);
            comboBox1.ValueMember = "P_Id";
            comboBox1.DataSource = table;
            Con.Close();

        }
        string pname,pprt_no,pnation;
        
        private void fetchpassengers()
        {
            Con.Open();
            string query="select*from passenger where P_Id="+comboBox1.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);

            foreach(DataRow dr in table.Rows)
            {
                pname = dr["P_Name"].ToString();
                pprt_no = dr["Ppor_tNo"].ToString();
                pnation = dr["P_Nation"].ToString();
                maskedTextBox2.Text = pname;
                maskedTextBox4.Text = pprt_no;
                maskedTextBox3.Text = pnation;


            }
            Con.Close();

        }

        private void Fill_Flight()
        { 
            Con.Open();
            SqlCommand cmd = new SqlCommand("select F_code from flight", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("F_code", typeof(string));
            table.Load(reader);
            comboBox2.ValueMember = "F_code";
            comboBox2.DataSource = table;
            Con.Close();

        }

        private void populate()
        {
            Con.Open();
            string query = "select*from Ticket";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Booking_DataGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            Fill_passengers();
            Fill_Flight();
            populate();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpassengers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox3.Text == "" || maskedTextBox4.Text == "" || maskedTextBox5.Text == "" || maskedTextBox6.Text == "" || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Ticket values (" + maskedTextBox1.Text + ",'"+comboBox2.SelectedValue.ToString() +"'," + comboBox1.SelectedValue.ToString() + ",'" + maskedTextBox2.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox3.Text + "','" + maskedTextBox5.Text + "'," + maskedTextBox6.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
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

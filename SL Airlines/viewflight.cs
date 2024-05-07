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
    public partial class viewflights : Form
    {
        public viewflights()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmrwg\OneDrive\Documents\SLAirlineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select*from flight";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null ||dateTimePicker1.Value==null)
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "update flight set F_source='" + comboBox1.SelectedItem.ToString() + "',F_date='" + dateTimePicker1.Value.Date.ToString() + "',F_destination='" + comboBox2.SelectedItem.ToString() + "',No_Of_Seats='" + maskedTextBox2.Text + "' where F_code='" + maskedTextBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Flight updated");
                    Con.Close();

                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void viewflights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Enter Flight Code to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from flight where F_code='" + maskedTextBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight deleted successfully");
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
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                maskedTextBox1.Text = row.Cells["F_code"].Value.ToString();
                comboBox1.SelectedItem = row.Cells["F_source"].Value.ToString();
                comboBox2.SelectedItem = row.Cells["F_destination"].Value.ToString();
                maskedTextBox2.Text = row.Cells["No_Of_Seats"].Value.ToString();
                
                
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Flights flight = new Flights();
            flight.Show();
            this.Hide();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

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
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmrwg\OneDrive\Documents\SLAirlineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
           
        }

        private void Flights_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mtxfcode.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "" || maskedTextBox2.Text== "" )
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into flight values ('"+ mtxfcode.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + dateTimePicker1.Value.ToString()+ "','" + maskedTextBox2.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mtxfcode.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            
            maskedTextBox2.Clear();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewflights view = new viewflights();
            view.Show();
            this.Hide();
        }
    }
}

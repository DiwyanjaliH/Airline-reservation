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
    public partial class passengers : Form
    {
        public passengers()
        {
            InitializeComponent();
        }
    
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmrwg\OneDrive\Documents\SLAirlineDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void passengers_Load(object sender, EventArgs e)
        {

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(maskedTextBox1.Text=="" || maskedTextBox2.Text=="" || maskedTextBox3.Text=="" || maskedTextBox4.Text=="" ||comboBox1.Text=="" ||comboBox2.Text=="")
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into passenger values ("+ maskedTextBox1.Text+ ",'"+maskedTextBox2.Text+"','"+maskedTextBox3.Text+"','"+maskedTextBox4.Text+"','"+comboBox1.SelectedItem.ToString()+"','"+comboBox2.SelectedItem.ToString()+"','"+maskedTextBox5.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Con.Close();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnvp_Click(object sender, EventArgs e)
        {
            View_passengers view = new View_passengers();
            view.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

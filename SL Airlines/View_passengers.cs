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
    public partial class View_passengers : Form
    {
        public View_passengers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmrwg\OneDrive\Documents\SLAirlineDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void populate()
        {
            Con.Open();
            string query = "select*from passenger";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void View_passengers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mtxtpid.Text == "" || mtxname.Text == "" || mtxpprt.Text == "" || mtxaddress.Text == "" || cmbgender.SelectedItem==null || cmbnation.SelectedItem==null)
            {
                MessageBox.Show("Missing Informations");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "update passenger set P_Name='"+mtxname.Text+ "',Ppor_tNo='" + mtxpprt.Text + "',P_Address='"+mtxaddress.Text+"',P_Nation='"+cmbnation.SelectedItem.ToString()+"',P_Gen='"+cmbgender.SelectedItem.ToString()+"',P_No='"+mtxphn.Text+"' where P_Id='"+mtxtpid.Text+"';";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("passenger updated");
                    Con.Close();
                    populate();
                    Refresh();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passengers passenger = new passengers();
            passenger.Show();
            this.Hide();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mtxtpid.Text=="")
            {
                MessageBox.Show("Enter passenger id to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from passenger where P_Id=" + mtxtpid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger deleted successfully");
                    Con.Close();
                    populate();
                    Refresh();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                mtxtpid.Text = row.Cells["P_Id"].Value.ToString();
                mtxname.Text = row.Cells["P_Name"].Value.ToString();
                mtxpprt.Text = row.Cells["Ppor_tNo"].Value.ToString();
                mtxaddress.Text = row.Cells["P_Address"].Value.ToString();
                cmbnation.SelectedItem = row.Cells["P_Nation"].Value.ToString();
                cmbgender.SelectedItem = row.Cells["P_Gen"].Value.ToString();
                mtxphn.Text = row.Cells["P_No"].Value.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mtxtpid.Clear();
            mtxname.Clear();
            mtxpprt.Clear();
            mtxaddress.Clear();
            mtxphn.Clear();
            cmbgender.SelectedItem= null;
            cmbnation.SelectedItem= null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

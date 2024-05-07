using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Airlines
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (mtxtid.Text=="" || mtxtpw.Text=="")

            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else if(mtxtid.Text=="Admin" && mtxtpw.Text=="Admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
                
            }

            else
            {
                MessageBox.Show("Invalid Authentication");
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            mtxtid.Clear();
            mtxtpw.Clear();
        }
    }
}

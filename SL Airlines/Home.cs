using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL_Airlines
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flights flight = new Flights();
            flight.Show();
            this.Hide();

        }

        private void btn_passengers_Click(object sender, EventArgs e)
        {
            passengers passenger = new passengers();
            passenger.Show();
            this.Hide();
        }

        private void btn_tkts_Click(object sender, EventArgs e)
        {
            Tickets tktbook = new Tickets();
            tktbook.Show();
            this.Hide();
        }

        private void btn_cancellations_Click(object sender, EventArgs e)
        {
            cancellation cancel = new cancellation();
            cancel.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

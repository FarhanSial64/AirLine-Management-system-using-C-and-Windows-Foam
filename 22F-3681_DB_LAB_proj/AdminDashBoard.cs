using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22F_3681_DB_LAB_proj
{
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            label1.Parent = Flights;
            label1.BackColor = Color.Transparent;
        }

        private void empButt_Click(object sender, EventArgs e)
        {
            new empOption().Show();
            this.Hide();
        }

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void schButt_Click(object sender, EventArgs e)
        {
            new schdule1().Show();
            this.Hide();
        }

        private void feedButt_Click(object sender, EventArgs e)
        {
            new viewAdminFeed().Show(); 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Flightdash().Show();
            this.Hide();
        }

        private void Flights_Click(object sender, EventArgs e)
        {

        }
    }
}

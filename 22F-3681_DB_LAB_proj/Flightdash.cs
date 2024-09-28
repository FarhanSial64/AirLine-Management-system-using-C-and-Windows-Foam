using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22F_3681_DB_LAB_proj
{
    public partial class Flightdash : Form
    {
        public Flightdash()
        {
            InitializeComponent();
        }

        private void Flightdash_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void feedButt_Click(object sender, EventArgs e)
        {
            new viewAdminFeed().Show();
            this.Hide();
        }

        private void schButt_Click(object sender, EventArgs e)
        {
            new schdule1().Show();
            this.Hide();
        }

        private void empButt_Click(object sender, EventArgs e)
        {
            new empOption().Show(); 
            this.Hide();
        }

        private void addFlight_Click(object sender, EventArgs e)
        {
            new addFlight().Show();
            this.Hide();
        }

        private void delFlight_Click(object sender, EventArgs e)
        {
            new deleteFlight().Show();
            this.Hide();
        }
    }
}

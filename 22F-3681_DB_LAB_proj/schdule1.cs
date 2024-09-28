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
    public partial class schdule1 : Form
    {
        public schdule1()
        {
            InitializeComponent();
        }

        private void schButt_Click(object sender, EventArgs e)
        {
            new schdule1().Show();
            this.Hide();
        }

        private void addSch_Click(object sender, EventArgs e)
        {
            new addSchdule().Show();       
            this.Hide();
        }

        private void empButt_Click(object sender, EventArgs e)
        {
            new empOption().Show();
            this.Hide();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void schdule_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void viewSch_Click(object sender, EventArgs e)
        {
            new viewSch().Show();
            this.Hide();
        }

        private void updSch_Click(object sender, EventArgs e)
        {
            new updateSch().Show();
            this.Hide();
        }

        private void delSch_Click(object sender, EventArgs e)
        {
            new delSch().Show();    
            this.Hide();
        }
    }
}

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
    public partial class empOption : Form
    {
        public empOption()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            new AddEmp().Show();
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

        private void viewEmp_Click(object sender, EventArgs e)
        {
            new viewEmp().Show();   
            this.Hide();
        }

        private void delEmp_Click(object sender, EventArgs e)
        {
            new delEmp().Show();    
            this.Hide();
        }

        private void empOption_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void updEmp_Click(object sender, EventArgs e)
        {
            new updateEmp().Show();
            this.Hide();
        }

        private void empButt_Click(object sender, EventArgs e)
        {

        }

        private void flightBtn_Click(object sender, EventArgs e)
        {
            new Flightdash().Show();
            this.Hide();
        }
    }
}

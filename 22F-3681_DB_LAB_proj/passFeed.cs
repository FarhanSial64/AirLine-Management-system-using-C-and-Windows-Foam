using Oracle.ManagedDataAccess.Client;
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
    public partial class passFeed : Form
    {
        OracleConnection conn;
        private string username;
        public passFeed(string username)
        {
            InitializeComponent();
            conn = Class1.GetConnection();
            this.username = username;
        }

        private void passFeed_Load(object sender, EventArgs e)
        {

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;


            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            passName.Text = username;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkProfile_Click(object sender, EventArgs e)
        {

        }

        private void addFeed_Click(object sender, EventArgs e)
        {
            addFeed addfeedback = new addFeed(username);
            addfeedback.Show();
            this.Hide();
        }

        private void viewFeed_Click(object sender, EventArgs e)
        {
            viewPassFeed viewpass = new viewPassFeed(username);
            viewpass.Show();
            this.Hide();
        }

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}

using Oracle.ManagedDataAccess.Client;
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
    public partial class passDash : Form
    {
        OracleConnection conn;
        private string username;

        public passDash(string username)
        {
            InitializeComponent();
            conn = Class1.GetConnection();
            this.username = username;
        }

        private void passDash_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;


            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;


            passName.Text = username;
        }

        private void passName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeedBtn_Click(object sender, EventArgs e)
        {
            passFeed passFeedback = new passFeed(username);
            passFeedback.Show();
            this.Hide();
        }

        private void bookSeat_Click(object sender, EventArgs e)
        {
            reserveSeat seat = new reserveSeat(username);
            seat.Show();
            this.Hide();
        }
    }
}

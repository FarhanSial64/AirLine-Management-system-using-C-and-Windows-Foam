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
    public partial class Login : Form
    {
        OracleConnection conn;


        public Login()  
        {
            InitializeComponent();
            conn = Class1.GetConnection();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            checkBox1.Parent = pictureBox1;
            checkBox1.BackColor = Color.Transparent;

            linkLabel1.Parent = pictureBox1;
            linkLabel1.BackColor = Color.Transparent;

            forgotPass.Parent = pictureBox1;
            forgotPass.BackColor = Color.Transparent;

            userPass.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        public static class AuthenticationHelper
        {
            public static bool AuthenticateUser(string username, string password)
            {
                // SQL query to authenticate user
                string query = "SELECT COUNT(*) FROM Users WHERE username = :username AND password = :password";

                using (OracleConnection connection = Class1.GetConnection())
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // If count > 0, authentication successful
                        return count > 0;
                    }
                }
            }
        }


        private void LoginBut_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = userPass.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Not all textboxes are filled", "Log In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (AuthenticationHelper.AuthenticateUser(username, password))
                {
                    // Authentication successful, open the role selection form
                    Role roleForm = new Role(username);
                    roleForm.Show();
                    this.Hide();
                }
                else
                {
                    // Authentication failed, show error message
                    MessageBox.Show("Invalid username or password", "Log In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                userPass.PasswordChar = '\0';
            }
            else
            {
                userPass.PasswordChar = '*';
            }
        }

        private void userPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Sign_up().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

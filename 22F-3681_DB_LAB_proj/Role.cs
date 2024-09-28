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
    public partial class Role : Form
    {
        OracleConnection conn;

        private string userEmail;

        public Role(string email)
        {
            InitializeComponent();
            conn = Class1.GetConnection();
            userEmail = email;
        }

        public Role()
        {
            InitializeComponent();
        }

        private void adminButt_Click(object sender, EventArgs e)
        {
            // Verify user role for admin access
            VerifyRoleAndGrantAccess(userEmail, "admin");
        }

        private void empButt_Click(object sender, EventArgs e)
        {
            // Verify user role for employee access
            VerifyRoleAndGrantAccess(userEmail, "employee");
        }

        private void passButt_Click(object sender, EventArgs e)
        {
            // Verify user role for passenger access
            VerifyRoleAndGrantAccess(userEmail, "passenger");
        }

        private void VerifyRoleAndGrantAccess(string username, string roleToVerify)
        {
            conn.Close();
            try
            {
                string query = "SELECT role FROM Users WHERE username = :username";

                using (OracleConnection connection = Class1.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            string role = Convert.ToString(result).ToLower();

                            if (role == roleToVerify)
                            {
                                // User has the specified role, grant access
                                switch (role)
                                {
                                    case "admin":
                                        new AdminDashBoard().Show();
                                        this.Hide();
                                        break;
                                    case "employee":
                                        new empDash().Show();
                                        this.Hide();
                                        break;
                                    case "passenger":
                                        passDash passengerDashboard = new passDash(userEmail);
                                        passengerDashboard.Show();
                                        this.Hide();
                                        break;
                                }
                            }
                            else
                            {
                                // User does not have the specified role
                                MessageBox.Show("You do not have access to this functionality.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // User not found or role not defined
                            MessageBox.Show("User not found or role not defined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while verifying user role: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

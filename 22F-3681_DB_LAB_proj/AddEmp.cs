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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _22F_3681_DB_LAB_proj
{
    public partial class AddEmp : Form
    {
        OracleConnection conn;
        public AddEmp()
        {
            InitializeComponent();
            conn = Class1.GetConnection();
        }

        private void AddEmp_Load(object sender, EventArgs e)
        {
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;

            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void backButt_Click(object sender, EventArgs e)
        {
            new AdminDashBoard().Show();
            this.Hide();
        }

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void role_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        private void saveEmp_Click(object sender, EventArgs e)
        {
            conn.Close();
            try
            {
                using (OracleConnection connection = Class1.GetConnection())
                {
                    // Start a transaction
                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insert into Employee table
                            string employeeQuery = @"INSERT INTO Employee (name, email, username, password, phoneNumber, role)
                                         VALUES (:name, :email, :username, :password, :phoneNumber, :role)";
                            using (OracleCommand employeeCommand = new OracleCommand(employeeQuery, connection))
                            {
                                employeeCommand.Parameters.Add(":name", OracleDbType.Varchar2).Value = Name.Text;
                                employeeCommand.Parameters.Add(":email", OracleDbType.Varchar2).Value = email.Text;
                                employeeCommand.Parameters.Add(":username", OracleDbType.Varchar2).Value = userName.Text;
                                employeeCommand.Parameters.Add(":password", OracleDbType.Varchar2).Value = password.Text;
                                employeeCommand.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = number.Text;
                                employeeCommand.Parameters.Add(":role", OracleDbType.Varchar2).Value = role.SelectedItem?.ToString();

                                int employeeRowsInserted = employeeCommand.ExecuteNonQuery();

                                // Insert into Users table
                                string userQuery = @"INSERT INTO Users (name, email, password, phone_number, role, username)
                                             VALUES (:name, :email, :password, :phoneNumber, :role, :username)";
                                using (OracleCommand userCommand = new OracleCommand(userQuery, connection))
                                {
                                    userCommand.Parameters.Add(":name", OracleDbType.Varchar2).Value = Name.Text;
                                    userCommand.Parameters.Add(":email", OracleDbType.Varchar2).Value = email.Text;
                                    userCommand.Parameters.Add(":username", OracleDbType.Varchar2).Value = userName.Text;
                                    userCommand.Parameters.Add(":password", OracleDbType.Varchar2).Value = password.Text;
                                    userCommand.Parameters.Add(":phone_number", OracleDbType.Varchar2).Value = number.Text;
                                    userCommand.Parameters.Add(":role", OracleDbType.Varchar2).Value = role.SelectedItem?.ToString();

                                    int userRowsInserted = userCommand.ExecuteNonQuery();

                                    // Commit the transaction if both inserts were successful
                                    if (employeeRowsInserted > 0 && userRowsInserted > 0)
                                    {
                                        transaction.Commit();
                                        MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ClearFormFields();
                                    }
                                    else
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("An error occurred while adding employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            Name.Text = "";
            email.Text = "";
            userName.Text = "";
            password.Text = "";
            number.Text = "";
            role.SelectedItem = null;
        }

        private void viewButt_Click(object sender, EventArgs e)
        {
            new empOption().Show();
            this.Hide();
        }

        private void delButt_Click(object sender, EventArgs e)
        {
            new delEmp().Show();
            this.Hide();
        }
    }
}

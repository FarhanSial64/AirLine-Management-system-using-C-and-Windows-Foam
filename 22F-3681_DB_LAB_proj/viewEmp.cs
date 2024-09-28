using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;




namespace _22F_3681_DB_LAB_proj
{
    public partial class viewEmp : Form
    {

        OracleConnection conn;

        public viewEmp()
        {
            InitializeComponent();

            conn = Class1.GetConnection();

        }

        private void viewEmp_Load(object sender, EventArgs e)
        {
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

            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;

            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;

            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;



            LoadEmployeeData();
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void LoadEmployeeData()
        {
            conn.Close();
            try
            {
                conn.Open();
                string query = "SELECT * FROM Employee";
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = selectedRow.Cells["id"].Value.ToString();
                name.Text = selectedRow.Cells["name"].Value.ToString();
                email.Text = selectedRow.Cells["email"].Value.ToString();
                username.Text = selectedRow.Cells["username"].Value.ToString();
                password.Text = selectedRow.Cells["password"].Value.ToString();
                number.Text = selectedRow.Cells["phoneNumber"].Value.ToString();
                role.Text = selectedRow.Cells["role"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            new empOption().Show();
            this .Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void role_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int id;
                // Check if the content of textBox1 can be parsed to an integer
                if (int.TryParse(textBox1.Text, out id))
                {
                    try
                    {
                        conn.Open();
                        // Query to select rows with the specified ID
                        string query = $"SELECT * FROM Employee WHERE id = {id}";
                        OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // Set the filtered DataTable as the DataSource of the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    // If parsing fails, show a message
                    MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If textBox1 is empty, load all data
                LoadEmployeeData();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            int id = int.Parse(textBox1.Text); // Assuming ID is an integer
            string name1 = name.Text;
            string email1 = email.Text;
            string username1 = username.Text;
            string password1 = password.Text;
            string phoneNumber1 = number.Text; // Adjusted variable name
            string role1 = role.Text;

            // Update the record in the database
            conn.Open();
            try
            {
                string query = "UPDATE Employee SET name = :name1, email = :email1, username = :username1, password = :password1, phonenumber = :phoneNumber1, role = :role1 WHERE id = :id";
                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name1;
                command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email1;
                command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username1;
                command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password1;
                command.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phoneNumber1; // Adjusted parameter name
                command.Parameters.Add(":role", OracleDbType.Varchar2).Value = role1;
                command.Parameters.Add(":id", OracleDbType.Int32).Value = id;

                int rowsUpdated = command.ExecuteNonQuery();
                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the data grid
                    LoadEmployeeData();

                    // Clear the text boxes
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Failed to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            name.Text = "";
            email.Text = "";
            username.Text = "";
            password.Text = "";
            number.Text = "";
            role.Text = "";
        }
    }
}

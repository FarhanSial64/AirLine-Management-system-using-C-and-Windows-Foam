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
    public partial class delEmp : Form
    {
        OracleConnection conn;

        public delEmp()
        {
            InitializeComponent();
            conn = Class1.GetConnection();
        }

        
        private void delEmp_Load(object sender, EventArgs e)
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void delBtn_Click(object sender, EventArgs e)
        {
            // Check if textBox1 is not empty
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int id;
                // Check if the content of textBox1 can be parsed to an integer
                if (int.TryParse(textBox1.Text, out id))
                {
                    try
                    {
                        // Open the connection
                        conn.Open();

                        // Create the SQL command for deleting the employee with the specified id
                        string query = "DELETE FROM Employee WHERE id = :id";
                        OracleCommand command = new OracleCommand(query, conn);
                        command.Parameters.Add(":id", OracleDbType.Int32).Value = id;

                        // Execute the command
                        int rowsDeleted = command.ExecuteNonQuery();

                        // Check if the deletion was successful
                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the text boxes
                            ClearTextBoxes();

                            // Refresh the data grid view
                            LoadEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete employee. No employee found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Close the connection
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
                // If textBox1 is empty, show a message
                MessageBox.Show("Please enter an ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            new empOption().Show();
            this.Close();
        }
    }
}

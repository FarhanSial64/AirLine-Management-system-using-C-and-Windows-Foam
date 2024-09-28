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
    public partial class delSch : Form
    {
        OracleConnection conn;
        public delSch()
        {
            InitializeComponent();
            conn = Class1.GetConnection();
        }

        private void delSch_Load(object sender, EventArgs e)
        {
            LoadScheduleData();
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void schId_TextChanged(object sender, EventArgs e)
        {

        }

        private void flightId_TextChanged(object sender, EventArgs e)
        {

        }

        private void sorceDrop_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void destdrop_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(schId.Text))
            {
                int id;
                // Check if the content of schId can be parsed to an integer
                if (int.TryParse(schId.Text, out id))
                {
                    try
                    {
                        conn.Open();
                        // Query to delete the row with the specified ID
                        string query = $"DELETE FROM schedule WHERE id = {id}";
                        OracleCommand command = new OracleCommand(query, conn);
                        int rowsDeleted = command.ExecuteNonQuery();
                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh the data grid
                            LoadScheduleData();
                            // Clear the text boxes
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record. No matching record found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    // If parsing fails, show a message
                    MessageBox.Show("Please enter a valid Schedule ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Schedule ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(schId.Text))
            {
                int id;
                // Check if the content of schId can be parsed to an integer
                if (int.TryParse(schId.Text, out id))
                {
                    try
                    {
                        conn.Open();
                        // Query to select rows with the specified ID
                        string query = $"SELECT * FROM schedule WHERE id = {id}";
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
                    MessageBox.Show("Please enter a valid Schedule ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If schId is empty, load all data
                LoadScheduleData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            new schdule1().Show();
            this.Hide();
        }

        private void ClearTextBoxes()
        {
            schId.Text = "";
            sorceDrop.SelectedItem = null;
            destdrop.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void LoadScheduleData()
        {
            conn.Close();
            try
            {
                conn.Open();

                // Prepare the SQL query to select all data from the schedule table
                string query = "SELECT * FROM schedule";

                // Create a data adapter to execute the query and fill a DataTable with the results
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView to display the data
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                schId.Text = selectedRow.Cells["id"].Value.ToString();
                flightId.Text = selectedRow.Cells["flight_id"].Value.ToString();
                string source = selectedRow.Cells["source"].Value.ToString();
                string destination = selectedRow.Cells["destination"].Value.ToString();
                // Set the selected source and destination in the dropdowns
                if (sorceDrop.Items.Contains(source))
                {
                    sorceDrop.SelectedItem = source;
                }
                if (destdrop.Items.Contains(destination))
                {
                    destdrop.SelectedItem = destination;
                }
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["flightdate"].Value);
            }
        }

    }
}

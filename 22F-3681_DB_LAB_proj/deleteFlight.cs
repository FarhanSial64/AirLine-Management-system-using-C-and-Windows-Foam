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
    
    public partial class deleteFlight : Form
    {
        OracleConnection conn;

        public deleteFlight()
        {
            InitializeComponent();
            conn = Class1.GetConnection();

        }

        private void flightId_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteFlight_Load(object sender, EventArgs e)
        {
            LoadFlightData();

            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void flightName_TextChanged(object sender, EventArgs e)
        {

        }

        private void seats_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Check if the flight ID textbox is not empty
            if (!string.IsNullOrEmpty(flightId.Text))
            {
                int id;
                // Check if the content of flightId can be parsed to an integer
                if (int.TryParse(flightId.Text, out id))
                {
                    try
                    {
                        // Open the database connection
                        conn.Open();
                        // Query to delete the row with the specified ID
                        string query = $"DELETE FROM Flight WHERE id = {id}";
                        OracleCommand cmd = new OracleCommand(query, conn);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Flight deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear the textboxes
                            ClearTextBoxes();
                            // Reload the flight data
                            LoadFlightData();
                        }
                        else
                        {
                            MessageBox.Show("Flight with the provided ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Close the database connection
                        conn.Close();
                    }
                }
                else
                {
                    // Show an error message if parsing fails
                    MessageBox.Show("Please enter a valid Flight ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Flight ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(flightId.Text))
            {
                // Check if the flight ID textbox is not empty
                int id;
                // Check if the content of flightId can be parsed to an integer
                if (int.TryParse(flightId.Text, out id))
                {
                    conn.Close();
                    try
                    {
                        // Open the database connection
                        conn.Open();
                        // Query to select rows with the specified ID
                        string query = $"SELECT * FROM Flight WHERE id = {id}";
                        OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // Set the filtered DataTable as the DataSource of the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        // Show an error message if an exception occurs
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Close the database connection
                        conn.Close();
                    }
                }
                else
                {
                    // Show an error message if parsing fails
                    MessageBox.Show("Please enter a valid Flight ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ClearTextBoxes();
                // If flightId is empty, load all data
                LoadFlightData();
            }
        }

        private void ClearTextBoxes()
        {
            flightId.Text = "";
            flightName.Text = "";
            seats.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadFlightData()
        {
            conn.Close();
            try
            {
                conn.Open();

                // SQL query to select all data from the Flight table
                string query = "SELECT id, name, noofseats FROM Flight ORDER BY ID ASC";

                using (OracleDataAdapter adapter = new OracleDataAdapter(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Set the DataTable as the DataSource of the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
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
            // Check if the double-clicked cell is in a valid row
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Extract the flight details from the selected row
                string flightId1 = Convert.ToString(selectedRow.Cells["id"].Value);
                string flightName1 = Convert.ToString(selectedRow.Cells["name"].Value);
                string noOfSeats1 = Convert.ToString(selectedRow.Cells["noofseats"].Value);

                // Display the flight details in the respective textboxes or fields
                flightId.Text = flightId1;
                flightName.Text = flightName1;
                seats.Text = noOfSeats1;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            new Flightdash().Show();
            this.Close();   
        }
    }
}

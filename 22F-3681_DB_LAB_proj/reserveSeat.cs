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
    public partial class reserveSeat : Form
    {
        OracleConnection conn;
        string username;
        public reserveSeat(string username)
        {
            InitializeComponent();
            conn = Class1.GetConnection();
            this.username = username;
        }

        private void reserveSeat_Load(object sender, EventArgs e)
        {
            LoadFlightData();
            passName.Text = username;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve flight ID, name, and available seats from the selected row
                int flightId1 = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string flightName1 = Convert.ToString(selectedRow.Cells["name"].Value);
                string availableSeats1 = Convert.ToString(selectedRow.Cells["noofseats"].Value);

                // Display the flight details in their respective fields
                flightId.Text = flightId1.ToString();
                flightName.Text = flightName1;
                available.Text = availableSeats1;

                // Update other relevant information if needed
                // For example:
                // UpdateAvailableSeats(flightId);
            }
        }



        private void flightId_TextChanged(object sender, EventArgs e)
        {

        }

        private void flightName_TextChanged(object sender, EventArgs e)
        {

        }

        private void seats_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(flightId.Text) && !string.IsNullOrEmpty(seats.Text))
            {
                int flightIdValue;
                if (int.TryParse(flightId.Text, out flightIdValue))
                {
                    int seatsToBook;
                    if (int.TryParse(seats.Text, out seatsToBook))
                    {
                        int availableSeats;
                        if (int.TryParse(available.Text, out availableSeats))
                        {
                            if (seatsToBook > 0 && seatsToBook <= availableSeats)
                            {
                                string passEmail = GetUserEmail(username);
                                if (!string.IsNullOrEmpty(passEmail))
                                {
                                    conn.Close();
                                    try
                                    {
                                        conn.Open();

                                        // Insert a new record into the SeatReservation table
                                        string insertQuery = $"INSERT INTO SeatReservation (bookid, passEmail, flightid, bookSeat) " +
                                                             $"VALUES (seatreservation_seq.NEXTVAL, '{passEmail}', {flightIdValue}, {seatsToBook})";
                                        using (OracleCommand command = new OracleCommand(insertQuery, conn))
                                        {
                                            command.ExecuteNonQuery();
                                        }

                                        // Update the number of available seats in the Flight table
                                        int updatedAvailableSeats = availableSeats - seatsToBook;
                                        string updateQuery = $"UPDATE Flight SET noofseats = {updatedAvailableSeats} WHERE id = {flightIdValue}";
                                        using (OracleCommand command = new OracleCommand(updateQuery, conn))
                                        {
                                            command.ExecuteNonQuery();
                                        }

                                        MessageBox.Show("Seats booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                    MessageBox.Show("Passenger email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid number of seats to book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid available seats value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number of seats to book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid flight ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Flight ID and seats fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GetUserEmail(string username)
        {
            string email = null;
            try
            {
                conn.Open();
                string query = $"SELECT email FROM Users WHERE username = '{username}'";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        email = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving user email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return email;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void passName_TextChanged(object sender, EventArgs e)
        {

        }

        private void available_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadFlightData()
        {
            conn.Close();
            try
            {
                conn.Open();

                // SQL query to select all data from the Flight table
                string query = "SELECT * FROM Flight";

                using (OracleDataAdapter adapter = new OracleDataAdapter(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Set the DataTable as the DataSource of the DataGridView
                    dataGridView1.DataSource = dataTable;
                }

                // Select the first flight by default
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                    DataGridViewRow selectedRow = dataGridView1.Rows[0];
                    UpdateAvailableSeats(Convert.ToInt32(selectedRow.Cells["id"].Value));
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
        private void UpdateAvailableSeats(int flightId)
        {
            conn.Close();
            try
            {
                conn.Open();

                // SQL query to get available seats for the selected flight
                string query = $"SELECT noofseats FROM Flight WHERE id = {flightId}";
                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        available.Text = result.ToString();
                    }
                    else
                    {
                        available.Text = "N/A";
                    }
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
                        using (OracleDataAdapter adapter = new OracleDataAdapter(query, conn))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            // Set the filtered DataTable as the DataSource of the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                        // Update available seats information for the selected flight
                        UpdateAvailableSeats(id);
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
                // If flightId is empty, load all data
                LoadFlightData();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            new passDash(username).Show();
            this.Close();
        }
    }
}

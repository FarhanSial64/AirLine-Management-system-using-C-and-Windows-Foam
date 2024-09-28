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
    public partial class viewPassFeed : Form
    {
        OracleConnection conn;
        string username;
        public viewPassFeed(string username)
        {
            InitializeComponent();
            conn = Class1.GetConnection();
            this.username = username;

        }

        private void viewPassFeed_Load(object sender, EventArgs e)
        {
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;

            LoadFeedbackData(username);
            passName.Text = username;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            new passFeed(username).Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadFeedbackData(string username)
        {
            conn.Close();
            try
            {
                string userEmailQuery = "SELECT email FROM Users WHERE username = :username";

                using (OracleCommand cmd = new OracleCommand(userEmailQuery, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                    string userEmail = Convert.ToString(cmd.ExecuteScalar());
                    conn.Close();

                    string feedbackQuery = "SELECT id, useremail, feedback, rating FROM Feedback WHERE useremail = :userEmail ORDER BY id ASC";

                    using (OracleDataAdapter adapter = new OracleDataAdapter(feedbackQuery, conn))
                    {
                        conn.Open();
                        adapter.SelectCommand.Parameters.Add(":userEmail", OracleDbType.Varchar2).Value = userEmail;
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Feedback");

                        dataGridView1.DataSource = dataSet.Tables["Feedback"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading feedback data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected feedback entry
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                string feedbackText = Convert.ToString(selectedRow.Cells["feedback"].Value);
                feedback.Text = feedbackText;

                string ratingValue = Convert.ToString(selectedRow.Cells["rating"].Value);
                // Assuming 'ratingComboBox' is the name of your ComboBox control
                rating.SelectedItem = ratingValue;

                // Extract and display the ID
                string idValue = Convert.ToString(selectedRow.Cells["id"].Value);
                Id.Text = idValue;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id.Text))
            {
                int id;
                // Check if the content of schId can be parsed to an integer
                if (int.TryParse(Id.Text, out id))
                {
                    conn.Close();
                    try
                    {
                        conn.Open();
                        // Query to select rows with the specified ID
                        string query = $"SELECT id, useremail, feedback, rating FROM Feedback WHERE id = {id} ORDER BY id ASC";
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
                    MessageBox.Show("Please enter a valid Feedback ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ClearContent();
                // If Id is empty, load all data
                LoadFeedbackData(username);
            }
        }

        private void ClearContent()
        {
            feedback.Clear();
            Id.Clear(); // Clear the TextBox content
            rating.SelectedIndex = -1; // Clear the ComboBox selection
        }

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Get the ID from the TextBox
            if (!string.IsNullOrEmpty(Id.Text))
            {
                int id;
                // Check if the content of Id can be parsed to an integer
                if (int.TryParse(Id.Text, out id))
                {
                    try
                    {
                        conn.Open();
                        // Update query
                        string query = $"UPDATE Feedback SET feedback = :feedback, rating = :rating WHERE id = :id";
                        using (OracleCommand command = new OracleCommand(query, conn))
                        {
                            // Add parameters
                            command.Parameters.Add(":feedback", OracleDbType.Varchar2).Value = feedback.Text;
                            command.Parameters.Add(":rating", OracleDbType.Varchar2).Value = rating.SelectedItem.ToString();
                            command.Parameters.Add(":id", OracleDbType.Int32).Value = id;

                            // Execute the update query
                            int rowsUpdated = command.ExecuteNonQuery();

                            if (rowsUpdated > 0)
                            {
                                MessageBox.Show("Feedback updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Refresh the DataGridView to reflect the changes
                                LoadFeedbackData(username);
                                ClearContent();
                            }
                            else
                            {
                                MessageBox.Show("No rows updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    // If parsing fails, show a message
                    MessageBox.Show("Please enter a valid Feedback ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Feedback ID to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

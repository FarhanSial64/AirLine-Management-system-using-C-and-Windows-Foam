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
    public partial class addFlight : Form
    {
        OracleConnection conn;
        public addFlight()
        {
            InitializeComponent();
            conn = Class1.GetConnection();
        }

        private void addFlight_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            new Flightdash().Show();
            this.Hide();
        }

        private void flightName_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalSeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string flightNameValue = flightName.Text;
            int totalSeatsValue;

            // Check if the total seats value can be parsed to an integer
            if (!int.TryParse(totalSeats.Text, out totalSeatsValue))
            {
                MessageBox.Show("Please enter a valid number for total seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            conn.Close();
            try
            {
                conn.Open();

                // SQL query to insert data into the Flight table
                string query = $"INSERT INTO Flight (name, noofseats) VALUES ('{flightNameValue}', {totalSeatsValue})";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    int rowsInserted = cmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Flight information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear input fields after successful insertion
                        flightName.Clear();
                        totalSeats.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save flight information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

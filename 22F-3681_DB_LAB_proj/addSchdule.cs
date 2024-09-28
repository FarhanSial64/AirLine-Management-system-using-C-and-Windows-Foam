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
    public partial class addSchdule : Form
    {
        OracleConnection conn;

        public addSchdule()
        {
            InitializeComponent();
            conn = Class1.GetConnection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void destination_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void addSchdule_Load(object sender, EventArgs e)
        {

        }

        private void flightId_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            conn.Close();
            try
            {
                conn.Open();

                // Extract the day name from the selected date
                string dayName = dateTimePicker1.Value.ToString("dddd");

                
               

                // Prepare the INSERT query
                string query = "INSERT INTO schedule (flight_id, source, destination, flightdate, dayname) " +
                               "VALUES (:flight_id, :source, :destination, :flightdate, :dayname)";

                // Create and configure OracleCommand
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    // Add parameters with values from form controls
                    cmd.Parameters.Add(":flight_id", OracleDbType.Int32).Value = Convert.ToInt32(flightId.Text);
                    cmd.Parameters.Add(":source", OracleDbType.Varchar2).Value = domainUpDown1.SelectedItem?.ToString();
                    cmd.Parameters.Add(":destination", OracleDbType.Varchar2).Value = destination.SelectedItem?.ToString(); ;
                    cmd.Parameters.Add(":flightdate", OracleDbType.Date).Value = dateTimePicker1.Value.Date;
                    cmd.Parameters.Add(":dayname", OracleDbType.Varchar2).Value = dayName;

                    // Execute the INSERT query
                    int rowsInserted = cmd.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Schedule added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void back_Click(object sender, EventArgs e)
        {
            new schdule1().Show();
            this.Hide();
        }
    }
}

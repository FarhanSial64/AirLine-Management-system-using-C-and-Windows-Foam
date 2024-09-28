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
    public partial class addFeed : Form
    {

        OracleConnection conn;
        string username;
        public addFeed(string username)
        {
            InitializeComponent();
            conn = Class1.GetConnection();
            this.username = username;
        }

        private void addFeed_Load(object sender, EventArgs e)
        {
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            passName.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEmail = GetUserEmail(username);

            if (userEmail != null)
            {
                // Insert the feedback and rating into the database
                InsertFeedback(userEmail, feedback.Text, Convert.ToInt32(rating.SelectedItem));
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string GetUserEmail(string username)
        {
            conn.Close();
            try
            {
                string query = "SELECT email FROM Users WHERE username = :username";

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToString(result);
                    }
                    else
                    {
                        return null; // User not found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching user email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        private void InsertFeedback(string userEmail, string feedbackText, int ratingValue)
        {
            try
            {
                string query = "INSERT INTO Feedback (useremail, feedback, rating) VALUES (:useremail, :feedback, :rating)";

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.Add(":useremail", OracleDbType.Varchar2).Value = userEmail;
                    command.Parameters.Add(":feedback", OracleDbType.Varchar2).Value = feedbackText;
                    command.Parameters.Add(":rating", OracleDbType.Int32).Value = ratingValue;

                    int rowsInserted = command.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Feedback submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void LogOutButt_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void checkProfile_Click(object sender, EventArgs e)
        {

        }

        private void rating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void feedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            new passFeed(username).Show();
            this.Hide();
        }
    }
}

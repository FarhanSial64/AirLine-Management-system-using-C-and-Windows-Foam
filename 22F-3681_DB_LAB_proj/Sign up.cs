using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace _22F_3681_DB_LAB_proj
{
    public partial class Sign_up : Form
    {

        OracleConnection conn;
        public Sign_up()
        {
            InitializeComponent();
            conn = Class1.GetConnection();
        }

        private int GenerateOTP()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999); // Generate a random 6-digit OTP
        }

        private void SendOTP(string userEmail, int otp)
        {
            // Configure SMTP client (for Gmail)
            SmtpClient smtpClient = new SmtpClient("f223681@cfd.nu.edu.pk");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("Your Email", "yourpassword");
            smtpClient.EnableSsl = true;

            // Create the email message
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(email.Text, name.Text);
            mailMessage.To.Add(userEmail);
            mailMessage.Subject = "Verification Code for Sign Up";
            mailMessage.Body = $"Your verification code is: {otp}";

            // Send the email
            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending the verification email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Sign_up_Load(object sender, EventArgs e)
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

            label9.Parent = pictureBox1;
            label9.BackColor = Color.Transparent;

            linkLabel1.Parent = pictureBox1;
            linkLabel1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            int otp = GenerateOTP(); // Generate OTP
            SendOTP(email.Text, otp); // Send OTP to user's email

            // Prompt the user to enter the OTP
            string inputOTP = Microsoft.VisualBasic.Interaction.InputBox("Enter the OTP sent to your email:", "Enter OTP", "");

            // Verify OTP
            if (inputOTP == otp.ToString())
            {
                // OTP verification successful, proceed with user registration
                RegisterUser();
                new Login().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Role_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }



        private void RegisterUser()
        {
            try
            {
                using (OracleConnection connection = Class1.GetConnection())
                {
                    string query = @"INSERT INTO Users (name, email, password, phone_number, cnic, address, role, username)
                                     VALUES (:name, :email, :password, :phone_number, :cnic, :address, :role, :username)";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // Set parameter values
                        command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name.Text;
                        command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email.Text;
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password.Text;
                        command.Parameters.Add(":phone_number", OracleDbType.Varchar2).Value = number.Text;
                        command.Parameters.Add(":cnic", OracleDbType.Varchar2).Value = cnic.Text;
                        command.Parameters.Add(":address", OracleDbType.Varchar2).Value = address.Text;
                        command.Parameters.Add(":role", OracleDbType.Varchar2).Value = Role.SelectedItem.ToString();
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = userName.Text;

                        // Execute the query
                        int rowsInserted = command.ExecuteNonQuery();

                        // Check if insertion was successful
                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optionally, you can clear the form fields here
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while registering user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}

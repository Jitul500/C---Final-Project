using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AiubLink
{
    public partial class ForgetPage : Form
    {
        string otpCode;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CSharp FinalProject\AiubLink\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

        public ForgetPage()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string newPass = textBoxNewpass.Text.Trim();
            string confirmPass = textBoxConfirmPass.Text.Trim();
            string userId = idtext.Text.Trim();

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Password fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the password in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE AiubLink SET Password = @Password WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", newPass);
                        command.Parameters.AddWithValue("@UserID", userId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogIn logIn = new LogIn();
                            logIn.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error: No account found with the provided UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSendCode_Click(object sender, EventArgs e)
        {
            string userId = idtext.Text.Trim();
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter your UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve email associated with the UserID
            string email = GetEmailByUserID(userId);
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("No account found with the provided UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate OTP
            verifypanel.Visible = true;
            Random rnd = new Random();
            otpCode = rnd.Next(100000, 99999999).ToString();
            string message = "Your OTP Verification Code Is: " + otpCode + "\n";

            // Set up SMTP client to send email
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "student.ai.aiub@gmail.com",
                    Password = "cpmrtbkcnnsxuoqx"
                }
            };

            MailAddress FromEmail = new MailAddress("student.aiub.ai@gmail.com", "Admin");
            MailAddress ToEmail = new MailAddress(email, "Receiver");

            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Verification Code For Reset Password",
                Body = message + "You Don't Need To Reply To This Mail..."
            };
            Message.To.Add(ToEmail);

            // Send email and handle exceptions
            try
            {
                Client.Send(Message);
                MessageBox.Show("OTP has been sent successfully to " + ToEmail.Address, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful. There was a problem:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ForgetPage_Load(object sender, EventArgs e)
        {
            verifypanel.Visible = false;
            resetpanel.Visible = false;
            buttonSubmit.Visible = false;
        }

        private string GetEmailByUserID(string userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Email FROM AiubLink WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            return reader["Email"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null;
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (codetext.Text == otpCode)
            {
                resetpanel.Visible = true;
                buttonSubmit.Visible = true;

                MessageBox.Show("Email Verification Is Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"UnSuccessful,You Have Inputted Wrong OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class RegistrationPage : Form
    {

        string otpCode;

        public RegistrationPage()
        {
            InitializeComponent();
        }

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rezau\OneDrive\Documents\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

        private void backbutton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (studentcheckBox.Checked) 
            {
                
                faccheckBox.Checked = false;
                studentpanel.Visible = true;
                sendcodepanel.Visible = false;
                stlabel.Visible = true;
                 
            }
            else
            {
                
                studentpanel.Visible = false;
                stlabel.Visible= false;
                
            }
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {
            studentpanel.Visible = false;
            stlabel.Visible = false;
            faclabel.Visible = false;
            sendcodepanel.Visible = false;
            submitbutton.Visible = false;
        }

      
        private void faccheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (faccheckBox.Checked)
            {
                studentcheckBox.Checked = false;
                sendcodepanel.Visible = false;
                faclabel.Visible = true;
                studentpanel.Visible = true;
            }
           
            else
            {
                studentpanel.Visible = false;
                faclabel.Visible = false;  
            }
        }

        private void PIClabel_Click(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect user input from form controls
                string name = nametextBox.Text.Trim();
                int phone = int.Parse(phonetextBox.Text.Trim());
                string userID = idtextBox.Text.Trim();
                string email = emailtextBox.Text.Trim();
                DateTime dob = dateTimePicker1.Value;
                string password = passtextBox.Text.Trim();
                byte[] photo = GetPhotoData(); // Retrieve photo data from PictureBox

                // Create UserInfo object
                UserInfo newUser = new UserInfo(name, phone, userID, email, photo, dob, password);

                // Insert user into database
                InsertUserIntoDatabase(newUser);

                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form after successful registration
                ClearForm();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid input format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] GetPhotoData()
        {
            // Convert photo from PictureBox into a byte array
            if (pictureBox1.Image != null)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            return null;
        }


        private void InsertUserIntoDatabase(UserInfo user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO AiubLink (Name, Phone, UserID, Email, Photo, DOB, Password) " +
                               "VALUES (@Name, @Phone, @UserID, @Email, @Photo, @DOB, @Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@Phone", user.Phone);
                    command.Parameters.AddWithValue("@UserID", user.UserID);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = user.Photo ?? (object)DBNull.Value;
                    command.Parameters.AddWithValue("@DOB", user.DOB);
                    command.Parameters.AddWithValue("@Password", user.Password);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void ClearForm()
        {
            // Clear all input fields
            nametextBox.Clear();
            phonetextBox.Clear();
            idtextBox.Clear();
            emailtextBox.Clear();
            passtextBox.Clear();
            pictureBox1.Image = null;
            studentcheckBox.Checked = false;
            faccheckBox.Checked = false;
        }


        private void submitbutton_Enter(object sender, EventArgs e)
        {
            
        }

        private void submitbutton_MouseEnter(object sender, EventArgs e)
        {
            submitbutton.BackColor = SystemColors.MenuHighlight;
            submitbutton.ForeColor = SystemColors.MenuText;
        }

        private void submitbutton_MouseLeave(object sender, EventArgs e)
        {
            submitbutton.BackColor = SystemColors.HotTrack;
            submitbutton.ForeColor = SystemColors.ButtonHighlight;
        }

        private void uploadbutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Photo";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    // Optional: You can also store the file path if needed
                    string selectedFilePath = openFileDialog.FileName;
                }
            }
        }

        private void sendcodebutton_Click(object sender, EventArgs e)
        {
            sendcodepanel.Visible = true;
            Random rnd = new Random();
            otpCode = Convert.ToString(rnd.Next(100000, 999999999));
            string message = "Your OTP Verification Code Is : " + otpCode + "\n";

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
            MailAddress ToEmail = new MailAddress(emailtextBox.Text, "Receiver");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Account Verification Code",
                Body = message + "You Don't Need To Reply To This Mail...",
            };
            Message.To.Add(ToEmail);

            try
            {
                Client.Send(Message);
                MessageBox.Show("Email is Sent Successfully...", "Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show("UnSuccessful,There is a problem Somewhere\n" + ex.Message, "Error");
            }

        }

        private void verifybutton_Click(object sender, EventArgs e)
        {
           
                if (verifytextBox.Text == otpCode)
                {
                    submitbutton.Visible = true;
                    MessageBox.Show("Email Verification Is Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                  MessageBox.Show($"UnSuccessful,You Have Inputted Wrong OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
           
            
                
            
        }
    }

        
}


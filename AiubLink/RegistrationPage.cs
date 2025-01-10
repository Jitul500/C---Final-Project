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

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CSharp FinalProject\AiubLink\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

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
            // Validate that all required fields are filled
            if (string.IsNullOrWhiteSpace(nametextBox.Text) ||
                string.IsNullOrWhiteSpace(phonetextBox.Text) ||
                string.IsNullOrWhiteSpace(idtextBox.Text) ||
                string.IsNullOrWhiteSpace(emailtextBox.Text) ||
                pictureBox1.Image == null ||
                string.IsNullOrWhiteSpace(passtextBox.Text) ||
                string.IsNullOrWhiteSpace(confirmpasstextBox.Text))
            {
                MessageBox.Show("Please fill all the fields and upload a photo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Name (must be alphabets and spaces only)
            if (!System.Text.RegularExpressions.Regex.IsMatch(nametextBox.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Name can only contain alphabets and spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Phone Number (must be 11 digits)
            if (!int.TryParse(phonetextBox.Text, out _) || phonetextBox.Text.Length != 11)
            {
                MessageBox.Show("Phone number must be interger and contains exactly 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate User ID
            if (studentcheckBox.Checked)
            {
                // Student ID must follow the format **-*****-*
                if (!System.Text.RegularExpressions.Regex.IsMatch(idtextBox.Text, @"^\d{2}-\d{5}-\d$"))
                {
                    MessageBox.Show("Student ID must follow the format **-*****-*.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (faccheckBox.Checked)
            {
                // Faculty ID must follow the format ***-****-**
                if (!System.Text.RegularExpressions.Regex.IsMatch(idtextBox.Text, @"^\d{3}-\d{4}-\d{2}$"))
                {
                    MessageBox.Show("Faculty ID must follow the format ***-****-**.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validate Email (must end with @gmail.com)
            if (!emailtextBox.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email must end with '@gmail.com'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Date of Birth (must be year 2002 or earlier)
            if (dateTimePicker1.Value.Year > 2002)
            {
                MessageBox.Show("Date of Birth must be the year 2002 or earlier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Password (must match confirm password)
            if (passtextBox.Text != confirmpasstextBox.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If all validations pass, proceed with the registration process
            try
            {
                // Collect user input
                string name = nametextBox.Text.Trim();
                int phone = int.Parse(phonetextBox.Text.Trim());
                string userID = idtextBox.Text.Trim();
                string email = emailtextBox.Text.Trim();
                DateTime dob = dateTimePicker1.Value;
                string password = passtextBox.Text.Trim();
                byte[] photo = GetPhotoData(); // Retrieve photo data from PictureBox
                string role;
                if (studentcheckBox.Checked)
                {
                    role = "Student";
                }
                else
                {
                    role = "Faculty";
                }
                // Create UserInfo object
                UserInfo newUser = new UserInfo(name, phone, userID, email, photo, dob, password,role);

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

            // Reset visibility of checkboxes
            faccheckBox.Visible = true;
            studentcheckBox.Visible = true;
            submitbutton.Visible = false;
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

                string query = "INSERT INTO AiubLink (Name, Phone, UserID, Email, Photo, DOB, Password, Role) " +
                               "VALUES (@Name, @Phone, @UserID, @Email, @Photo, @DOB, @Password, @Role)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@Phone", user.Phone);
                    command.Parameters.AddWithValue("@UserID", user.UserID);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = user.Photo ?? (object)DBNull.Value;
                    command.Parameters.AddWithValue("@DOB", user.DOB);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role);

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
            otpCode = rnd.Next(100000, 99999999).ToString();
            string message = "Your OTP Verification Code Is: " + otpCode + "\n";
         
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
            MailAddress ToEmail;
            
            if (studentcheckBox.Checked)
            {
                ToEmail = new MailAddress(emailtextBox.Text, "Receiver");
                faccheckBox.Visible = false;
            }
            else if (faccheckBox.Checked)
            {
                ToEmail = new MailAddress("shahariarjitul1@gmail.com", "Receiver");
                studentcheckBox.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select either Student or Faculty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Account Verification Code",
                Body = message + "You Don't Need To Reply To This Mail..."
            };
            Message.To.Add(ToEmail);

            
            try
            {
                if (studentcheckBox.Checked)
                {

                    Client.Send(Message);
                    MessageBox.Show("OTP has been sent successfully to " + ToEmail.Address, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Client.Send(Message);
                    MessageBox.Show("OTP has been sent successfully to Admin's Email" , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful. There was a problem:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


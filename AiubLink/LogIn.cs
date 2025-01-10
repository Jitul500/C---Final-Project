using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void signintext_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgetPage forgetPage = new ForgetPage();
            forgetPage.Show();
            this.Hide();
        }


        private void clearbutton_Click(object sender, EventArgs e)
        {
            idtextbox.Clear();
            idtextbox.Text = "Enter Your ID";
            passtextbox.Clear();
            passtextbox.Text = "Enter Your Password";
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createaccountbutton_Click(object sender, EventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passtextbox.UseSystemPasswordChar = true;
            }

        }

        private void passtextbox_Leave_1(object sender, EventArgs e)
        {
            if (passtextbox.Text == "")
            {
                passtextbox.Text = "Enter Your Password";
                passtextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void passtextbox_Enter_1(object sender, EventArgs e)
        {
            if (passtextbox.Text == "Enter Your Password")
            {
                passtextbox.Text = "";
                passtextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void idtextbox_Enter_1(object sender, EventArgs e)
        {
            if (idtextbox.Text == "Enter Your ID")
            {
                idtextbox.Text = "";
                idtextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void idtextbox_Leave_1(object sender, EventArgs e)
        {
            if (idtextbox.Text == "")
            {
                idtextbox.Text = "Enter Your ID";
                idtextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (idtextbox.Text == "Enter Your ID" || string.IsNullOrWhiteSpace(idtextbox.Text))
            {
                MessageBox.Show("Please enter your ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passtextbox.Text == "Enter Your Password" || string.IsNullOrWhiteSpace(passtextbox.Text))
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CSharp FinalProject\AiubLink\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

            // SQL query to check if UserID and Password match
            string query = "SELECT Role FROM AiubLink WHERE UserID = @UserID AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", idtextbox.Text.Trim());
                        command.Parameters.AddWithValue("@Password", passtextbox.Text.Trim());

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // Retrieve the role from the database
                            string role = result.ToString();

                            // Redirect to the respective page based on the role
                            if (role == "Student")
                            {
                                StudentMainPage studentMainPage = new StudentMainPage();
                                studentMainPage.Show();
                                this.Hide();
                            }
                            else if (role == "Faculty")
                            {
                                FacultyMainPage facultyMainPage = new FacultyMainPage();
                                facultyMainPage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid role found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid UserID or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

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
    public partial class StudentMainPage : Form
    {
        private string studentUserID;
        public StudentMainPage(string userID)
        {
            InitializeComponent();
            studentUserID = userID;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        public void calenderbutton_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm(this);
            calendarForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Regbutton_Click(object sender, EventArgs e)
        {

        }

        private void INFObutton_Click(object sender, EventArgs e)
        {
            infopanel.Visible = true;
        }

        private void StudentMainPage_Load(object sender, EventArgs e)
        {
            LoadStudentDetails();
            infopanel.Visible = true;
        }

        private void LoadStudentDetails()
        {
            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

            // Query to fetch student details
            string query = "SELECT Name, Phone, UserID, Email, DOB, Photo FROM AiubLink WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", studentUserID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate labels with student details
                                namelabel.Text = reader["Name"].ToString();
                                phonelabel.Text = reader["Phone"].ToString();
                                studentidlabel.Text = reader["UserID"].ToString();
                                emaillabel.Text = reader["Email"].ToString();
                                doblabel.Text = Convert.ToDateTime(reader["DOB"]).ToString("dd/MM/yyyy");

                                // Load and display photo if available
                                if (reader["Photo"] != DBNull.Value)
                                {
                                    byte[] photoBytes = (byte[])reader["Photo"];
                                    using (var ms = new System.IO.MemoryStream(photoBytes))
                                    {
                                        profilepictureBox.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    profilepictureBox.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Failed to load student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Channelbutton_Click(object sender, EventArgs e)
        {
            channels channels = new channels(this, studentUserID, "Student");
            channels.Show();
            this.Hide();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void profilepictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

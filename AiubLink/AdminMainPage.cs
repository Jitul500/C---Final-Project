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
    public partial class AdminMainPage : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            UpdateCounts();

        }

        private void UpdateCounts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to count students
                    string studentQuery = "SELECT COUNT(*) FROM AiubLink WHERE Role = 'Student'";
                    using (SqlCommand studentCommand = new SqlCommand(studentQuery, connection))
                    {
                        int studentCount = (int)studentCommand.ExecuteScalar();
                        stnumlabel.Text = studentCount.ToString(); // Set the count to the label
                    }

                    // Query to count faculties
                    string facultyQuery = "SELECT COUNT(*) FROM AiubLink WHERE Role = 'Faculty'";
                    using (SqlCommand facultyCommand = new SqlCommand(facultyQuery, connection))
                    {
                        int facultyCount = (int)facultyCommand.ExecuteScalar();
                        facnumlabel.Text = facultyCount.ToString(); // Set the count to the label
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching counts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdStudentB_Click(object sender, EventArgs e)
        {
            InfoDashBoard infoDashBoard = new InfoDashBoard("Student");
            infoDashBoard.Show();
        }

        private void AdTeacherB_Click(object sender, EventArgs e)
        {
            InfoDashBoard infoDashBoard = new InfoDashBoard("Faculty");
            infoDashBoard.Show();

        }

        private void AdADDchannelB_Click(object sender, EventArgs e)
        {
            
            AddChannelDashBoard addChannelDashBoard = new AddChannelDashBoard();
            addChannelDashBoard.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}

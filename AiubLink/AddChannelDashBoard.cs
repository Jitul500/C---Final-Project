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
    public partial class AddChannelDashBoard : Form
    {
        public AddChannelDashBoard()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            AdminMainPage adminMainPage = new AdminMainPage();
            adminMainPage.Show();
            this.Hide();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            string channelName = ChannelnametextBox.Text.Trim();

            if (string.IsNullOrEmpty(channelName))
            {
                MessageBox.Show("Please enter a channel name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FacultycomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a faculty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StudentCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string facultyID = FacultycomboBox.SelectedItem.ToString();
            List<string> selectedStudents = new List<string>();

            foreach (var item in StudentCheckedListBox.CheckedItems)
            {
                selectedStudents.Add(item.ToString());
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insert channel into the Channels table
                    string insertChannelQuery = "INSERT INTO Channels (ChannelName, FacultyID) OUTPUT INSERTED.ChannelID VALUES (@ChannelName, @FacultyID)";
                    int channelId;

                    using (SqlCommand command = new SqlCommand(insertChannelQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", channelName);
                        command.Parameters.AddWithValue("@FacultyID", facultyID);

                        channelId = (int)command.ExecuteScalar();
                    }

                    // Insert students into the ChannelStudents table
                    string insertStudentsQuery = "INSERT INTO ChannelStudents (ChannelID, StudentID) VALUES (@ChannelID, @StudentID)";

                    foreach (string studentID in selectedStudents)
                    {
                        using (SqlCommand command = new SqlCommand(insertStudentsQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ChannelID", channelId);
                            command.Parameters.AddWithValue("@StudentID", studentID);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Channel created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset the form
                    ChannelnametextBox.Clear();
                    FacultycomboBox.SelectedIndex = -1;
                    for (int i = 0; i < StudentCheckedListBox.Items.Count; i++)
                    {
                        StudentCheckedListBox.SetItemChecked(i, false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating channel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void channelpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddChannelDashBoard_Load(object sender, EventArgs e)
        {
            LoadStudentCheckedListBox();
            LoadFacultyComboBox();
            LoadChannelData();
        }

        private void LoadStudentCheckedListBox()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
            string query = "SELECT UserID FROM AiubLink WHERE Role = 'Student'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StudentCheckedListBox.Items.Add(reader["UserID"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadChannelData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
            string query = @"
        SELECT 
            Channels.ChannelID,
            Channels.ChannelName,
            Channels.FacultyID,
            ChannelStudents.StudentID
        FROM 
            Channels
        INNER JOIN 
            ChannelStudents
        ON 
            Channels.ChannelID = ChannelStudents.ChannelID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        ChanneldataGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading channel data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadFacultyComboBox()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
            string query = "SELECT UserID FROM AiubLink WHERE Role = 'Faculty'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FacultycomboBox.Items.Add(reader["UserID"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading faculties: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadChannelData();
        }
    }
}

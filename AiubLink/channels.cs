using GoogleMeetApp;
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
    public partial class channels : Form
    {
        private Form previousForm;
        private string userID;
        private string role;
        public channels(Form previousForm, string userID, string role)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.userID = userID;
            this.role = role;

            LoadChannels();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {

            previousForm.Show();
            this.Close();

        }

        private void Meetingbutton_Click(object sender, EventArgs e)
        {
            VideoConf videoConf = new VideoConf(this);
            videoConf.Show();
            this.Hide();
        }


        private void LoadChannels()
        {
            // Database connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

            string query;

            // Check the role and build the appropriate query
            if (role == "Student")
            {
                query = @"
            SELECT c.ChannelName 
            FROM Channels c
            INNER JOIN ChannelStudents cs ON c.ChannelID = cs.ChannelID
            WHERE cs.StudentID = @UserID";
            }
            else if (role == "Faculty")
            {
                query = @"
            SELECT ChannelName 
            FROM Channels 
            WHERE FacultyID = @UserID";
            }
            else
            {
                MessageBox.Show("Invalid role. Unable to load channels.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add channel names to the checkedListBox
                                checkedListBox.Items.Add(reader["ChannelName"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading channels: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Subscribe to the ItemCheck event for single selection
            checkedListBox.ItemCheck += checkedListBox_ItemCheck;
        }

        private void Assigmentbutton_Click(object sender, EventArgs e)
        {
            if (checkedListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a channel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedChannel = checkedListBox.SelectedItem.ToString();

            if (role == "Faculty")
            {
                // Open the AssignmentRetrive form for faculty
                AssignmentRetrive assignmentRetriveForm = new AssignmentRetrive(this);
                assignmentRetriveForm.Show();
                this.Hide();
            }
            else if (role == "Student")
            {
                // Check if there's an active assignment for the selected channel
                if (HasActiveAssignment(selectedChannel))
                {
                    // Open the AssignmentUpload form for students
                    AssignmentUpload assignmentUploadForm = new AssignmentUpload(this);
                    assignmentUploadForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No active assignment for this channel.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool HasActiveAssignment(string channelName)
        {
            bool hasAssignment = false;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

            string query = @"
        SELECT COUNT(*) 
        FROM Assignments 
        INNER JOIN Channels ON Assignments.ChannelID = Channels.ChannelID
        WHERE Channels.ChannelName = @ChannelName AND Assignments.IsActive = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", channelName);

                        int count = (int)command.ExecuteScalar();
                        hasAssignment = count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while checking for active assignments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return hasAssignment;
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Uncheck all other items if a new one is checked
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (i != e.Index) // Leave the current item as is (checked/unchecked)
                {
                    checkedListBox.SetItemChecked(i, false);
                }
            }
        }
    }
}

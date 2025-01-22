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
            VideoConference videoConf = new VideoConference(this);
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
        }
    }
}

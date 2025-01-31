using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class AssignmentRetrive : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private Form previousForm;

        public AssignmentRetrive(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void AssignmentRetrive_Load(object sender, EventArgs e)
        {
            LoadChannels();
        }

        private void LoadChannels()
        {
            string query = "SELECT ChannelName FROM Channels";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ChannelComboBox.Items.Clear();
                            while (reader.Read())
                            {
                                ChannelComboBox.Items.Add(reader["ChannelName"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading channels: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateAssignmentButton_Click(object sender, EventArgs e)
        {
            if (ChannelComboBox.SelectedItem == null || string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                MessageBox.Show("Please select a channel and provide a description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedChannel = ChannelComboBox.SelectedItem.ToString();
            string description = DescriptionTextBox.Text;

            string query = "INSERT INTO Assignments (ChannelID, Description, IsActive) VALUES ((SELECT ChannelID FROM Channels WHERE ChannelName = @ChannelName), @Description, 1)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", selectedChannel);
                        command.Parameters.AddWithValue("@Description", description);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Assignment created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAssignments(selectedChannel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating assignment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadAssignments(string channelName)
        {
            string query = "SELECT AssignmentID, Description FROM Assignments WHERE ChannelID = (SELECT ChannelID FROM Channels WHERE ChannelName = @ChannelName) AND IsActive = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", channelName);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            AssignmentsDataGridView.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assignments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSubmissions(string channelName)
        {
            string query = @"
                SELECT s.UserID, u.UserName, s.FilePath 
                FROM Submissions s 
                INNER JOIN Users u ON s.UserID = u.UserID 
                WHERE s.ChannelID = (SELECT ChannelID FROM Channels WHERE ChannelName = @ChannelName)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", channelName);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            SubmissionsDataGridView.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading submissions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChannelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedChannel = ChannelComboBox.SelectedItem.ToString();
            LoadAssignments(selectedChannel);
            LoadSubmissions(selectedChannel);
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}

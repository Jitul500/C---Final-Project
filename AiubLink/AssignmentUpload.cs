using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class AssignmentUpload : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private Form previousForm;

        public AssignmentUpload(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void AssignmentUpload_Load(object sender, EventArgs e)
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

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void UploadAssignmentButton_Click(object sender, EventArgs e)
        {
            if (ChannelComboBox.SelectedItem == null || string.IsNullOrEmpty(FilePathTextBox.Text))
            {
                MessageBox.Show("Please select a channel and choose a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedChannel = ChannelComboBox.SelectedItem.ToString();
            string filePath = FilePathTextBox.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] fileData = File.ReadAllBytes(filePath);

            string query = "INSERT INTO Submissions (ChannelID, FilePath, FileData, UserID) VALUES ((SELECT ChannelID FROM Channels WHERE ChannelName = @ChannelName), @FilePath, @FileData, @UserID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelName", selectedChannel);
                        command.Parameters.AddWithValue("@FilePath", Path.GetFileName(filePath));
                        command.Parameters.AddWithValue("@FileData", fileData);
                        command.Parameters.AddWithValue("@UserID", 1); // Replace with actual UserID

                        command.ExecuteNonQuery();
                        MessageBox.Show("Assignment uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading assignment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}

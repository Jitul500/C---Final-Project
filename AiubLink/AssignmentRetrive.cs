using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class AssignmentRetrive : Form
    {
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

      

        private void CreateAssignmentButton_Click(object sender, EventArgs e)
        {
            string description = DescriptionTextBox.Text.Trim();
            string referenceFilePath = ReferenceFileTextBox.Text.Trim();
            int channelId = GetSelectedChannelID(); // Implement this method to get the selected channel's ID

            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(referenceFilePath))
            {
                MessageBox.Show("Please provide a description and upload reference material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string destinationDirectory = @"E:\CS Final Project\UploadedAssignments";
            string fileName = Path.GetFileName(referenceFilePath);
            string destinationPath = Path.Combine(destinationDirectory, fileName);

            try
            {
                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }

                File.Copy(referenceFilePath, destinationPath, true);

                string connectionString = @"Your_Connection_String";
                string query = "INSERT INTO Assignments (ChannelID, Description, ReferenceMaterialPath, CreatedAt) VALUES (@ChannelID, @Description, @ReferenceMaterialPath, @CreatedAt)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelID", channelId);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@ReferenceMaterialPath", destinationPath);
                        command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Assignment created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DescriptionTextBox.Clear();
                ReferenceFileTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating assignment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedChannelID()
        {
            if (ChannelComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a channel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new InvalidOperationException("No channel selected.");
            }

            // Assuming you are using Key-Value pairs (ChannelName - ChannelID)
            return (int)ChannelComboBox.SelectedValue;
        }

        private void LoadSubmissionsButton_Click(object sender, EventArgs e)
        {
            int assignmentId = GetSelectedAssignmentID(); // Implement this to get the selected assignment ID

            string connectionString = @"Your_Connection_String";
            string query = "SELECT StudentID, SubmittedFilePath, SubmittedAt FROM StudentAssignments WHERE AssignmentID = @AssignmentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssignmentID", assignmentId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            SubmissionsDataGridView.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading submissions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetSelectedAssignmentID()
        {
            if (AssignmentsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new InvalidOperationException("No assignment selected.");
            }

            // Assuming the AssignmentID is in the first column of the DataGridView
            return Convert.ToInt32(AssignmentsDataGridView.SelectedRows[0].Cells["AssignmentID"].Value);
        }


        private void LoadAssignments(int channelID)
        {
            string connectionString = @"Your_Connection_String";
            string query = "SELECT AssignmentID, Description, FileName, UploadTime FROM Assignments WHERE ChannelID = @ChannelID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ChannelID", channelID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            AssignmentsDataGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void LoadChannels()
        {
            string connectionString = @"Your_Connection_String";
            string query = "SELECT ChannelID, ChannelName FROM Channels";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Bind ChannelComboBox
                            ChannelComboBox.DataSource = dt;
                            ChannelComboBox.DisplayMember = "ChannelName";
                            ChannelComboBox.ValueMember = "ChannelID";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading channels: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloadSubmissionButton_Click(object sender, EventArgs e)
        {
            if (SubmissionsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a submission to download.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = SubmissionsDataGridView.SelectedRows[0].Cells["SubmittedFilePath"].Value.ToString();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = Path.GetFileName(filePath),
                Filter = "All files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(filePath, saveFileDialog.FileName, true);
                MessageBox.Show("File downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChannelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChannelComboBox.SelectedValue != null)
            {
                int channelID = (int)ChannelComboBox.SelectedValue;
                LoadAssignments(channelID);
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}

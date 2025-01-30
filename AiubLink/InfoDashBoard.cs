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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AiubLink
{
    public partial class InfoDashBoard : Form
    {

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
        private string userRole;
        public InfoDashBoard(string role)
        {
            InitializeComponent();
            userRole = role;
            if(userRole == "Student")
            {
                studentdetailslabel.Text = "Student Details";
                label2.Text = "Search By Student ID :";
            }
            else
            {
                studentdetailslabel.Text = "Faculty Details";
                label2.Text = "Search By Faculty ID :";
            }
        }

        

        private void exitbutton_Click(object sender, EventArgs e)
        {
                AdminMainPage adminMainPage = new AdminMainPage();
                adminMainPage.Show();
                this.Hide(); 
            
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtextBox.Text))
            {
                MessageBox.Show("Please enter the UserID to update the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Build the update query dynamically based on non-empty fields
                    string query = "UPDATE AiubLink SET ";
                    List<string> updates = new List<string>();
                    SqlCommand command = new SqlCommand();

                    if (!string.IsNullOrWhiteSpace(nametextBox.Text))
                    {
                        updates.Add("Name = @Name");
                        command.Parameters.AddWithValue("@Name", nametextBox.Text.Trim());
                    }

                    if (!string.IsNullOrWhiteSpace(phonetextBox.Text))
                    {
                        updates.Add("Phone = @Phone");
                        command.Parameters.AddWithValue("@Phone", int.Parse(phonetextBox.Text.Trim()));
                    }

                    if (pictureBox1.Image != null)
                    {
                        updates.Add("Photo = @Photo");
                        command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = GetPhotoData();
                    }

                    if (dateTimePicker1.Value != DateTime.MinValue)
                    {
                        updates.Add("DOB = @DOB");
                        command.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                    }

                    if (statusComboBox.SelectedItem != null)
                    {
                        updates.Add("Status = @Status");
                        command.Parameters.AddWithValue("@Status", statusComboBox.SelectedItem.ToString());
                    }

                    if (updates.Count == 0)
                    {
                        MessageBox.Show("Please enter data in at least one field to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    query += string.Join(", ", updates) + " WHERE UserID = @UserID";
                    command.Parameters.AddWithValue("@UserID", idtextBox.Text.Trim());
                    command.CommandText = query;
                    command.Connection = connection;

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SearchData();
                    }
                    else
                    {
                        MessageBox.Show("No data found for the given UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
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

        

        private void InfoDashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aiubLinkDataSet.AiubLink' table. You can move, or remove it, as needed.
            this.aiubLinkTableAdapter.Fill(this.aiubLinkDataSet.AiubLink);
            SearchData();
            // TODO: This line of code loads data into the 'aiubLinkDataSet.AiubLink' table. You can move, or remove it, as needed.
            this.aiubLinkTableAdapter.Fill(this.aiubLinkDataSet.AiubLink);
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            SearchData();

        }

        private void SearchData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM AiubLink WHERE Role = @Role AND Status = @Status";
                    if (!string.IsNullOrWhiteSpace(idtextBox.Text))
                    {
                        query += " AND UserID LIKE @UserID";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Role", userRole);
                        command.Parameters.AddWithValue("@Status", "Registered");

                        if (!string.IsNullOrWhiteSpace(idtextBox.Text))
                        {
                            command.Parameters.AddWithValue("@UserID", "%" + idtextBox.Text.Trim() + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtextBox.Text))
            {
                MessageBox.Show("Please enter the UserID to delete the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Confirm the deletion with the user
                    var result = MessageBox.Show("Are you sure you want to delete this data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM AiubLink WHERE UserID = @UserID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", idtextBox.Text.Trim());

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SearchData(); // Refresh the data to reflect the deletion
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

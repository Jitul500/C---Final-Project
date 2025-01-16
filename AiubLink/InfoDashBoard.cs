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
    public partial class InfoDashBoard : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public InfoDashBoard()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id AS #, Photo, Name, Phone AS PhoneNo, UserID AS ID, Email, DOB, Role, Password FROM AiubLink";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AdminMainPage adminMainPage = new AdminMainPage();
                adminMainPage.Show();
                this.Hide(); 
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["#"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"UPDATE AiubLink 
                                     SET Name = @Name, Phone = @Phone, UserID = @UserID, Email = @Email, DOB = @DOB
                                     WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", nametextBox.Text);
                        command.Parameters.AddWithValue("@Phone", phonetextBox.Text);
                        command.Parameters.AddWithValue("@UserID", idtextBox.Text);
                        command.Parameters.AddWithValue("@Email", emailtextBox.Text);
                        command.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                nametextBox.Text = row.Cells["Name"].Value.ToString();
                phonetextBox.Text = row.Cells["PhoneNo"].Value.ToString();
                idtextBox.Text = row.Cells["ID"].Value.ToString();
                emailtextBox.Text = row.Cells["Email"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
            }
        }
    }
}

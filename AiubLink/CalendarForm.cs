using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CalendarSystem
{
    public partial class CalendarForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS Final Project\AiubLink\DataBase\AiubLink.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false");
        private Form previousForm;
        public CalendarForm(Form previousForm)
        {
            InitializeComponent();
            LoadReminders(DateTime.Today);
            this.previousForm = previousForm;
            // Increase the size
            monthCalendar1.Width = 400;
            monthCalendar1.Height = 300;

            // Increase the font size
            monthCalendar1.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            LoadReminders(e.Start);
        }

        private void LoadReminders(DateTime date)
        {
            listBoxReminders.Items.Clear();
            con.Open();

            string query = "SELECT ReminderText FROM Reminders WHERE ReminderDate = @date";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@date", date);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxReminders.Items.Add(reader["ReminderText"].ToString());
                    }
                }
            }

            con.Close();
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            if (txtReminder.Text == "")
            {
                MessageBox.Show("Enter Reminder Text.");
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO Reminders (ReminderDate, ReminderText) VALUES (@date, @text)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@date", monthCalendar1.SelectionStart);
                    cmd.Parameters.AddWithValue("@text", txtReminder.Text);
                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Reminder Added!");
                LoadReminders(monthCalendar1.SelectionStart);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteReminder_Click(object sender, EventArgs e)
        {
            if (listBoxReminders.SelectedItem == null)
            {
                MessageBox.Show("Select a reminder to delete.");
                return;
            }

            try
            {
                con.Open();
                string query = "DELETE FROM Reminders WHERE ReminderDate = @date AND ReminderText = @text";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@date", monthCalendar1.SelectionStart);
                    cmd.Parameters.AddWithValue("@text", listBoxReminders.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Reminder Deleted!");
                LoadReminders(monthCalendar1.SelectionStart);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}

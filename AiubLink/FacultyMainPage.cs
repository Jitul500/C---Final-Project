using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class FacultyMainPage : Form
    {
        public FacultyMainPage()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        public void calenderbutton_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm(this);
            calendarForm.Show();
            this.Hide();
        }
    }
}

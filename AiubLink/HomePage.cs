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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void LogInButton_MouseEnter(object sender, EventArgs e)
        {
            LogInButton.BackColor = SystemColors.HotTrack;
            LogInButton.ForeColor = SystemColors.MenuText;

        }

        private void LogInButton_MouseLeave(object sender, EventArgs e)
        {
            LogInButton.BackColor = SystemColors.MenuHighlight;
            LogInButton.ForeColor = SystemColors.ButtonHighlight;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Brown;
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.DarkRed;
            ExitButton.ForeColor = SystemColors.MenuText;
        }

        private void AdminButton_MouseLeave(object sender, EventArgs e)
        {
            AdminButton.BackColor = Color.Green;
            AdminButton.ForeColor = SystemColors.ButtonHighlight;
        }

        private void AdminButton_MouseEnter(object sender, EventArgs e)
        {
            AdminButton.BackColor = Color.DarkGreen;
           AdminButton.ForeColor = SystemColors.MenuText;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            WelcomeImage.Parent = AiubImage;
            WelcomeImage.BackColor = Color.Transparent;
            
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminLoginPage adminLoginPage = new AdminLoginPage();
            adminLoginPage.Show();
            this.Hide();
        }

        private void WelcomeImage_Click(object sender, EventArgs e)
        {

        }
    }
}

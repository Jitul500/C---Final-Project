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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void signintext_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgetPage forgetPage = new ForgetPage();
            forgetPage.Show();
            this.Hide();
        }

        private void idtextbox_Enter(object sender, EventArgs e)
        {
            if(idtextbox.Text == "Enter Your ID")
            {
                idtextbox.Text = "";
                idtextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void idtextbox_Leave(object sender, EventArgs e)
        {
            if(idtextbox.Text == "")
            {
                idtextbox.Text = "Enter Your ID";
                idtextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void passtextbox_Enter(object sender, EventArgs e)
        {
            if (passtextbox.Text == "Enter Your Password")
            {
                passtextbox.Text = "";
                passtextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void passtextbox_Leave(object sender, EventArgs e)
        {
            if (passtextbox.Text == "")
            {
                passtextbox.Text = "Enter Your Password";
                passtextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            idtextbox.Clear();
            idtextbox.Text = "Enter Your ID";
            passtextbox.Clear();
            passtextbox.Text = "Enter Your Password";
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createaccountbutton_Click(object sender, EventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

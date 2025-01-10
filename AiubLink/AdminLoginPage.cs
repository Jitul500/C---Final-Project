using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AiubLink
{
    public partial class AdminLoginPage : Form
    {
        public AdminLoginPage()
        {
            InitializeComponent();
        }

        private void loginbutton_MouseEnter(object sender, EventArgs e)
        {
            loginbutton.BackColor = Color.DarkBlue;
            loginbutton.ForeColor = SystemColors.ButtonHighlight;
            
            
        }

        private void loginbutton_MouseLeave(object sender, EventArgs e)
        {
            loginbutton.BackColor = Color.RoyalBlue;
            loginbutton.ForeColor = SystemColors.MenuText;
           
        }

        private void nametextbox_Enter(object sender, EventArgs e)
        {
            if(nametextbox.Text == "Enter Your Name")
            {
                nametextbox.Text = "";
                
            }
        }

        private void nametextbox_Leave(object sender, EventArgs e)
        {
            if (nametextbox.Text == "")
            {
                nametextbox.Text = "Enter Your Name";

            }
        }

        private void passtextbox_Enter(object sender, EventArgs e)
        {
            if(passtextbox.Text == "Enter Your Password")
            {
                passtextbox.Text = "";
            }
        }

        private void passtextbox_Leave(object sender, EventArgs e)
        {
            if( passtextbox.Text == "")
            {
                passtextbox.Text = "Enter Your Password";
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (nametextbox.Text == "Admin" && passtextbox.Text == "Admin")
            {
                AdminMainPage adminMainPage = new AdminMainPage();
                adminMainPage.Show();
                this.Hide();
            }

            else if (nametextbox.Text == "Enter Your Name" || string.IsNullOrWhiteSpace(nametextbox.Text))
            {
                MessageBox.Show("Please enter your Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (passtextbox.Text == "Enter Your Password" || string.IsNullOrWhiteSpace(passtextbox.Text))
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            else
            {
                MessageBox.Show("Invalid Information. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passtextbox.UseSystemPasswordChar = true;
            }
        }
    }
}

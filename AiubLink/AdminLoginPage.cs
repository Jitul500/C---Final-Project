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
    }
}

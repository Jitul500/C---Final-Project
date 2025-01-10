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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            PercentLevel.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100) 
            { 
                timer1.Enabled = false;
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            
            
        }

        private void PercentLevel_Click(object sender, EventArgs e)
        {

        }

        private void LoadingText_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

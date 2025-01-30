using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMeetApp
{
    public partial class VideoConf : Form
    {
        private Form previousForm;
        public VideoConf(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void VideoConf_Load(object sender, EventArgs e)
        {

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {

            string meetLink = txtMeetLink.Text.Trim();

            if (!string.IsNullOrEmpty(meetLink))
            {
                // Open Google Meet link in the default browser
                Process.Start(new ProcessStartInfo(meetLink) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Please enter a valid Google Meet link.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string meetLink = "https://meet.google.com/landing";
            Process.Start(new ProcessStartInfo(meetLink) { UseShellExecute = true });
        }
    }
}

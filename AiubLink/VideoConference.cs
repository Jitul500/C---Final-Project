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
    public partial class VideoConference : Form
    {
        private Form previousForm;
        public VideoConference(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void VideoConference_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}

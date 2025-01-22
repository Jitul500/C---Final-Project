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
    public partial class channels : Form
    {
        private Form previousForm;
        public channels(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {

            previousForm.Show();
            this.Close();
  
        }

        private void Meetingbutton_Click(object sender, EventArgs e)
        {
            VideoConference videoConf = new VideoConference(this);
            videoConf.Show();
            this.Hide();
        }
    }
}

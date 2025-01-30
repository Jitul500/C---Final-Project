using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class AssignmentUpload : Form
    {
        
        private Form previousForm;
        public AssignmentUpload(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void AssignmentUpload_Load(object sender, EventArgs e)
        {

        }

        private void UploadAssignmentButton_Click(object sender, EventArgs e)
        {
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
    
}

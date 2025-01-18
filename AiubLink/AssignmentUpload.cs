using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private string selectedFile;
        public AssignmentUpload()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog.FileName;
                fileListBox.Items.Add(Path.GetFileName(selectedFile));
            }
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFile))
            {
                MessageBox.Show("No file selected for upload.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string uploadsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");
            Directory.CreateDirectory(uploadsDirectory);

            string destinationPath = Path.Combine(uploadsDirectory, Path.GetFileName(selectedFile));
            File.Copy(selectedFile, destinationPath, true);

            MessageBox.Show("File uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
    
}

namespace AiubLink
{
    partial class AssignmentRetrive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentRetrive));
            this.SubmissionsDataGridView = new System.Windows.Forms.DataGridView();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.CreateAssignmentButton = new System.Windows.Forms.Button();
            this.LoadSubmissionsButton = new System.Windows.Forms.Button();
            this.DownloadSubmissionButton = new System.Windows.Forms.Button();
            this.ReferenceFileTextBox = new System.Windows.Forms.TextBox();
            this.ChannelComboBox = new System.Windows.Forms.ComboBox();
            this.AssignmentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SubmissionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmissionsDataGridView
            // 
            this.SubmissionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubmissionsDataGridView.Location = new System.Drawing.Point(1, 290);
            this.SubmissionsDataGridView.Name = "SubmissionsDataGridView";
            this.SubmissionsDataGridView.RowHeadersWidth = 51;
            this.SubmissionsDataGridView.RowTemplate.Height = 24;
            this.SubmissionsDataGridView.Size = new System.Drawing.Size(589, 430);
            this.SubmissionsDataGridView.TabIndex = 0;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(147, 50);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(289, 130);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.Text = "";
            // 
            // CreateAssignmentButton
            // 
            this.CreateAssignmentButton.Location = new System.Drawing.Point(495, 50);
            this.CreateAssignmentButton.Name = "CreateAssignmentButton";
            this.CreateAssignmentButton.Size = new System.Drawing.Size(197, 50);
            this.CreateAssignmentButton.TabIndex = 6;
            this.CreateAssignmentButton.Text = "CreateAssignment";
            this.CreateAssignmentButton.UseVisualStyleBackColor = true;
            this.CreateAssignmentButton.Click += new System.EventHandler(this.CreateAssignmentButton_Click);
            // 
            // LoadSubmissionsButton
            // 
            this.LoadSubmissionsButton.Location = new System.Drawing.Point(997, 50);
            this.LoadSubmissionsButton.Name = "LoadSubmissionsButton";
            this.LoadSubmissionsButton.Size = new System.Drawing.Size(197, 50);
            this.LoadSubmissionsButton.TabIndex = 7;
            this.LoadSubmissionsButton.Text = "LoadSubmissions";
            this.LoadSubmissionsButton.UseVisualStyleBackColor = true;
            this.LoadSubmissionsButton.Click += new System.EventHandler(this.LoadSubmissionsButton_Click);
            // 
            // DownloadSubmissionButton
            // 
            this.DownloadSubmissionButton.Location = new System.Drawing.Point(752, 193);
            this.DownloadSubmissionButton.Name = "DownloadSubmissionButton";
            this.DownloadSubmissionButton.Size = new System.Drawing.Size(197, 50);
            this.DownloadSubmissionButton.TabIndex = 8;
            this.DownloadSubmissionButton.Text = "DownloadSubmission";
            this.DownloadSubmissionButton.UseVisualStyleBackColor = true;
            this.DownloadSubmissionButton.Click += new System.EventHandler(this.DownloadSubmissionButton_Click);
            // 
            // ReferenceFileTextBox
            // 
            this.ReferenceFileTextBox.Location = new System.Drawing.Point(147, 193);
            this.ReferenceFileTextBox.Name = "ReferenceFileTextBox";
            this.ReferenceFileTextBox.Size = new System.Drawing.Size(289, 22);
            this.ReferenceFileTextBox.TabIndex = 10;
            // 
            // ChannelComboBox
            // 
            this.ChannelComboBox.FormattingEnabled = true;
            this.ChannelComboBox.Location = new System.Drawing.Point(495, 152);
            this.ChannelComboBox.Name = "ChannelComboBox";
            this.ChannelComboBox.Size = new System.Drawing.Size(179, 24);
            this.ChannelComboBox.TabIndex = 11;
            this.ChannelComboBox.SelectedIndexChanged += new System.EventHandler(this.ChannelComboBox_SelectedIndexChanged);
            // 
            // AssignmentsDataGridView
            // 
            this.AssignmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentsDataGridView.Location = new System.Drawing.Point(649, 290);
            this.AssignmentsDataGridView.Name = "AssignmentsDataGridView";
            this.AssignmentsDataGridView.RowHeadersWidth = 51;
            this.AssignmentsDataGridView.RowTemplate.Height = 24;
            this.AssignmentsDataGridView.Size = new System.Drawing.Size(589, 430);
            this.AssignmentsDataGridView.TabIndex = 12;
            // 
            // AssignmentRetrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.AssignmentsDataGridView);
            this.Controls.Add(this.ChannelComboBox);
            this.Controls.Add(this.ReferenceFileTextBox);
            this.Controls.Add(this.DownloadSubmissionButton);
            this.Controls.Add(this.LoadSubmissionsButton);
            this.Controls.Add(this.CreateAssignmentButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.SubmissionsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignmentRetrive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignmentRetrive";
            this.Load += new System.EventHandler(this.AssignmentRetrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubmissionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SubmissionsDataGridView;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Button CreateAssignmentButton;
        private System.Windows.Forms.Button LoadSubmissionsButton;
        private System.Windows.Forms.Button DownloadSubmissionButton;
        private System.Windows.Forms.TextBox ReferenceFileTextBox;
        private System.Windows.Forms.ComboBox ChannelComboBox;
        private System.Windows.Forms.DataGridView AssignmentsDataGridView;
    }
}
namespace AiubLink
{
    partial class AdminMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainPage));
            this.exitbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdADDchannelB = new System.Windows.Forms.Button();
            this.AdTeacherB = new System.Windows.Forms.Button();
            this.AdStudentB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1234, 3);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.AdADDchannelB);
            this.panel1.Controls.Add(this.AdTeacherB);
            this.panel1.Controls.Add(this.AdStudentB);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 734);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AdADDchannelB
            // 
            this.AdADDchannelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdADDchannelB.Location = new System.Drawing.Point(11, 310);
            this.AdADDchannelB.Name = "AdADDchannelB";
            this.AdADDchannelB.Size = new System.Drawing.Size(125, 58);
            this.AdADDchannelB.TabIndex = 8;
            this.AdADDchannelB.Text = "ADD CHANNEL";
            this.AdADDchannelB.UseVisualStyleBackColor = true;
            this.AdADDchannelB.Click += new System.EventHandler(this.AdADDchannelB_Click);
            // 
            // AdTeacherB
            // 
            this.AdTeacherB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdTeacherB.Location = new System.Drawing.Point(11, 256);
            this.AdTeacherB.Name = "AdTeacherB";
            this.AdTeacherB.Size = new System.Drawing.Size(125, 39);
            this.AdTeacherB.TabIndex = 7;
            this.AdTeacherB.Text = "TEACHER";
            this.AdTeacherB.UseVisualStyleBackColor = true;
            this.AdTeacherB.Click += new System.EventHandler(this.AdTeacherB_Click);
            // 
            // AdStudentB
            // 
            this.AdStudentB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdStudentB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdStudentB.Location = new System.Drawing.Point(11, 199);
            this.AdStudentB.Name = "AdStudentB";
            this.AdStudentB.Size = new System.Drawing.Size(125, 41);
            this.AdStudentB.TabIndex = 6;
            this.AdStudentB.Text = "STUDENT";
            this.AdStudentB.UseVisualStyleBackColor = false;
            this.AdStudentB.Click += new System.EventHandler(this.AdStudentB_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.StudentPanel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.exitbutton);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1281, 109);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // StudentPanel
            // 
            this.StudentPanel.Location = new System.Drawing.Point(248, 106);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(1030, 613);
            this.StudentPanel.TabIndex = 7;
            this.StudentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPage";
            this.Load += new System.EventHandler(this.AdminMainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AdADDchannelB;
        private System.Windows.Forms.Button AdTeacherB;
        private System.Windows.Forms.Button AdStudentB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel StudentPanel;
    }
}
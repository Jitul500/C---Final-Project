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
            this.studentlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.facnumlabel = new System.Windows.Forms.Label();
            this.stnumlabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.facnum2label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stnum2label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1223, 24);
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
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
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
            // studentlabel
            // 
            this.studentlabel.AutoSize = true;
            this.studentlabel.BackColor = System.Drawing.Color.PowderBlue;
            this.studentlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlabel.Location = new System.Drawing.Point(77, 34);
            this.studentlabel.Name = "studentlabel";
            this.studentlabel.Size = new System.Drawing.Size(315, 23);
            this.studentlabel.TabIndex = 7;
            this.studentlabel.Text = "Total No of Registered Faculties";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total No of Registered Students";
            // 
            // facnumlabel
            // 
            this.facnumlabel.AutoSize = true;
            this.facnumlabel.BackColor = System.Drawing.Color.PowderBlue;
            this.facnumlabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facnumlabel.Location = new System.Drawing.Point(181, 100);
            this.facnumlabel.Name = "facnumlabel";
            this.facnumlabel.Size = new System.Drawing.Size(28, 31);
            this.facnumlabel.TabIndex = 9;
            this.facnumlabel.Text = "1";
            // 
            // stnumlabel
            // 
            this.stnumlabel.AutoSize = true;
            this.stnumlabel.BackColor = System.Drawing.Color.PowderBlue;
            this.stnumlabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stnumlabel.Location = new System.Drawing.Point(643, 81);
            this.stnumlabel.Name = "stnumlabel";
            this.stnumlabel.Size = new System.Drawing.Size(28, 31);
            this.stnumlabel.TabIndex = 10;
            this.stnumlabel.Text = "1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.stnum2label);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.facnum2label);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.facnumlabel);
            this.panel3.Controls.Add(this.stnumlabel);
            this.panel3.Controls.Add(this.studentlabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(272, 206);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 270);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(149, 105);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1132, 623);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(1, 609);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1281, 119);
            this.panel4.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total No of Faculties Under Review";
            // 
            // facnum2label
            // 
            this.facnum2label.AutoSize = true;
            this.facnum2label.BackColor = System.Drawing.Color.PowderBlue;
            this.facnum2label.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facnum2label.Location = new System.Drawing.Point(181, 212);
            this.facnum2label.Name = "facnum2label";
            this.facnum2label.Size = new System.Drawing.Size(28, 31);
            this.facnum2label.TabIndex = 12;
            this.facnum2label.Text = "1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total No of Students Under Review";
            // 
            // stnum2label
            // 
            this.stnum2label.AutoSize = true;
            this.stnum2label.BackColor = System.Drawing.Color.PowderBlue;
            this.stnum2label.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stnum2label.Location = new System.Drawing.Point(643, 212);
            this.stnum2label.Name = "stnum2label";
            this.stnum2label.Size = new System.Drawing.Size(28, 31);
            this.stnum2label.TabIndex = 14;
            this.stnum2label.Text = "1";
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPage";
            this.Load += new System.EventHandler(this.AdminMainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label studentlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label facnumlabel;
        private System.Windows.Forms.Label stnumlabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label stnum2label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label facnum2label;
        private System.Windows.Forms.Label label2;
    }
}
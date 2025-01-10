namespace AiubLink
{
    partial class RegistrationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPage));
            this.upperpanel = new System.Windows.Forms.Panel();
            this.reglabel = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.studentcheckBox = new System.Windows.Forms.CheckBox();
            this.studentpanel = new System.Windows.Forms.Panel();
            this.sendcodepanel = new System.Windows.Forms.Panel();
            this.codelabel = new System.Windows.Forms.Label();
            this.verifybutton = new System.Windows.Forms.Button();
            this.verifytextBox = new System.Windows.Forms.TextBox();
            this.sendcodebutton = new System.Windows.Forms.Button();
            this.uploadbutton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.submitbutton = new System.Windows.Forms.Button();
            this.PIClabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirmpasstextBox = new System.Windows.Forms.TextBox();
            this.confirmpasslabel = new System.Windows.Forms.Label();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.passlabel = new System.Windows.Forms.Label();
            this.doblabel = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.stlabel = new System.Windows.Forms.Label();
            this.faccheckBox = new System.Windows.Forms.CheckBox();
            this.faclabel = new System.Windows.Forms.Label();
            this.upperpanel.SuspendLayout();
            this.studentpanel.SuspendLayout();
            this.sendcodepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(250)))));
            this.upperpanel.Controls.Add(this.reglabel);
            this.upperpanel.Controls.Add(this.exitbutton);
            this.upperpanel.Controls.Add(this.backbutton);
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(0, 0);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(1280, 68);
            this.upperpanel.TabIndex = 0;
            // 
            // reglabel
            // 
            this.reglabel.AutoSize = true;
            this.reglabel.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reglabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reglabel.Location = new System.Drawing.Point(528, 9);
            this.reglabel.Name = "reglabel";
            this.reglabel.Size = new System.Drawing.Size(265, 47);
            this.reglabel.TabIndex = 2;
            this.reglabel.Text = "Registration";
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(250)))));
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1233, 8);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(250)))));
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbutton.Location = new System.Drawing.Point(0, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(110, 37);
            this.backbutton.TabIndex = 1;
            this.backbutton.Text = "← Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // studentcheckBox
            // 
            this.studentcheckBox.AutoSize = true;
            this.studentcheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentcheckBox.Location = new System.Drawing.Point(40, 90);
            this.studentcheckBox.Name = "studentcheckBox";
            this.studentcheckBox.Size = new System.Drawing.Size(110, 27);
            this.studentcheckBox.TabIndex = 1;
            this.studentcheckBox.Text = "STUDENT";
            this.studentcheckBox.UseVisualStyleBackColor = true;
            this.studentcheckBox.CheckedChanged += new System.EventHandler(this.studentcheckBox_CheckedChanged);
            // 
            // studentpanel
            // 
            this.studentpanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.studentpanel.Controls.Add(this.sendcodepanel);
            this.studentpanel.Controls.Add(this.sendcodebutton);
            this.studentpanel.Controls.Add(this.uploadbutton);
            this.studentpanel.Controls.Add(this.dateTimePicker1);
            this.studentpanel.Controls.Add(this.submitbutton);
            this.studentpanel.Controls.Add(this.PIClabel);
            this.studentpanel.Controls.Add(this.pictureBox1);
            this.studentpanel.Controls.Add(this.confirmpasstextBox);
            this.studentpanel.Controls.Add(this.confirmpasslabel);
            this.studentpanel.Controls.Add(this.passtextBox);
            this.studentpanel.Controls.Add(this.passlabel);
            this.studentpanel.Controls.Add(this.doblabel);
            this.studentpanel.Controls.Add(this.emailtextBox);
            this.studentpanel.Controls.Add(this.emaillabel);
            this.studentpanel.Controls.Add(this.idtextBox);
            this.studentpanel.Controls.Add(this.idlabel);
            this.studentpanel.Controls.Add(this.phonelabel);
            this.studentpanel.Controls.Add(this.phonetextBox);
            this.studentpanel.Controls.Add(this.nametextBox);
            this.studentpanel.Controls.Add(this.namelabel);
            this.studentpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentpanel.Location = new System.Drawing.Point(0, 188);
            this.studentpanel.Name = "studentpanel";
            this.studentpanel.Size = new System.Drawing.Size(1280, 532);
            this.studentpanel.TabIndex = 3;
            // 
            // sendcodepanel
            // 
            this.sendcodepanel.Controls.Add(this.codelabel);
            this.sendcodepanel.Controls.Add(this.verifybutton);
            this.sendcodepanel.Controls.Add(this.verifytextBox);
            this.sendcodepanel.Location = new System.Drawing.Point(79, 339);
            this.sendcodepanel.Name = "sendcodepanel";
            this.sendcodepanel.Size = new System.Drawing.Size(371, 100);
            this.sendcodepanel.TabIndex = 24;
            // 
            // codelabel
            // 
            this.codelabel.AutoSize = true;
            this.codelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codelabel.Location = new System.Drawing.Point(12, 21);
            this.codelabel.Name = "codelabel";
            this.codelabel.Size = new System.Drawing.Size(57, 19);
            this.codelabel.TabIndex = 9;
            this.codelabel.Text = "CODE";
            // 
            // verifybutton
            // 
            this.verifybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifybutton.Location = new System.Drawing.Point(288, 51);
            this.verifybutton.Name = "verifybutton";
            this.verifybutton.Size = new System.Drawing.Size(80, 30);
            this.verifybutton.TabIndex = 23;
            this.verifybutton.Text = "Verify";
            this.verifybutton.UseVisualStyleBackColor = true;
            this.verifybutton.Click += new System.EventHandler(this.verifybutton_Click);
            // 
            // verifytextBox
            // 
            this.verifytextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verifytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifytextBox.Location = new System.Drawing.Point(89, 12);
            this.verifytextBox.Name = "verifytextBox";
            this.verifytextBox.Size = new System.Drawing.Size(279, 28);
            this.verifytextBox.TabIndex = 10;
            // 
            // sendcodebutton
            // 
            this.sendcodebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendcodebutton.Location = new System.Drawing.Point(346, 303);
            this.sendcodebutton.Name = "sendcodebutton";
            this.sendcodebutton.Size = new System.Drawing.Size(104, 30);
            this.sendcodebutton.TabIndex = 22;
            this.sendcodebutton.Text = "Send  OTP";
            this.sendcodebutton.UseVisualStyleBackColor = true;
            this.sendcodebutton.Click += new System.EventHandler(this.sendcodebutton_Click);
            // 
            // uploadbutton
            // 
            this.uploadbutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadbutton.Location = new System.Drawing.Point(884, 173);
            this.uploadbutton.Name = "uploadbutton";
            this.uploadbutton.Size = new System.Drawing.Size(93, 38);
            this.uploadbutton.TabIndex = 21;
            this.uploadbutton.Text = "Upload";
            this.uploadbutton.UseVisualStyleBackColor = true;
            this.uploadbutton.Click += new System.EventHandler(this.uploadbutton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(781, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 24);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submitbutton.FlatAppearance.BorderSize = 0;
            this.submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitbutton.Location = new System.Drawing.Point(536, 451);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(214, 50);
            this.submitbutton.TabIndex = 19;
            this.submitbutton.Text = "SUBMIT";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            this.submitbutton.Enter += new System.EventHandler(this.submitbutton_Enter);
            this.submitbutton.MouseEnter += new System.EventHandler(this.submitbutton_MouseEnter);
            this.submitbutton.MouseLeave += new System.EventHandler(this.submitbutton_MouseLeave);
            // 
            // PIClabel
            // 
            this.PIClabel.AutoSize = true;
            this.PIClabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIClabel.Location = new System.Drawing.Point(575, 100);
            this.PIClabel.Name = "PIClabel";
            this.PIClabel.Size = new System.Drawing.Size(66, 19);
            this.PIClabel.TabIndex = 18;
            this.PIClabel.Text = "PHOTO";
            this.PIClabel.Click += new System.EventHandler(this.PIClabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(844, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // confirmpasstextBox
            // 
            this.confirmpasstextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasstextBox.Location = new System.Drawing.Point(781, 352);
            this.confirmpasstextBox.Name = "confirmpasstextBox";
            this.confirmpasstextBox.Size = new System.Drawing.Size(279, 28);
            this.confirmpasstextBox.TabIndex = 16;
            // 
            // confirmpasslabel
            // 
            this.confirmpasslabel.AutoSize = true;
            this.confirmpasslabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasslabel.Location = new System.Drawing.Point(575, 356);
            this.confirmpasslabel.Name = "confirmpasslabel";
            this.confirmpasslabel.Size = new System.Drawing.Size(184, 19);
            this.confirmpasslabel.TabIndex = 15;
            this.confirmpasslabel.Text = "CONFIRM PASSWORD";
            // 
            // passtextBox
            // 
            this.passtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtextBox.Location = new System.Drawing.Point(781, 285);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(279, 28);
            this.passtextBox.TabIndex = 14;
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(575, 289);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(101, 19);
            this.passlabel.TabIndex = 13;
            this.passlabel.Text = "PASSWORD";
            // 
            // doblabel
            // 
            this.doblabel.AutoSize = true;
            this.doblabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblabel.Location = new System.Drawing.Point(575, 230);
            this.doblabel.Name = "doblabel";
            this.doblabel.Size = new System.Drawing.Size(126, 19);
            this.doblabel.TabIndex = 11;
            this.doblabel.Text = "DATE OF BIRTH";
            // 
            // emailtextBox
            // 
            this.emailtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(171, 269);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(279, 28);
            this.emailtextBox.TabIndex = 7;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(91, 274);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(58, 19);
            this.emaillabel.TabIndex = 6;
            this.emaillabel.Text = "EMAIL";
            // 
            // idtextBox
            // 
            this.idtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextBox.Location = new System.Drawing.Point(171, 198);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(279, 28);
            this.idtextBox.TabIndex = 5;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.Location = new System.Drawing.Point(91, 203);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(26, 19);
            this.idlabel.TabIndex = 4;
            this.idlabel.Text = "ID";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelabel.Location = new System.Drawing.Point(91, 135);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(67, 19);
            this.phonelabel.TabIndex = 3;
            this.phonelabel.Text = "PHONE";
            // 
            // phonetextBox
            // 
            this.phonetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetextBox.Location = new System.Drawing.Point(171, 130);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(279, 28);
            this.phonetextBox.TabIndex = 2;
            // 
            // nametextBox
            // 
            this.nametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox.Location = new System.Drawing.Point(171, 64);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(279, 28);
            this.nametextBox.TabIndex = 1;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(91, 69);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(59, 19);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "NAME";
            // 
            // stlabel
            // 
            this.stlabel.AutoSize = true;
            this.stlabel.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stlabel.Location = new System.Drawing.Point(528, 125);
            this.stlabel.Name = "stlabel";
            this.stlabel.Size = new System.Drawing.Size(309, 44);
            this.stlabel.TabIndex = 39;
            this.stlabel.Text = "STUDENT DETAILS";
            // 
            // faccheckBox
            // 
            this.faccheckBox.AutoSize = true;
            this.faccheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faccheckBox.Location = new System.Drawing.Point(212, 90);
            this.faccheckBox.Name = "faccheckBox";
            this.faccheckBox.Size = new System.Drawing.Size(115, 27);
            this.faccheckBox.TabIndex = 4;
            this.faccheckBox.Text = "FACULTY";
            this.faccheckBox.UseVisualStyleBackColor = true;
            this.faccheckBox.CheckedChanged += new System.EventHandler(this.faccheckBox_CheckedChanged);
            // 
            // faclabel
            // 
            this.faclabel.AutoSize = true;
            this.faclabel.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold);
            this.faclabel.Location = new System.Drawing.Point(528, 125);
            this.faclabel.Name = "faclabel";
            this.faclabel.Size = new System.Drawing.Size(315, 44);
            this.faclabel.TabIndex = 5;
            this.faclabel.Text = "FACULTY DETAILS";
            // 
            // RegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.faclabel);
            this.Controls.Add(this.faccheckBox);
            this.Controls.Add(this.studentpanel);
            this.Controls.Add(this.studentcheckBox);
            this.Controls.Add(this.upperpanel);
            this.Controls.Add(this.stlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationPage";
            this.Load += new System.EventHandler(this.RegistrationPage_Load);
            this.upperpanel.ResumeLayout(false);
            this.upperpanel.PerformLayout();
            this.studentpanel.ResumeLayout(false);
            this.studentpanel.PerformLayout();
            this.sendcodepanel.ResumeLayout(false);
            this.sendcodepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upperpanel;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label reglabel;
        private System.Windows.Forms.CheckBox studentcheckBox;
        private System.Windows.Forms.Panel studentpanel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox verifytextBox;
        private System.Windows.Forms.Label codelabel;
        private System.Windows.Forms.TextBox confirmpasstextBox;
        private System.Windows.Forms.Label confirmpasslabel;
        private System.Windows.Forms.TextBox passtextBox;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label doblabel;
        private System.Windows.Forms.Label PIClabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stlabel;
        private System.Windows.Forms.CheckBox faccheckBox;
        private System.Windows.Forms.Label faclabel;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button uploadbutton;
        private System.Windows.Forms.Button sendcodebutton;
        private System.Windows.Forms.Button verifybutton;
        private System.Windows.Forms.Panel sendcodepanel;
    }
}
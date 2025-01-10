namespace AiubLink
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.LogInButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AIUBText = new System.Windows.Forms.Label();
            this.LinkText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AiubImage = new System.Windows.Forms.PictureBox();
            this.WelcomeImage = new System.Windows.Forms.PictureBox();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AiubImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.Silver;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpperPanel.Controls.Add(this.LogInButton);
            this.UpperPanel.Controls.Add(this.pictureBox1);
            this.UpperPanel.Controls.Add(this.AIUBText);
            this.UpperPanel.Controls.Add(this.LinkText);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1280, 100);
            this.UpperPanel.TabIndex = 0;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogInButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogInButton.Location = new System.Drawing.Point(1070, 21);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(196, 46);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            this.LogInButton.MouseEnter += new System.EventHandler(this.LogInButton_MouseEnter);
            this.LogInButton.MouseLeave += new System.EventHandler(this.LogInButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AIUBText
            // 
            this.AIUBText.AutoSize = true;
            this.AIUBText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIUBText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AIUBText.Location = new System.Drawing.Point(119, 21);
            this.AIUBText.Name = "AIUBText";
            this.AIUBText.Size = new System.Drawing.Size(63, 27);
            this.AIUBText.TabIndex = 1;
            this.AIUBText.Text = "AIUB";
            // 
            // LinkText
            // 
            this.LinkText.AutoSize = true;
            this.LinkText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkText.ForeColor = System.Drawing.Color.IndianRed;
            this.LinkText.Location = new System.Drawing.Point(142, 45);
            this.LinkText.Name = "LinkText";
            this.LinkText.Size = new System.Drawing.Size(37, 18);
            this.LinkText.TabIndex = 2;
            this.LinkText.Text = "Link";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.AdminButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 1;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Green;
            this.AdminButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminButton.Location = new System.Drawing.Point(10, 21);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(196, 46);
            this.AdminButton.TabIndex = 4;
            this.AdminButton.Text = "Admin LogIn";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            this.AdminButton.MouseEnter += new System.EventHandler(this.AdminButton_MouseEnter);
            this.AdminButton.MouseLeave += new System.EventHandler(this.AdminButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Brown;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Location = new System.Drawing.Point(1070, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(196, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // AiubImage
            // 
            this.AiubImage.Image = ((System.Drawing.Image)(resources.GetObject("AiubImage.Image")));
            this.AiubImage.Location = new System.Drawing.Point(0, 96);
            this.AiubImage.Name = "AiubImage";
            this.AiubImage.Size = new System.Drawing.Size(1280, 528);
            this.AiubImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AiubImage.TabIndex = 2;
            this.AiubImage.TabStop = false;
            // 
            // WelcomeImage
            // 
            this.WelcomeImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeImage.Image = ((System.Drawing.Image)(resources.GetObject("WelcomeImage.Image")));
            this.WelcomeImage.Location = new System.Drawing.Point(281, 63);
            this.WelcomeImage.Name = "WelcomeImage";
            this.WelcomeImage.Size = new System.Drawing.Size(746, 422);
            this.WelcomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WelcomeImage.TabIndex = 3;
            this.WelcomeImage.TabStop = false;
            this.WelcomeImage.Click += new System.EventHandler(this.WelcomeImage_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.WelcomeImage);
            this.Controls.Add(this.AiubImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AiubImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LinkText;
        private System.Windows.Forms.Label AIUBText;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.PictureBox AiubImage;
        private System.Windows.Forms.PictureBox WelcomeImage;
    }
}
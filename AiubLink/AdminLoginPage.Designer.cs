namespace AiubLink
{
    partial class AdminLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginPage));
            this.namepanel = new System.Windows.Forms.Panel();
            this.passpanel = new System.Windows.Forms.Panel();
            this.adminlabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.passtextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // namepanel
            // 
            this.namepanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.namepanel.Location = new System.Drawing.Point(695, 312);
            this.namepanel.Name = "namepanel";
            this.namepanel.Size = new System.Drawing.Size(388, 1);
            this.namepanel.TabIndex = 3;
            // 
            // passpanel
            // 
            this.passpanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.passpanel.Location = new System.Drawing.Point(695, 389);
            this.passpanel.Name = "passpanel";
            this.passpanel.Size = new System.Drawing.Size(388, 1);
            this.passpanel.TabIndex = 5;
            // 
            // adminlabel
            // 
            this.adminlabel.AutoSize = true;
            this.adminlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlabel.Location = new System.Drawing.Point(782, 152);
            this.adminlabel.Name = "adminlabel";
            this.adminlabel.Size = new System.Drawing.Size(237, 42);
            this.adminlabel.TabIndex = 6;
            this.adminlabel.Text = "Admin LogIn";
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.loginbutton.Location = new System.Drawing.Point(695, 477);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(388, 48);
            this.loginbutton.TabIndex = 7;
            this.loginbutton.Text = "Log In";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            this.loginbutton.MouseEnter += new System.EventHandler(this.loginbutton_MouseEnter);
            this.loginbutton.MouseLeave += new System.EventHandler(this.loginbutton_MouseLeave);
            // 
            // nametextbox
            // 
            this.nametextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(172)))), ((int)(((byte)(223)))));
            this.nametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nametextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.nametextbox.Location = new System.Drawing.Point(695, 283);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(388, 23);
            this.nametextbox.TabIndex = 8;
            this.nametextbox.Text = "Enter Your Name";
            this.nametextbox.Enter += new System.EventHandler(this.nametextbox_Enter);
            this.nametextbox.Leave += new System.EventHandler(this.nametextbox_Leave);
            // 
            // passtextbox
            // 
            this.passtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(172)))), ((int)(((byte)(223)))));
            this.passtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passtextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.passtextbox.Location = new System.Drawing.Point(695, 360);
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.Size = new System.Drawing.Size(388, 23);
            this.passtextbox.TabIndex = 9;
            this.passtextbox.Text = "Enter Your Password";
            this.passtextbox.Enter += new System.EventHandler(this.passtextbox_Enter);
            this.passtextbox.Leave += new System.EventHandler(this.passtextbox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 719);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(172)))), ((int)(((byte)(223)))));
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbutton.Location = new System.Drawing.Point(0, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(110, 37);
            this.backbutton.TabIndex = 11;
            this.backbutton.Text = "← Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(172)))), ((int)(((byte)(223)))));
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1233, 8);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 12;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // AdminLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(172)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.passtextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.adminlabel);
            this.Controls.Add(this.passpanel);
            this.Controls.Add(this.namepanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel namepanel;
        private System.Windows.Forms.Panel passpanel;
        private System.Windows.Forms.Label adminlabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox passtextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}
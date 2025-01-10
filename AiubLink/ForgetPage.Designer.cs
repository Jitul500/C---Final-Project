namespace AiubLink
{
    partial class ForgetPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPage));
            this.exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.idtext = new System.Windows.Forms.TextBox();
            this.ReIDlable = new System.Windows.Forms.Label();
            this.buttonSendCode = new System.Windows.Forms.Button();
            this.codetext = new System.Windows.Forms.TextBox();
            this.Codelabel = new System.Windows.Forms.Label();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.textBoxNewpass = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.verifypanel = new System.Windows.Forms.Panel();
            this.resetpanel = new System.Windows.Forms.Panel();
            this.verifypanel.SuspendLayout();
            this.resetpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1236, 0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(403, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESET PASSWORD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbutton.Location = new System.Drawing.Point(12, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(110, 37);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "← Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // idtext
            // 
            this.idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtext.Location = new System.Drawing.Point(146, 225);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(356, 41);
            this.idtext.TabIndex = 4;
            // 
            // ReIDlable
            // 
            this.ReIDlable.AutoSize = true;
            this.ReIDlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReIDlable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReIDlable.Location = new System.Drawing.Point(140, 180);
            this.ReIDlable.Name = "ReIDlable";
            this.ReIDlable.Size = new System.Drawing.Size(52, 32);
            this.ReIDlable.TabIndex = 5;
            this.ReIDlable.Text = "ID:";
            this.ReIDlable.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSendCode
            // 
            this.buttonSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendCode.Location = new System.Drawing.Point(391, 280);
            this.buttonSendCode.Name = "buttonSendCode";
            this.buttonSendCode.Size = new System.Drawing.Size(111, 31);
            this.buttonSendCode.TabIndex = 6;
            this.buttonSendCode.Text = "SEND OTP";
            this.buttonSendCode.UseVisualStyleBackColor = true;
            this.buttonSendCode.Click += new System.EventHandler(this.buttonSendCode_Click);
            // 
            // codetext
            // 
            this.codetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetext.Location = new System.Drawing.Point(21, 57);
            this.codetext.Name = "codetext";
            this.codetext.Size = new System.Drawing.Size(356, 41);
            this.codetext.TabIndex = 7;
            // 
            // Codelabel
            // 
            this.Codelabel.AutoSize = true;
            this.Codelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Codelabel.Location = new System.Drawing.Point(15, 13);
            this.Codelabel.Name = "Codelabel";
            this.Codelabel.Size = new System.Drawing.Size(108, 32);
            this.Codelabel.TabIndex = 8;
            this.Codelabel.Text = "CODE:";
            // 
            // buttonVerify
            // 
            this.buttonVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerify.Location = new System.Drawing.Point(266, 111);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(111, 31);
            this.buttonVerify.TabIndex = 9;
            this.buttonVerify.Text = "VERIFY";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // textBoxNewpass
            // 
            this.textBoxNewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewpass.Location = new System.Drawing.Point(60, 65);
            this.textBoxNewpass.Name = "textBoxNewpass";
            this.textBoxNewpass.Size = new System.Drawing.Size(356, 41);
            this.textBoxNewpass.TabIndex = 10;
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPass.Location = new System.Drawing.Point(60, 235);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(356, 41);
            this.textBoxConfirmPass.TabIndex = 11;
            this.textBoxConfirmPass.TextChanged += new System.EventHandler(this.textBoxConfirmPass_TextChanged);
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelConfirmPass.Location = new System.Drawing.Point(54, 191);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(269, 32);
            this.labelConfirmPass.TabIndex = 12;
            this.labelConfirmPass.Text = "Confirm Password:";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNewPassword.Location = new System.Drawing.Point(54, 20);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(222, 32);
            this.labelNewPassword.TabIndex = 13;
            this.labelNewPassword.Text = "New Password:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(490, 576);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(217, 58);
            this.buttonSubmit.TabIndex = 14;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // verifypanel
            // 
            this.verifypanel.Controls.Add(this.Codelabel);
            this.verifypanel.Controls.Add(this.codetext);
            this.verifypanel.Controls.Add(this.buttonVerify);
            this.verifypanel.Location = new System.Drawing.Point(125, 338);
            this.verifypanel.Name = "verifypanel";
            this.verifypanel.Size = new System.Drawing.Size(395, 208);
            this.verifypanel.TabIndex = 15;
            // 
            // resetpanel
            // 
            this.resetpanel.Controls.Add(this.labelNewPassword);
            this.resetpanel.Controls.Add(this.textBoxConfirmPass);
            this.resetpanel.Controls.Add(this.labelConfirmPass);
            this.resetpanel.Controls.Add(this.textBoxNewpass);
            this.resetpanel.Location = new System.Drawing.Point(662, 160);
            this.resetpanel.Name = "resetpanel";
            this.resetpanel.Size = new System.Drawing.Size(497, 335);
            this.resetpanel.TabIndex = 16;
            // 
            // ForgetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonSendCode);
            this.Controls.Add(this.ReIDlable);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.verifypanel);
            this.Controls.Add(this.resetpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgetPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPage";
            this.Load += new System.EventHandler(this.ForgetPage_Load);
            this.verifypanel.ResumeLayout(false);
            this.verifypanel.PerformLayout();
            this.resetpanel.ResumeLayout(false);
            this.resetpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.Label ReIDlable;
        private System.Windows.Forms.Button buttonSendCode;
        private System.Windows.Forms.TextBox codetext;
        private System.Windows.Forms.Label Codelabel;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.TextBox textBoxNewpass;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Panel verifypanel;
        private System.Windows.Forms.Panel resetpanel;
    }
}
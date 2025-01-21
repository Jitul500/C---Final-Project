namespace AiubLink
{
    partial class StudentMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.calenderbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Regbutton = new System.Windows.Forms.Button();
            this.Channelbutton = new System.Windows.Forms.Button();
            this.INFObutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbutton.Location = new System.Drawing.Point(21, 13);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(86, 53);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "← Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1233, 16);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // calenderbutton
            // 
            this.calenderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderbutton.Location = new System.Drawing.Point(45, 272);
            this.calenderbutton.Name = "calenderbutton";
            this.calenderbutton.Size = new System.Drawing.Size(134, 50);
            this.calenderbutton.TabIndex = 5;
            this.calenderbutton.Text = "Calender";
            this.calenderbutton.UseVisualStyleBackColor = true;
            this.calenderbutton.Click += new System.EventHandler(this.calenderbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backbutton);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Location = new System.Drawing.Point(-9, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 75);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.INFObutton);
            this.panel2.Controls.Add(this.Channelbutton);
            this.panel2.Controls.Add(this.Regbutton);
            this.panel2.Controls.Add(this.calenderbutton);
            this.panel2.Location = new System.Drawing.Point(-24, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 660);
            this.panel2.TabIndex = 7;
            // 
            // Regbutton
            // 
            this.Regbutton.Location = new System.Drawing.Point(45, 188);
            this.Regbutton.Name = "Regbutton";
            this.Regbutton.Size = new System.Drawing.Size(134, 53);
            this.Regbutton.TabIndex = 8;
            this.Regbutton.Text = "Registration";
            this.Regbutton.UseVisualStyleBackColor = true;
            this.Regbutton.Click += new System.EventHandler(this.Regbutton_Click);
            // 
            // Channelbutton
            // 
            this.Channelbutton.Location = new System.Drawing.Point(45, 106);
            this.Channelbutton.Name = "Channelbutton";
            this.Channelbutton.Size = new System.Drawing.Size(134, 53);
            this.Channelbutton.TabIndex = 9;
            this.Channelbutton.Text = "Channels";
            this.Channelbutton.UseVisualStyleBackColor = true;
            // 
            // INFObutton
            // 
            this.INFObutton.Location = new System.Drawing.Point(45, 28);
            this.INFObutton.Name = "INFObutton";
            this.INFObutton.Size = new System.Drawing.Size(134, 53);
            this.INFObutton.TabIndex = 10;
            this.INFObutton.Text = "Info";
            this.INFObutton.UseVisualStyleBackColor = true;
            // 
            // StudentMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button calenderbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Regbutton;
        private System.Windows.Forms.Button Channelbutton;
        private System.Windows.Forms.Button INFObutton;
    }
}
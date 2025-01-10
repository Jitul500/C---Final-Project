namespace AiubLink
{
    partial class FacultyMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyMainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.calenderbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty MainPage";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbutton.Location = new System.Drawing.Point(0, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(110, 37);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "← Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1233, 8);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // calenderbutton
            // 
            this.calenderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderbutton.Location = new System.Drawing.Point(1160, 644);
            this.calenderbutton.Name = "calenderbutton";
            this.calenderbutton.Size = new System.Drawing.Size(117, 73);
            this.calenderbutton.TabIndex = 4;
            this.calenderbutton.Text = "Calender";
            this.calenderbutton.UseVisualStyleBackColor = true;
            // 
            // FacultyMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.calenderbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacultyMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacultyMainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button calenderbutton;
    }
}
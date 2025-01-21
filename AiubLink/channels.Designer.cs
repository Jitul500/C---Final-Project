namespace AiubLink
{
    partial class channels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(channels));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Channelslabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Assigmentbutton = new System.Windows.Forms.Button();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.Meetingbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.ForestGreen;
            this.flowLayoutPanel1.Controls.Add(this.Channelslabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1286, 79);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Channelslabel
            // 
            this.Channelslabel.AutoSize = true;
            this.Channelslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Channelslabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.Channelslabel.Location = new System.Drawing.Point(3, 0);
            this.Channelslabel.Name = "Channelslabel";
            this.Channelslabel.Size = new System.Drawing.Size(289, 69);
            this.Channelslabel.TabIndex = 0;
            this.Channelslabel.Text = "Channels";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(-1, 76);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(495, 644);
            this.checkedListBox1.TabIndex = 3;
            // 
            // Assigmentbutton
            // 
            this.Assigmentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assigmentbutton.Location = new System.Drawing.Point(474, 13);
            this.Assigmentbutton.Name = "Assigmentbutton";
            this.Assigmentbutton.Size = new System.Drawing.Size(244, 67);
            this.Assigmentbutton.TabIndex = 6;
            this.Assigmentbutton.Text = "Assigment";
            this.Assigmentbutton.UseVisualStyleBackColor = true;
            // 
            // Sendbutton
            // 
            this.Sendbutton.BackColor = System.Drawing.Color.Orange;
            this.Sendbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendbutton.Location = new System.Drawing.Point(1117, 581);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(151, 40);
            this.Sendbutton.TabIndex = 5;
            this.Sendbutton.Text = "Send";
            this.Sendbutton.UseVisualStyleBackColor = false;
            // 
            // Meetingbutton
            // 
            this.Meetingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meetingbutton.Location = new System.Drawing.Point(29, 13);
            this.Meetingbutton.Name = "Meetingbutton";
            this.Meetingbutton.Size = new System.Drawing.Size(269, 67);
            this.Meetingbutton.TabIndex = 4;
            this.Meetingbutton.Text = "Meeting";
            this.Meetingbutton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(503, 581);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 41);
            this.textBox1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Meetingbutton);
            this.panel1.Controls.Add(this.Assigmentbutton);
            this.panel1.Location = new System.Drawing.Point(500, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 92);
            this.panel1.TabIndex = 7;
            // 
            // channels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "channels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "channels";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Channelslabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Assigmentbutton;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Button Meetingbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
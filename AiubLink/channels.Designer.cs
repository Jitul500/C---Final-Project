﻿namespace AiubLink
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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.Assigmentbutton = new System.Windows.Forms.Button();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.Meetingbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitbutton = new System.Windows.Forms.Button();
            this.channelpanel = new System.Windows.Forms.Panel();
            this.msgbox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.channelpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.ForestGreen;
            this.flowLayoutPanel1.Controls.Add(this.Channelslabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(964, 65);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Channelslabel
            // 
            this.Channelslabel.AutoSize = true;
            this.Channelslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Channelslabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.Channelslabel.Location = new System.Drawing.Point(2, 0);
            this.Channelslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Channelslabel.Name = "Channelslabel";
            this.Channelslabel.Size = new System.Drawing.Size(236, 55);
            this.Channelslabel.TabIndex = 0;
            this.Channelslabel.Text = "Channels";
            // 
            // checkedListBox
            // 
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(-1, 62);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(371, 506);
            this.checkedListBox.TabIndex = 3;
            this.checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
            // 
            // Assigmentbutton
            // 
            this.Assigmentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assigmentbutton.Location = new System.Drawing.Point(356, 11);
            this.Assigmentbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Assigmentbutton.Name = "Assigmentbutton";
            this.Assigmentbutton.Size = new System.Drawing.Size(183, 54);
            this.Assigmentbutton.TabIndex = 6;
            this.Assigmentbutton.Text = "Assigment";
            this.Assigmentbutton.UseVisualStyleBackColor = true;
            this.Assigmentbutton.Click += new System.EventHandler(this.Assigmentbutton_Click);
            // 
            // Sendbutton
            // 
            this.Sendbutton.BackColor = System.Drawing.Color.Orange;
            this.Sendbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendbutton.Location = new System.Drawing.Point(465, 410);
            this.Sendbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(113, 32);
            this.Sendbutton.TabIndex = 5;
            this.Sendbutton.Text = "Send";
            this.Sendbutton.UseVisualStyleBackColor = false;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // Meetingbutton
            // 
            this.Meetingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meetingbutton.Location = new System.Drawing.Point(22, 11);
            this.Meetingbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Meetingbutton.Name = "Meetingbutton";
            this.Meetingbutton.Size = new System.Drawing.Size(202, 54);
            this.Meetingbutton.TabIndex = 4;
            this.Meetingbutton.Text = "Meeting";
            this.Meetingbutton.UseVisualStyleBackColor = true;
            this.Meetingbutton.Click += new System.EventHandler(this.Meetingbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 410);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 35);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Meetingbutton);
            this.panel1.Controls.Add(this.Assigmentbutton);
            this.panel1.Location = new System.Drawing.Point(2, 448);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 75);
            this.panel1.TabIndex = 7;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.ForestGreen;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(918, 10);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(33, 33);
            this.exitbutton.TabIndex = 8;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // channelpanel
            // 
            this.channelpanel.Controls.Add(this.msgbox);
            this.channelpanel.Controls.Add(this.panel1);
            this.channelpanel.Controls.Add(this.Sendbutton);
            this.channelpanel.Controls.Add(this.textBox1);
            this.channelpanel.Location = new System.Drawing.Point(368, 62);
            this.channelpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.channelpanel.Name = "channelpanel";
            this.channelpanel.Size = new System.Drawing.Size(595, 523);
            this.channelpanel.TabIndex = 9;
            // 
            // msgbox
            // 
            this.msgbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgbox.FormattingEnabled = true;
            this.msgbox.ItemHeight = 16;
            this.msgbox.Location = new System.Drawing.Point(7, 6);
            this.msgbox.Name = "msgbox";
            this.msgbox.Size = new System.Drawing.Size(576, 388);
            this.msgbox.TabIndex = 8;
            this.msgbox.SelectedIndexChanged += new System.EventHandler(this.msgbox_SelectedIndexChanged);
            // 
            // channels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.channelpanel);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "channels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "channels";
            this.Load += new System.EventHandler(this.channels_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.channelpanel.ResumeLayout(false);
            this.channelpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Channelslabel;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button Assigmentbutton;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Button Meetingbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Panel channelpanel;
        private System.Windows.Forms.ListBox msgbox;
    }
}
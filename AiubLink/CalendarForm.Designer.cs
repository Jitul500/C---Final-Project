namespace CalendarSystem
{
    partial class CalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtReminder = new System.Windows.Forms.TextBox();
            this.listBoxReminders = new System.Windows.Forms.ListBox();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.btnDeleteReminder = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Gainsboro;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(2, 1);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // txtReminder
            // 
            this.txtReminder.BackColor = System.Drawing.Color.LawnGreen;
            this.txtReminder.Location = new System.Drawing.Point(630, 47);
            this.txtReminder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReminder.Multiline = true;
            this.txtReminder.Name = "txtReminder";
            this.txtReminder.Size = new System.Drawing.Size(497, 112);
            this.txtReminder.TabIndex = 1;
            // 
            // listBoxReminders
            // 
            this.listBoxReminders.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.listBoxReminders.FormattingEnabled = true;
            this.listBoxReminders.ItemHeight = 16;
            this.listBoxReminders.Location = new System.Drawing.Point(630, 165);
            this.listBoxReminders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxReminders.Name = "listBoxReminders";
            this.listBoxReminders.Size = new System.Drawing.Size(497, 404);
            this.listBoxReminders.TabIndex = 2;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReminder.Location = new System.Drawing.Point(11, 414);
            this.btnAddReminder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(162, 46);
            this.btnAddReminder.TabIndex = 3;
            this.btnAddReminder.Text = "AddReminder";
            this.btnAddReminder.UseVisualStyleBackColor = false;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // btnDeleteReminder
            // 
            this.btnDeleteReminder.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReminder.Location = new System.Drawing.Point(11, 503);
            this.btnDeleteReminder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteReminder.Name = "btnDeleteReminder";
            this.btnDeleteReminder.Size = new System.Drawing.Size(162, 46);
            this.btnDeleteReminder.TabIndex = 4;
            this.btnDeleteReminder.Text = "DeleteReminder";
            this.btnDeleteReminder.UseVisualStyleBackColor = false;
            this.btnDeleteReminder.Click += new System.EventHandler(this.btnDeleteReminder_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Wheat;
            this.exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbutton.BackgroundImage")));
            this.exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(1082, 1);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 41);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1138, 576);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.btnDeleteReminder);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.listBoxReminders);
            this.Controls.Add(this.txtReminder);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtReminder;
        private System.Windows.Forms.ListBox listBoxReminders;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.Button btnDeleteReminder;
        private System.Windows.Forms.Button exitbutton;
    }
}


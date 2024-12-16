namespace TCC_App
{
    partial class UI_Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            btnViewTasks = new Button();
            btnViewFeedback = new Button();
            btnAddUsers = new Button();
            AddUser = new Button();
            btnViewAnalytics = new Button();
            btnScheduleAnnouncement = new Button();
            panel1 = new Panel();
            panelMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(201, 25);
            label4.TabIndex = 3;
            label4.Text = "Administrative View";
            // 
            // btnViewTasks
            // 
            btnViewTasks.Location = new Point(513, 12);
            btnViewTasks.Margin = new Padding(2);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(111, 44);
            btnViewTasks.TabIndex = 5;
            btnViewTasks.Text = "Review Admin Requests";
            btnViewTasks.UseVisualStyleBackColor = true;
            btnViewTasks.Click += btnViewTasks_Click;
            // 
            // btnViewFeedback
            // 
            btnViewFeedback.Location = new Point(414, 12);
            btnViewFeedback.Margin = new Padding(2);
            btnViewFeedback.Name = "btnViewFeedback";
            btnViewFeedback.Size = new Size(95, 44);
            btnViewFeedback.TabIndex = 4;
            btnViewFeedback.Text = "View Feedback";
            btnViewFeedback.UseVisualStyleBackColor = true;
            btnViewFeedback.Click += btnViewFeedback_Click;
            // 
            // btnAddUsers
            // 
            btnAddUsers.Location = new Point(311, 12);
            btnAddUsers.Margin = new Padding(2);
            btnAddUsers.Name = "btnAddUsers";
            btnAddUsers.Size = new Size(99, 44);
            btnAddUsers.TabIndex = 3;
            btnAddUsers.Text = "Remove Users";
            btnAddUsers.UseVisualStyleBackColor = true;
            btnAddUsers.Click += btnAddUsers_Click;
            // 
            // AddUser
            // 
            AddUser.Location = new Point(212, 12);
            AddUser.Margin = new Padding(2);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(95, 44);
            AddUser.TabIndex = 2;
            AddUser.Text = "Add Users";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
            // 
            // btnViewAnalytics
            // 
            btnViewAnalytics.Location = new Point(107, 12);
            btnViewAnalytics.Margin = new Padding(2);
            btnViewAnalytics.Name = "btnViewAnalytics";
            btnViewAnalytics.Size = new Size(101, 44);
            btnViewAnalytics.TabIndex = 1;
            btnViewAnalytics.Text = "View User Tags";
            btnViewAnalytics.UseVisualStyleBackColor = true;
            btnViewAnalytics.Click += btnViewAnalytics_Click;
            // 
            // btnScheduleAnnouncement
            // 
            btnScheduleAnnouncement.Location = new Point(7, 12);
            btnScheduleAnnouncement.Margin = new Padding(2);
            btnScheduleAnnouncement.Name = "btnScheduleAnnouncement";
            btnScheduleAnnouncement.Size = new Size(96, 44);
            btnScheduleAnnouncement.TabIndex = 0;
            btnScheduleAnnouncement.Text = "View Current Visitors";
            btnScheduleAnnouncement.UseVisualStyleBackColor = true;
            btnScheduleAnnouncement.Click += btnScheduleAnnouncement_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 30, 60);
            panel1.Controls.Add(btnViewTasks);
            panel1.Controls.Add(btnScheduleAnnouncement);
            panel1.Controls.Add(btnViewFeedback);
            panel1.Controls.Add(btnViewAnalytics);
            panel1.Controls.Add(btnAddUsers);
            panel1.Controls.Add(AddUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 75);
            panel1.TabIndex = 4;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(2, 113);
            panelMain.Margin = new Padding(2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(647, 337);
            panelMain.TabIndex = 6;
            // 
            // UI_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panelMain);
            Margin = new Padding(2, 1, 2, 1);
            Name = "UI_Admin";
            Size = new Size(651, 450);
            Load += UI_Admin_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnViewTasks;
        private Button btnViewFeedback;
        private Button btnAddUsers;
        private Button AddUser;
        private Button btnViewAnalytics;
        private Button btnScheduleAnnouncement;
        private Panel panel1;
        private Panel panelMain;
    }
}

namespace MainPage.Pages
{
    partial class Profile
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
            panel1 = new Panel();
            Coming_EventBT = new Panel();
            edit_BT = new Button();
            Subs_status = new Label();
            phone_num = new Label();
            label1 = new Label();
            event_address_and_postcode = new Label();
            event_name = new Label();
            label_username = new Label();
            button1 = new Button();
            search_BT = new Button();
            Main_BT = new Button();
            Navigation_Panel = new Panel();
            panel1.SuspendLayout();
            Coming_EventBT.SuspendLayout();
            Navigation_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(Coming_EventBT);
            panel1.Controls.Add(label_username);
            panel1.Location = new Point(187, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 570);
            panel1.TabIndex = 2;
            // 
            // Coming_EventBT
            // 
            Coming_EventBT.BackColor = Color.FromArgb(115, 49, 71);
            Coming_EventBT.Controls.Add(edit_BT);
            Coming_EventBT.Controls.Add(Subs_status);
            Coming_EventBT.Controls.Add(phone_num);
            Coming_EventBT.Controls.Add(label1);
            Coming_EventBT.Controls.Add(event_address_and_postcode);
            Coming_EventBT.Controls.Add(event_name);
            Coming_EventBT.Location = new Point(18, 145);
            Coming_EventBT.Name = "Coming_EventBT";
            Coming_EventBT.Size = new Size(877, 264);
            Coming_EventBT.TabIndex = 1;
            // 
            // edit_BT
            // 
            edit_BT.BackColor = Color.FromArgb(85, 44, 59);
            edit_BT.Cursor = Cursors.Hand;
            edit_BT.FlatAppearance.BorderSize = 0;
            edit_BT.FlatStyle = FlatStyle.Flat;
            edit_BT.Font = new Font("Inter Tight SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_BT.ForeColor = SystemColors.ButtonHighlight;
            edit_BT.Location = new Point(687, 205);
            edit_BT.Name = "edit_BT";
            edit_BT.Size = new Size(172, 41);
            edit_BT.TabIndex = 6;
            edit_BT.Text = "edit";
            edit_BT.UseVisualStyleBackColor = false;
            edit_BT.Click += edit_BT_Click;
            // 
            // Subs_status
            // 
            Subs_status.AutoSize = true;
            Subs_status.Font = new Font("Manrope SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subs_status.ForeColor = Color.FromArgb(26, 0, 10);
            Subs_status.Location = new Point(32, 175);
            Subs_status.Name = "Subs_status";
            Subs_status.Size = new Size(400, 24);
            Subs_status.TabIndex = 5;
            Subs_status.Text = "Subscription status: Workspace Membership";
            // 
            // phone_num
            // 
            phone_num.AutoSize = true;
            phone_num.Font = new Font("Manrope SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone_num.ForeColor = Color.FromArgb(26, 0, 10);
            phone_num.Location = new Point(32, 145);
            phone_num.Name = "phone_num";
            phone_num.Size = new Size(331, 24);
            phone_num.TabIndex = 4;
            phone_num.Text = "Phone number: user_phone_number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Manrope SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(26, 0, 10);
            label1.Location = new Point(32, 111);
            label1.Name = "label1";
            label1.Size = new Size(320, 24);
            label1.TabIndex = 3;
            label1.Text = "Email address: user_email_address";
            // 
            // event_address_and_postcode
            // 
            event_address_and_postcode.AutoSize = true;
            event_address_and_postcode.Font = new Font("Manrope SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            event_address_and_postcode.ForeColor = Color.FromArgb(26, 0, 10);
            event_address_and_postcode.Location = new Point(34, 78);
            event_address_and_postcode.Name = "event_address_and_postcode";
            event_address_and_postcode.Size = new Size(329, 24);
            event_address_and_postcode.TabIndex = 2;
            event_address_and_postcode.Text = "Full Name: UserName_and_Surname";
            // 
            // event_name
            // 
            event_name.AutoSize = true;
            event_name.BackColor = Color.Transparent;
            event_name.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            event_name.ForeColor = Color.White;
            event_name.Location = new Point(34, 26);
            event_name.Name = "event_name";
            event_name.Size = new Size(287, 41);
            event_name.TabIndex = 1;
            event_name.Text = "User Information";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Konkhmer Sleokchher", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_username.ForeColor = Color.FromArgb(26, 0, 10);
            label_username.Location = new Point(18, 40);
            label_username.Name = "label_username";
            label_username.Size = new Size(524, 78);
            label_username.TabIndex = 0;
            label_username.Text = "UserName_and_Surname";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Inter Tight SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 296);
            button1.Name = "button1";
            button1.Size = new Size(172, 41);
            button1.TabIndex = 2;
            button1.Text = "settings";
            button1.UseVisualStyleBackColor = false;
            // 
            // search_BT
            // 
            search_BT.BackColor = Color.Transparent;
            search_BT.Font = new Font("Inter Tight SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_BT.Location = new Point(11, 240);
            search_BT.Name = "search_BT";
            search_BT.Size = new Size(172, 41);
            search_BT.TabIndex = 1;
            search_BT.Text = "search";
            search_BT.UseVisualStyleBackColor = false;
            // 
            // Main_BT
            // 
            Main_BT.BackColor = Color.Transparent;
            Main_BT.Font = new Font("Inter Tight SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Main_BT.Location = new Point(11, 186);
            Main_BT.Name = "Main_BT";
            Main_BT.Size = new Size(172, 41);
            Main_BT.TabIndex = 0;
            Main_BT.Text = "main";
            Main_BT.UseVisualStyleBackColor = false;
            Main_BT.Click += Main_BT_Click;
            // 
            // Navigation_Panel
            // 
            Navigation_Panel.BackColor = SystemColors.AppWorkspace;
            Navigation_Panel.Controls.Add(button1);
            Navigation_Panel.Controls.Add(search_BT);
            Navigation_Panel.Controls.Add(Main_BT);
            Navigation_Panel.Location = new Point(-2, -3);
            Navigation_Panel.Name = "Navigation_Panel";
            Navigation_Panel.Size = new Size(190, 568);
            Navigation_Panel.TabIndex = 3;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 563);
            Controls.Add(panel1);
            Controls.Add(Navigation_Panel);
            Name = "Profile";
            Text = "Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Coming_EventBT.ResumeLayout(false);
            Coming_EventBT.PerformLayout();
            Navigation_Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Coming_EventBT;
        private Label event_address_and_postcode;
        private Label event_name;
        private Label label_username;
        private Button button1;
        private Button search_BT;
        private Button Main_BT;
        private Panel Navigation_Panel;
        private Label phone_num;
        private Label label1;
        private Label Subs_status;
        private Button edit_BT;
    }
}
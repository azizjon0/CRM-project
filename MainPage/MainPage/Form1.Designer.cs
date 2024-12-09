namespace MainPage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Profile4352 = new Panel();
            Profile_BT = new Label();
            panel3 = new Panel();
            Activities_BT = new Label();
            panel2 = new Panel();
            Subscription_BT = new Label();
            Coming_EventBT = new Panel();
            label2 = new Label();
            event_address_and_postcode = new Label();
            coming_event_dont_touch = new Label();
            event_name = new Label();
            label1 = new Label();
            Navigation_Panel = new Panel();
            button1 = new Button();
            search_BT = new Button();
            Main_BT = new Button();
            panel1.SuspendLayout();
            Profile4352.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            Coming_EventBT.SuspendLayout();
            Navigation_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(Profile4352);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Coming_EventBT);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(190, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 570);
            panel1.TabIndex = 0;
            // 
            // Profile4352
            // 
            Profile4352.BackColor = Color.FromArgb(255, 160, 174);
            Profile4352.Controls.Add(Profile_BT);
            Profile4352.Cursor = Cursors.Hand;
            Profile4352.Location = new Point(365, 351);
            Profile4352.Name = "Profile4352";
            Profile4352.Size = new Size(527, 181);
            Profile4352.TabIndex = 4;
            // 
            // Profile_BT
            // 
            Profile_BT.AutoSize = true;
            Profile_BT.BackColor = Color.Transparent;
            Profile_BT.Font = new Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Profile_BT.ForeColor = Color.FromArgb(26, 0, 10);
            Profile_BT.Location = new Point(14, 16);
            Profile_BT.Name = "Profile_BT";
            Profile_BT.Size = new Size(149, 51);
            Profile_BT.TabIndex = 3;
            Profile_BT.Text = "Profile";
            Profile_BT.Click += Profile_BT_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(244, 166, 166);
            panel3.Controls.Add(Activities_BT);
            panel3.Location = new Point(18, 351);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 181);
            panel3.TabIndex = 3;
            // 
            // Activities_BT
            // 
            Activities_BT.AutoSize = true;
            Activities_BT.BackColor = Color.Transparent;
            Activities_BT.Font = new Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Activities_BT.ForeColor = Color.FromArgb(26, 0, 10);
            Activities_BT.Location = new Point(22, 16);
            Activities_BT.Name = "Activities_BT";
            Activities_BT.Size = new Size(202, 51);
            Activities_BT.TabIndex = 3;
            Activities_BT.Text = "Activities";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 194, 138);
            panel2.Controls.Add(Subscription_BT);
            panel2.Location = new Point(566, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 181);
            panel2.TabIndex = 2;
            // 
            // Subscription_BT
            // 
            Subscription_BT.AutoSize = true;
            Subscription_BT.BackColor = Color.Transparent;
            Subscription_BT.Font = new Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subscription_BT.ForeColor = Color.FromArgb(26, 0, 10);
            Subscription_BT.Location = new Point(12, 16);
            Subscription_BT.Name = "Subscription_BT";
            Subscription_BT.Size = new Size(269, 51);
            Subscription_BT.TabIndex = 2;
            Subscription_BT.Text = "Subscription";
            // 
            // Coming_EventBT
            // 
            Coming_EventBT.BackColor = Color.FromArgb(115, 49, 71);
            Coming_EventBT.Controls.Add(label2);
            Coming_EventBT.Controls.Add(event_address_and_postcode);
            Coming_EventBT.Controls.Add(coming_event_dont_touch);
            Coming_EventBT.Controls.Add(event_name);
            Coming_EventBT.Location = new Point(18, 145);
            Coming_EventBT.Name = "Coming_EventBT";
            Coming_EventBT.Size = new Size(527, 181);
            Coming_EventBT.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Neutral Sans Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(26, 0, 10);
            label2.Location = new Point(22, 126);
            label2.Name = "label2";
            label2.Size = new Size(167, 22);
            label2.TabIndex = 3;
            label2.Text = "event_date_and_time";
            // 
            // event_address_and_postcode
            // 
            event_address_and_postcode.AutoSize = true;
            event_address_and_postcode.Font = new Font("Neutral Sans Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            event_address_and_postcode.ForeColor = Color.FromArgb(26, 0, 10);
            event_address_and_postcode.Location = new Point(22, 104);
            event_address_and_postcode.Name = "event_address_and_postcode";
            event_address_and_postcode.Size = new Size(237, 22);
            event_address_and_postcode.TabIndex = 2;
            event_address_and_postcode.Text = "event_address_and_postcode";
            // 
            // coming_event_dont_touch
            // 
            coming_event_dont_touch.AutoSize = true;
            coming_event_dont_touch.Font = new Font("Neutral Sans Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coming_event_dont_touch.ForeColor = Color.FromArgb(26, 0, 10);
            coming_event_dont_touch.Location = new Point(22, 16);
            coming_event_dont_touch.Name = "coming_event_dont_touch";
            coming_event_dont_touch.Size = new Size(109, 22);
            coming_event_dont_touch.TabIndex = 0;
            coming_event_dont_touch.Text = "coming event";
            // 
            // event_name
            // 
            event_name.AutoSize = true;
            event_name.BackColor = Color.Transparent;
            event_name.Font = new Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            event_name.ForeColor = Color.White;
            event_name.Location = new Point(13, 38);
            event_name.Name = "event_name";
            event_name.Size = new Size(264, 51);
            event_name.TabIndex = 1;
            event_name.Text = "Event_name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Konkhmer Sleokchher", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(26, 0, 10);
            label1.Location = new Point(7, 38);
            label1.Name = "label1";
            label1.Size = new Size(538, 78);
            label1.TabIndex = 0;
            label1.Text = "Good morning, UserName";
            // 
            // Navigation_Panel
            // 
            Navigation_Panel.BackColor = SystemColors.AppWorkspace;
            Navigation_Panel.Controls.Add(button1);
            Navigation_Panel.Controls.Add(search_BT);
            Navigation_Panel.Controls.Add(Main_BT);
            Navigation_Panel.Location = new Point(1, 1);
            Navigation_Panel.Name = "Navigation_Panel";
            Navigation_Panel.Size = new Size(190, 568);
            Navigation_Panel.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter Tight SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 292);
            button1.Name = "button1";
            button1.Size = new Size(172, 41);
            button1.TabIndex = 2;
            button1.Text = "settings";
            button1.UseVisualStyleBackColor = false;
            // 
            // search_BT
            // 
            search_BT.BackColor = Color.WhiteSmoke;
            search_BT.Cursor = Cursors.Hand;
            search_BT.FlatAppearance.BorderSize = 0;
            search_BT.FlatStyle = FlatStyle.Flat;
            search_BT.Font = new Font("Inter Tight SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_BT.Location = new Point(11, 236);
            search_BT.Name = "search_BT";
            search_BT.Size = new Size(172, 41);
            search_BT.TabIndex = 1;
            search_BT.Text = "search";
            search_BT.UseVisualStyleBackColor = false;
            // 
            // Main_BT
            // 
            Main_BT.BackColor = Color.WhiteSmoke;
            Main_BT.Cursor = Cursors.Hand;
            Main_BT.FlatAppearance.BorderSize = 0;
            Main_BT.FlatStyle = FlatStyle.Flat;
            Main_BT.Font = new Font("Inter Tight SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Main_BT.Location = new Point(11, 182);
            Main_BT.Name = "Main_BT";
            Main_BT.Size = new Size(172, 41);
            Main_BT.TabIndex = 0;
            Main_BT.Text = "main";
            Main_BT.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 563);
            Controls.Add(Navigation_Panel);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Main Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Profile4352.ResumeLayout(false);
            Profile4352.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Coming_EventBT.ResumeLayout(false);
            Coming_EventBT.PerformLayout();
            Navigation_Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Navigation_Panel;
        private Label label1;
        private Panel Coming_EventBT;
        private Panel Profile4352;
        private Panel panel3;
        private Panel panel2;
        private Label coming_event_dont_touch;
        private Label event_name;
        private Label label2;
        private Label event_address_and_postcode;
        private Label Subscription_BT;
        private Label Profile_BT;
        private Label Activities_BT;
        private Button button1;
        private Button search_BT;
        private Button Main_BT;
    }
}

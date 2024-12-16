namespace TCC_App
{
    partial class UI_MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_MainPage));
            Profile4352 = new Panel();
            Profile_BT = new Label();
            panel2 = new Panel();
            Subscription_BT = new Label();
            Coming_EventBT = new Panel();
            pictureBox1 = new PictureBox();
            event_name = new Label();
            label1 = new Label();
            Profile4352.SuspendLayout();
            panel2.SuspendLayout();
            Coming_EventBT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Profile4352
            // 
            Profile4352.BackColor = Color.FromArgb(255, 160, 174);
            Profile4352.Controls.Add(Profile_BT);
            Profile4352.Cursor = Cursors.Hand;
            Profile4352.Location = new Point(405, 347);
            Profile4352.Name = "Profile4352";
            Profile4352.Size = new Size(326, 181);
            Profile4352.TabIndex = 7;
            // 
            // Profile_BT
            // 
            Profile_BT.AutoSize = true;
            Profile_BT.BackColor = Color.Transparent;
            Profile_BT.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Profile_BT.ForeColor = Color.FromArgb(26, 0, 10);
            Profile_BT.Location = new Point(14, 16);
            Profile_BT.Name = "Profile_BT";
            Profile_BT.Size = new Size(130, 42);
            Profile_BT.TabIndex = 3;
            Profile_BT.Text = "Profile";
            Profile_BT.Click += Profile_BT_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 194, 138);
            panel2.Controls.Add(Subscription_BT);
            panel2.Location = new Point(405, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 181);
            panel2.TabIndex = 6;
            // 
            // Subscription_BT
            // 
            Subscription_BT.AutoSize = true;
            Subscription_BT.BackColor = Color.Transparent;
            Subscription_BT.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Subscription_BT.ForeColor = Color.FromArgb(26, 0, 10);
            Subscription_BT.Location = new Point(11, 16);
            Subscription_BT.Name = "Subscription_BT";
            Subscription_BT.Size = new Size(236, 42);
            Subscription_BT.TabIndex = 2;
            Subscription_BT.Text = "Subscription";
            // 
            // Coming_EventBT
            // 
            Coming_EventBT.BackColor = Color.FromArgb(115, 49, 71);
            Coming_EventBT.Controls.Add(pictureBox1);
            Coming_EventBT.Controls.Add(event_name);
            Coming_EventBT.Location = new Point(19, 141);
            Coming_EventBT.Name = "Coming_EventBT";
            Coming_EventBT.Size = new Size(368, 387);
            Coming_EventBT.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // event_name
            // 
            event_name.AutoSize = true;
            event_name.BackColor = Color.Transparent;
            event_name.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            event_name.ForeColor = Color.White;
            event_name.Location = new Point(19, 29);
            event_name.Name = "event_name";
            event_name.Size = new Size(139, 42);
            event_name.TabIndex = 1;
            event_name.Text = "Events";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(26, 0, 10);
            label1.Location = new Point(18, 39);
            label1.Name = "label1";
            label1.Size = new Size(270, 46);
            label1.TabIndex = 8;
            label1.Text = "Hi, UserName";
            // 
            // UI_MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(Profile4352);
            Controls.Add(panel2);
            Controls.Add(Coming_EventBT);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UI_MainPage";
            Size = new Size(744, 600);
            Profile4352.ResumeLayout(false);
            Profile4352.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Coming_EventBT.ResumeLayout(false);
            Coming_EventBT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Profile4352;
        private Label Profile_BT;
        private Panel panel2;
        private Label Subscription_BT;
        private Panel Coming_EventBT;
        private Label event_name;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

namespace TCC_App
{
    partial class UI_Login
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
            panelMain = new Panel();
            label1 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            btnAddUser = new Button();
            txtEmail = new TextBox();
            panel1 = new Panel();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(btnAddUser);
            panelMain.Controls.Add(txtEmail);
            panelMain.Location = new Point(2, 2);
            panelMain.Margin = new Padding(2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(647, 381);
            panelMain.TabIndex = 9;
            panelMain.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 179);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 17;
            label1.Text = "Password";
            label1.UseWaitCursor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(96, 176);
            txtPassword.Margin = new Padding(2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(162, 29);
            txtPassword.TabIndex = 16;
            txtPassword.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 146);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 9;
            label4.Text = "Email";
            label4.UseWaitCursor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Green;
            btnAddUser.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(54, 240);
            btnAddUser.Margin = new Padding(2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(204, 49);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Log in";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.UseWaitCursor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(96, 143);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 29);
            txtEmail.TabIndex = 2;
            txtEmail.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 30, 60);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 450);
            panel1.TabIndex = 8;
            panel1.UseWaitCursor = true;
            // 
            // UI_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "UI_Login";
            Size = new Size(651, 450);
            UseWaitCursor = true;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMain;
        private Panel panel1;
        private TextBox txtEmail;
        private Button btnAddUser;
        private Label label4;
        private TextBox txtPassword;
        private Label label1;
    }
}

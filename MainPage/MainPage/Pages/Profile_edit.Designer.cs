namespace MainPage.Pages
{
    partial class Profile_edit
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            edit_BT = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Konkhmer Sleokchher", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(100, 72);
            label1.TabIndex = 0;
            label1.Text = "Edit";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Inter Tight Medium", 13.8F, FontStyle.Bold);
            textBox1.Location = new Point(12, 107);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Name";
            textBox1.Size = new Size(468, 35);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Inter Tight Medium", 13.8F, FontStyle.Bold);
            textBox2.Location = new Point(12, 158);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = " SurName";
            textBox2.Size = new Size(468, 35);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Inter Tight Medium", 13.8F, FontStyle.Bold);
            textBox3.Location = new Point(12, 208);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " Email address";
            textBox3.Size = new Size(468, 35);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Inter Tight Medium", 13.8F, FontStyle.Bold);
            textBox4.Location = new Point(12, 260);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = " Phone number";
            textBox4.Size = new Size(468, 35);
            textBox4.TabIndex = 4;
            // 
            // edit_BT
            // 
            edit_BT.BackColor = Color.RoyalBlue;
            edit_BT.Cursor = Cursors.Hand;
            edit_BT.FlatAppearance.BorderSize = 0;
            edit_BT.FlatStyle = FlatStyle.Flat;
            edit_BT.Font = new Font("Inter Tight SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_BT.ForeColor = SystemColors.ButtonHighlight;
            edit_BT.Location = new Point(331, 326);
            edit_BT.Name = "edit_BT";
            edit_BT.Size = new Size(149, 41);
            edit_BT.TabIndex = 7;
            edit_BT.Text = "Save";
            edit_BT.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter Tight SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(153, 326);
            button1.Name = "button1";
            button1.Size = new Size(172, 41);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Profile_edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(492, 405);
            Controls.Add(button1);
            Controls.Add(edit_BT);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile_edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button edit_BT;
        private Button button1;
    }
}
namespace TCC_App
{
    partial class UI_Edit_Profile
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
            button1 = new Button();
            edit_BT = new Button();
            PhoneBox = new TextBox();
            EmailBox = new TextBox();
            SurnameBox = new TextBox();
            NameBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(265, 479);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(197, 55);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // edit_BT
            // 
            edit_BT.BackColor = Color.RoyalBlue;
            edit_BT.Cursor = Cursors.Hand;
            edit_BT.FlatAppearance.BorderSize = 0;
            edit_BT.FlatStyle = FlatStyle.Flat;
            edit_BT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            edit_BT.ForeColor = SystemColors.ButtonHighlight;
            edit_BT.Location = new Point(469, 479);
            edit_BT.Margin = new Padding(3, 4, 3, 4);
            edit_BT.Name = "edit_BT";
            edit_BT.Size = new Size(170, 55);
            edit_BT.TabIndex = 14;
            edit_BT.Text = "Save";
            edit_BT.UseVisualStyleBackColor = false;
            edit_BT.Click += edit_BT_Click;
            // 
            // PhoneBox
            // 
            PhoneBox.BorderStyle = BorderStyle.FixedSingle;
            PhoneBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneBox.Location = new Point(104, 391);
            PhoneBox.Margin = new Padding(3, 4, 3, 4);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.PlaceholderText = " Phone number";
            PhoneBox.Size = new Size(535, 34);
            PhoneBox.TabIndex = 13;
            // 
            // EmailBox
            // 
            EmailBox.BorderStyle = BorderStyle.FixedSingle;
            EmailBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmailBox.Location = new Point(104, 321);
            EmailBox.Margin = new Padding(3, 4, 3, 4);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = " Email address";
            EmailBox.Size = new Size(535, 34);
            EmailBox.TabIndex = 12;
            // 
            // SurnameBox
            // 
            SurnameBox.BorderStyle = BorderStyle.FixedSingle;
            SurnameBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameBox.Location = new Point(104, 255);
            SurnameBox.Margin = new Padding(3, 4, 3, 4);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.PlaceholderText = " SurName";
            SurnameBox.Size = new Size(535, 34);
            SurnameBox.TabIndex = 11;
            // 
            // NameBox1
            // 
            NameBox1.BorderStyle = BorderStyle.FixedSingle;
            NameBox1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox1.Location = new Point(104, 187);
            NameBox1.Margin = new Padding(3, 4, 3, 4);
            NameBox1.Name = "NameBox1";
            NameBox1.PlaceholderText = " Name";
            NameBox1.Size = new Size(535, 34);
            NameBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 68);
            label1.Name = "label1";
            label1.Size = new Size(82, 42);
            label1.TabIndex = 9;
            label1.Text = "Edit";
            // 
            // UI_Edit_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(edit_BT);
            Controls.Add(PhoneBox);
            Controls.Add(EmailBox);
            Controls.Add(SurnameBox);
            Controls.Add(NameBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UI_Edit_Profile";
            Size = new Size(744, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button edit_BT;
        private TextBox PhoneBox;
        private TextBox EmailBox;
        private TextBox SurnameBox;
        private TextBox NameBox1;
        private Label label1;
    }
}

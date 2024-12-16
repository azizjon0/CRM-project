namespace TCC_App
{
    partial class test_conForm
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
            btnTest = new Button();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(147, 93);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(108, 23);
            btnTest.TabIndex = 0;
            btnTest.Text = "button1";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // test_conForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 229);
            Controls.Add(btnTest);
            Name = "test_conForm";
            Text = "test_conForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
    }
}
namespace TCC_App
{
    partial class FormUI
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
            this.Display = new System.Windows.Forms.Panel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Display.Dock = System.Windows.Forms.DockStyle.Right;
            this.Display.Location = new System.Drawing.Point(147, 0);
            this.Display.Margin = new System.Windows.Forms.Padding(0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(651, 450);
            this.Display.TabIndex = 0;
            this.Display.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Paint);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(148, 450);
            this.NavigationPanel.TabIndex = 1;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.Display);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(798, 450);
            this.LoginPanel.TabIndex = 0;
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "FormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Display;
        private Panel NavigationPanel;
        private Panel LoginPanel;
    }
}
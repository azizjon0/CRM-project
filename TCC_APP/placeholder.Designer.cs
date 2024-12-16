namespace TCC_App
{
    partial class placeholder
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.btnAdminView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "placeholder user form";
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(3, 41);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(95, 35);
            this.buttonEvents.TabIndex = 1;
            this.buttonEvents.Text = "Event search";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click_1);
            // 
            // btnAdminView
            // 
            this.btnAdminView.Location = new System.Drawing.Point(136, 41);
            this.btnAdminView.Name = "btnAdminView";
            this.btnAdminView.Size = new System.Drawing.Size(95, 35);
            this.btnAdminView.TabIndex = 2;
            this.btnAdminView.Text = "Admin View";
            this.btnAdminView.UseVisualStyleBackColor = true;
            // 
            // placeholder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdminView);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.label1);
            this.Name = "placeholder";
            this.Size = new System.Drawing.Size(523, 346);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonEvents;
        private Button btnAdminView;
    }
}

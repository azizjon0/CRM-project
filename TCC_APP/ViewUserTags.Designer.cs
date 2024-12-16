namespace CRMApplication
{
    partial class ViewUserTagControl
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
            dataGridViewUserTags = new DataGridView();
            btnremoveVisitor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserTags).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUserTags
            // 
            dataGridViewUserTags.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUserTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserTags.Location = new Point(14, 26);
            dataGridViewUserTags.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUserTags.Name = "dataGridViewUserTags";
            dataGridViewUserTags.RowHeadersWidth = 180;
            dataGridViewUserTags.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewUserTags.RowTemplate.Height = 28;
            dataGridViewUserTags.Size = new Size(1053, 546);
            dataGridViewUserTags.TabIndex = 0;
            dataGridViewUserTags.CellClick += dataGridViewUserTags_CellClick;
            dataGridViewUserTags.CellContentClick += dataGridViewUserTags_CellContentClick;
            // 
            // btnremoveVisitor
            // 
            btnremoveVisitor.BackColor = Color.Red;
            btnremoveVisitor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnremoveVisitor.ForeColor = Color.White;
            btnremoveVisitor.Location = new Point(465, 595);
            btnremoveVisitor.Margin = new Padding(3, 4, 3, 4);
            btnremoveVisitor.Name = "btnremoveVisitor";
            btnremoveVisitor.Size = new Size(228, 83);
            btnremoveVisitor.TabIndex = 5;
            btnremoveVisitor.Text = "Remove User Tag";
            btnremoveVisitor.UseVisualStyleBackColor = false;
            btnremoveVisitor.Click += buttonDeleteUserTag;
            // 
            // ViewUserTagControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnremoveVisitor);
            Controls.Add(dataGridViewUserTags);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewUserTagControl";
            Size = new Size(1094, 782);
            Load += ViewAnalyticsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserTags).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserTags;
        private System.Windows.Forms.Button btnremoveVisitor;
        // private System.Windows.Forms.Button btnDeleteUserTag;
    }
}

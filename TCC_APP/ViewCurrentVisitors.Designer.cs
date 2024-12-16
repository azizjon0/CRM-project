namespace CRMApplication
{
    partial class ViewCurrentVisitorControl
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
            dataGridViewVisitors = new DataGridView();
            btnremoveVisitor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisitors).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVisitors
            // 
            dataGridViewVisitors.AllowUserToAddRows = false;
            dataGridViewVisitors.AllowUserToDeleteRows = false;
            dataGridViewVisitors.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVisitors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewVisitors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVisitors.Location = new Point(19, 19);
            dataGridViewVisitors.Margin = new Padding(3, 4, 3, 4);
            dataGridViewVisitors.Name = "dataGridViewVisitors";
            dataGridViewVisitors.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewVisitors.RowTemplate.Height = 28;
            dataGridViewVisitors.Size = new Size(1053, 546);
            dataGridViewVisitors.TabIndex = 2;
            dataGridViewVisitors.CellClick += dataGridViewVisitors_CellClick;
            dataGridViewVisitors.CellContentClick += dataGridViewVisitors_CellContentClick;
            // 
            // btnremoveVisitor
            // 
            btnremoveVisitor.BackColor = Color.Red;
            btnremoveVisitor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnremoveVisitor.ForeColor = Color.White;
            btnremoveVisitor.Location = new Point(465, 595);
            btnremoveVisitor.Margin = new Padding(3, 4, 3, 4);
            btnremoveVisitor.Name = "btnremoveVisitor";
            btnremoveVisitor.Size = new Size(228, 74);
            btnremoveVisitor.TabIndex = 4;
            btnremoveVisitor.Text = "Remove Visitor";
            btnremoveVisitor.UseVisualStyleBackColor = false;
            btnremoveVisitor.Click += btnRemoveVisitors;
            // 
            // ViewCurrentVisitorControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnremoveVisitor);
            Controls.Add(dataGridViewVisitors);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewCurrentVisitorControl";
            Size = new Size(1094, 782);
            Load += ScheduleAnnouncementControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisitors).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewVisitors;
        private System.Windows.Forms.Button btnremoveVisitor;
    }
}

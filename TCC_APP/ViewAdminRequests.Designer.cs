namespace CRMApplication
{
    partial class ViewAdminRequests
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
            dataGridViewAdminRequests = new DataGridView();
            btndeleterequest = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdminRequests).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAdminRequests
            // 
            dataGridViewAdminRequests.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAdminRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdminRequests.Location = new Point(10, 16);
            dataGridViewAdminRequests.Margin = new Padding(2, 2, 2, 2);
            dataGridViewAdminRequests.Name = "dataGridViewAdminRequests";
            dataGridViewAdminRequests.RowHeadersWidth = 150;
            dataGridViewAdminRequests.RowTemplate.Height = 28;
            dataGridViewAdminRequests.Size = new Size(737, 189);
            dataGridViewAdminRequests.TabIndex = 0;
            dataGridViewAdminRequests.CellClick += dataGridViewAdminRequests_CellClick;
            dataGridViewAdminRequests.CellContentClick += dataGridViewAdminRequests_CellContentClick;
            // 
            // btndeleterequest
            // 
            btndeleterequest.BackColor = Color.Red;
            btndeleterequest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btndeleterequest.ForeColor = Color.White;
            btndeleterequest.Location = new Point(278, 209);
            btndeleterequest.Margin = new Padding(2, 2, 2, 2);
            btndeleterequest.Name = "btndeleterequest";
            btndeleterequest.Size = new Size(160, 44);
            btndeleterequest.TabIndex = 5;
            btndeleterequest.Text = "Delete Request";
            btndeleterequest.UseVisualStyleBackColor = false;
            btndeleterequest.Click += btndeleterequest_Click;
            // 
            // ViewAdminRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btndeleterequest);
            Controls.Add(dataGridViewAdminRequests);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ViewAdminRequests";
            Size = new Size(766, 469);
            Load += ViewAdminRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdminRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdminRequests;
        private System.Windows.Forms.Button btndeleterequest;
    }
}

namespace CRMApplication
{
    partial class ViewFeedbackControl
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
            dataGridViewFeedback = new DataGridView();
            btnremovefeedback = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeedback).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFeedback
            // 
            dataGridViewFeedback.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFeedback.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFeedback.Location = new Point(10, 16);
            dataGridViewFeedback.Margin = new Padding(2, 2, 2, 2);
            dataGridViewFeedback.Name = "dataGridViewFeedback";
            dataGridViewFeedback.RowHeadersWidth = 150;
            dataGridViewFeedback.RowTemplate.Height = 28;
            dataGridViewFeedback.Size = new Size(737, 176);
            dataGridViewFeedback.TabIndex = 0;
            dataGridViewFeedback.CellClick += dataGridViewFeedback_CellClick;
            dataGridViewFeedback.CellContentClick += dataGridViewFeedback_CellContentClick;
            // 
            // btnremovefeedback
            // 
            btnremovefeedback.BackColor = Color.Red;
            btnremovefeedback.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnremovefeedback.ForeColor = Color.White;
            btnremovefeedback.Location = new Point(327, 227);
            btnremovefeedback.Margin = new Padding(2, 2, 2, 2);
            btnremovefeedback.Name = "btnremovefeedback";
            btnremovefeedback.Size = new Size(160, 52);
            btnremovefeedback.TabIndex = 5;
            btnremovefeedback.Text = "Delete Feedback";
            btnremovefeedback.UseVisualStyleBackColor = false;
            btnremovefeedback.Click += btnremovefeedback_Click;
            // 
            // ViewFeedbackControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnremovefeedback);
            Controls.Add(dataGridViewFeedback);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ViewFeedbackControl";
            Size = new Size(766, 469);
            Load += ViewFeedbackControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeedback).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFeedback;
        private System.Windows.Forms.Button btnremovefeedback;
    }
}

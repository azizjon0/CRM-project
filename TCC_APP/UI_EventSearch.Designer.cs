namespace TCC_App
{
    partial class UI_EventSearch
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
            this.calendarsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calendar1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.eventFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.eventSearchLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchBoxLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calendarsPanel.SuspendLayout();
            this.eventSearchLayoutPanel.SuspendLayout();
            this.searchBoxLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarsPanel
            // 
            this.calendarsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.calendarsPanel.ColumnCount = 1;
            this.calendarsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.calendarsPanel.Controls.Add(this.panel1, 0, 1);
            this.calendarsPanel.Controls.Add(this.calendar1, 0, 0);
            this.calendarsPanel.Location = new System.Drawing.Point(0, 0);
            this.calendarsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.calendarsPanel.Name = "calendarsPanel";
            this.calendarsPanel.RowCount = 2;
            this.calendarsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarsPanel.Size = new System.Drawing.Size(213, 453);
            this.calendarsPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TCC_App.Properties.Resources.calendarDEC;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 241);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(203, 202);
            this.panel1.TabIndex = 1;
            // 
            // calendar1
            // 
            this.calendar1.BackgroundImage = global::TCC_App.Properties.Resources.calendarNOV;
            this.calendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar1.Location = new System.Drawing.Point(5, 10);
            this.calendar1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 15);
            this.calendar1.Name = "calendar1";
            this.calendar1.Padding = new System.Windows.Forms.Padding(10);
            this.calendar1.Size = new System.Drawing.Size(203, 201);
            this.calendar1.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(37, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(392, 29);
            this.searchBox.TabIndex = 8;
            this.searchBox.Text = "Search for events";
            // 
            // eventFlowLayout
            // 
            this.eventFlowLayout.AutoScroll = true;
            this.eventFlowLayout.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.eventFlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eventFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventFlowLayout.Location = new System.Drawing.Point(0, 36);
            this.eventFlowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.eventFlowLayout.Name = "eventFlowLayout";
            this.eventFlowLayout.Size = new System.Drawing.Size(438, 417);
            this.eventFlowLayout.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::TCC_App.Properties.Resources.GridiconsSearch;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchButton.Location = new System.Drawing.Point(3, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(28, 24);
            this.searchButton.TabIndex = 0;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // eventSearchLayoutPanel
            // 
            this.eventSearchLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eventSearchLayoutPanel.ColumnCount = 1;
            this.eventSearchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventSearchLayoutPanel.Controls.Add(this.searchBoxLayoutPanel, 0, 0);
            this.eventSearchLayoutPanel.Controls.Add(this.eventFlowLayout, 0, 1);
            this.eventSearchLayoutPanel.Location = new System.Drawing.Point(213, 0);
            this.eventSearchLayoutPanel.Name = "eventSearchLayoutPanel";
            this.eventSearchLayoutPanel.RowCount = 2;
            this.eventSearchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.eventSearchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.eventSearchLayoutPanel.Size = new System.Drawing.Size(438, 453);
            this.eventSearchLayoutPanel.TabIndex = 0;
            // 
            // searchBoxLayoutPanel
            // 
            this.searchBoxLayoutPanel.ColumnCount = 2;
            this.searchBoxLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.searchBoxLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.searchBoxLayoutPanel.Controls.Add(this.searchButton, 0, 0);
            this.searchBoxLayoutPanel.Controls.Add(this.searchBox, 1, 0);
            this.searchBoxLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBoxLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.searchBoxLayoutPanel.Name = "searchBoxLayoutPanel";
            this.searchBoxLayoutPanel.RowCount = 1;
            this.searchBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchBoxLayoutPanel.Size = new System.Drawing.Size(432, 30);
            this.searchBoxLayoutPanel.TabIndex = 0;
            // 
            // UI_EventSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calendarsPanel);
            this.Controls.Add(this.eventSearchLayoutPanel);
            this.Name = "UI_EventSearch";
            this.Size = new System.Drawing.Size(651, 450);
            this.calendarsPanel.ResumeLayout(false);
            this.eventSearchLayoutPanel.ResumeLayout(false);
            this.searchBoxLayoutPanel.ResumeLayout(false);
            this.searchBoxLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel calendarsPanel;
        private Panel panel1;
        private Panel calendar1;
        private TextBox searchBox;
        private FlowLayoutPanel eventFlowLayout;
        private Button searchButton;
        private TableLayoutPanel searchBoxLayoutPanel;
        private TableLayoutPanel eventSearchLayoutPanel;
    }
}

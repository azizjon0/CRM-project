namespace TCC_App
{
    partial class UI_EventInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_EventInformation));
            this.EventPrice = new System.Windows.Forms.Label();
            this.EventLocation = new System.Windows.Forms.Label();
            this.EventInfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EventDateTime = new System.Windows.Forms.Label();
            this.EventDescription = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.Label();
            this.pctEventImage = new System.Windows.Forms.Panel();
            this.eventLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bookButton = new System.Windows.Forms.LinkLabel();
            this.EventInfoLayoutPanel.SuspendLayout();
            this.eventLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventPrice
            // 
            this.EventPrice.AutoSize = true;
            this.EventPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventPrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventPrice.Location = new System.Drawing.Point(3, 360);
            this.EventPrice.Name = "EventPrice";
            this.EventPrice.Size = new System.Drawing.Size(345, 67);
            this.EventPrice.TabIndex = 1;
            this.EventPrice.Text = "Price";
            this.EventPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventLocation
            // 
            this.EventLocation.AutoSize = true;
            this.EventLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventLocation.Location = new System.Drawing.Point(3, 270);
            this.EventLocation.Name = "EventLocation";
            this.EventLocation.Size = new System.Drawing.Size(345, 45);
            this.EventLocation.TabIndex = 3;
            this.EventLocation.Text = "Event location";
            this.EventLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventInfoLayoutPanel
            // 
            this.EventInfoLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventInfoLayoutPanel.ColumnCount = 1;
            this.EventInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EventInfoLayoutPanel.Controls.Add(this.EventDateTime, 0, 2);
            this.EventInfoLayoutPanel.Controls.Add(this.EventPrice, 0, 3);
            this.EventInfoLayoutPanel.Controls.Add(this.EventDescription, 0, 0);
            this.EventInfoLayoutPanel.Controls.Add(this.EventLocation, 0, 1);
            this.EventInfoLayoutPanel.Location = new System.Drawing.Point(300, 0);
            this.EventInfoLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EventInfoLayoutPanel.Name = "EventInfoLayoutPanel";
            this.EventInfoLayoutPanel.RowCount = 5;
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.EventInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.EventInfoLayoutPanel.Size = new System.Drawing.Size(351, 450);
            this.EventInfoLayoutPanel.TabIndex = 10;
            // 
            // EventDateTime
            // 
            this.EventDateTime.AutoSize = true;
            this.EventDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDateTime.Location = new System.Drawing.Point(3, 315);
            this.EventDateTime.Name = "EventDateTime";
            this.EventDateTime.Size = new System.Drawing.Size(345, 45);
            this.EventDateTime.TabIndex = 4;
            this.EventDateTime.Text = "Event DateTime";
            this.EventDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventDescription
            // 
            this.EventDescription.AutoSize = true;
            this.EventDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EventDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDescription.Location = new System.Drawing.Point(15, 15);
            this.EventDescription.Margin = new System.Windows.Forms.Padding(15);
            this.EventDescription.Name = "EventDescription";
            this.EventDescription.Size = new System.Drawing.Size(321, 240);
            this.EventDescription.TabIndex = 2;
            this.EventDescription.Text = resources.GetString("EventDescription.Text");
            this.EventDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EventName
            // 
            this.EventName.AutoSize = true;
            this.EventName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventName.Location = new System.Drawing.Point(3, 265);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(294, 63);
            this.EventName.TabIndex = 0;
            this.EventName.Text = "Example event";
            this.EventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctEventImage
            // 
            this.pctEventImage.BackgroundImage = global::TCC_App.Properties.Resources._event;
            this.pctEventImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctEventImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctEventImage.Location = new System.Drawing.Point(3, 25);
            this.pctEventImage.Name = "pctEventImage";
            this.pctEventImage.Size = new System.Drawing.Size(294, 237);
            this.pctEventImage.TabIndex = 9;
            // 
            // eventLayoutPanel
            // 
            this.eventLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.eventLayoutPanel.ColumnCount = 1;
            this.eventLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventLayoutPanel.Controls.Add(this.EventName, 0, 2);
            this.eventLayoutPanel.Controls.Add(this.pctEventImage, 0, 1);
            this.eventLayoutPanel.Controls.Add(this.bookButton, 0, 3);
            this.eventLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.eventLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.eventLayoutPanel.Name = "eventLayoutPanel";
            this.eventLayoutPanel.RowCount = 5;
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.eventLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.eventLayoutPanel.Size = new System.Drawing.Size(300, 450);
            this.eventLayoutPanel.TabIndex = 8;
            // 
            // bookButton
            // 
            this.bookButton.ActiveLinkColor = System.Drawing.Color.White;
            this.bookButton.AutoSize = true;
            this.bookButton.BackColor = System.Drawing.Color.Red;
            this.bookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookButton.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookButton.LinkColor = System.Drawing.Color.White;
            this.bookButton.Location = new System.Drawing.Point(3, 328);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(294, 76);
            this.bookButton.TabIndex = 10;
            this.bookButton.TabStop = true;
            this.bookButton.Text = "Book";
            this.bookButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bookButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bookButton_LinkClicked);
            // 
            // UI_EventInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventInfoLayoutPanel);
            this.Controls.Add(this.eventLayoutPanel);
            this.Name = "UI_EventInformation";
            this.Size = new System.Drawing.Size(651, 450);
            this.EventInfoLayoutPanel.ResumeLayout(false);
            this.EventInfoLayoutPanel.PerformLayout();
            this.eventLayoutPanel.ResumeLayout(false);
            this.eventLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label EventPrice;
        private Label EventLocation;
        private TableLayoutPanel EventInfoLayoutPanel;
        private Label EventDescription;
        private Label EventName;
        private Panel pctEventImage;
        private TableLayoutPanel eventLayoutPanel;
        private Label EventDateTime;
        private LinkLabel bookButton;
    }
}

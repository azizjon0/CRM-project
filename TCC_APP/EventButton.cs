using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCC_App
{
    internal class EventButton : Button
    {
        //Creator: Elliot

        //A button which is associated with a specific event
        //Loaded into UI_EventSearch
        //When pressed, it will load UI_EventInfo with the information contained in this button

        private string name;
        private string description;
        private string eventLink;
        private string imageLink;
        private string location;
        private double price;
        public DateTime dateTime { get; }
        private FormUI form;

        //Switches form to EventView when pressed
        //Loads EventView with the information contained within this button
        public EventButton(FormUI form, string name, string description, string location, DateTime dateTime, string eventLink, string imageLink, int index, double price)
        {
            this.form = form;
            this.name = name;
            this.description = description;
            this.location = location;
            this.dateTime = dateTime;
            this.eventLink = eventLink;
            this.imageLink = imageLink;
            this.price = price;

            Text = name;
            TextAlign = ContentAlignment.BottomRight;
            Size = new System.Drawing.Size(150, 100);
            Cursor = System.Windows.Forms.Cursors.Hand;

            try
            {
                // Check if imageLink is a valid URL or file path
                if (Uri.IsWellFormedUriString(imageLink, UriKind.Absolute))
                {
                    // Download image from URL
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageData = webClient.DownloadData(imageLink);
                        using (var stream = new System.IO.MemoryStream(imageData))
                        {
                            BackgroundImage = Image.FromStream(stream);
                        }
                    }
                }
                else if (System.IO.File.Exists(imageLink))
                {
                    // Load image from local file path
                    BackgroundImage = Image.FromFile(imageLink);
                }
                else
                {
                    throw new Exception("Invalid image link or file path.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
                BackgroundImage = TCC_App.Properties.Resources._event; // Default image on error
            }

            BackgroundImageLayout = ImageLayout.Stretch;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Tag = index;
            Margin = new System.Windows.Forms.Padding(20);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Set up the graphics object for custom drawing
            Graphics g = pevent.Graphics;

            // Draw the background image (if any) or default button background
            if (BackgroundImage != null)
            {
                g.DrawImage(BackgroundImage, new Rectangle(0, 0, Width, Height));
            }
            else
            {
                // If no background image, use default button background
                using (Brush backgroundBrush = new SolidBrush(BackColor))
                {
                    g.FillRectangle(backgroundBrush, new Rectangle(0, 0, Width, Height));
                }
            }

            // Define the area for the text background
            Rectangle textBackground = new Rectangle(0, Height - 30, Width, 30);

            // Draw the text background (semi-transparent black)
            using (Brush brush = new SolidBrush(Color.FromArgb(128, 0, 0, 0))) // Adjust alpha (128 for 50% transparency)
            {
                g.FillRectangle(brush, textBackground);
            }

            // Draw the custom text
            using (Brush textBrush = new SolidBrush(Color.White)) // Set text color to white
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Far, // Align text to the bottom-right
                    LineAlignment = StringAlignment.Center
                };

                g.DrawString(Text, Font, textBrush, textBackground, sf);
            }

            // Don't call base.OnPaint to prevent default text rendering
        }



        //Returns an array of strings containing the event's name, description, and location
        public string[] GetInfoForSearch()
        {
            string[] info = { name, description, location };
            return info;
        }


        //Loads UI_EventView into Display
        protected override void OnClick(EventArgs e)
        {
            //cost, memberDiscount, accessRequired
            var eventInfo = new Dictionary<string, string>
            {
                {"EventName", $"{name}" },
                {"EventDesc", $"{description}"  },
                {"Location", $"{location}"    },
                {"DateTime",$"{dateTime}" },
                {"EventLink", $"{eventLink}"},
                {"ImageLink",$"{imageLink}" },
                {"EventPrice", $"{price}"}

            };

            form.SwitchForm(new UI_EventInformation(eventInfo));
        }
    }
}

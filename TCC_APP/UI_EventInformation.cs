using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace TCC_App
{
    // Creator: Elliot

    // Displays detailed information about a specific event, as well as a button which links to the booking page
    // Accessed through pressing an event button on the event search page
    public partial class UI_EventInformation : UserControl
    {
        string bookingLink;
        Dictionary<string, string> eventInfo;

        public UI_EventInformation(Dictionary<string, string> eventInfo)
        {
            InitializeComponent();
            this.eventInfo = eventInfo;

            pctEventImage.BackgroundImage = TCC_App.Properties.Resources._event; 
            EventName.Text = $"{eventInfo["EventName"]}";
            EventDescription.Text = $"{eventInfo["EventDesc"]}";
            EventLocation.Text = $"{eventInfo["Location"]}";
            EventDateTime.Text = $"{eventInfo["DateTime"]}";
            EventPrice.Text = $"Price: £{eventInfo["EventPrice"]}";
            bookingLink = $"{eventInfo["EventLink"]}";

            // Fix for loading image from ImageLink
            try
            {
                // Check if the ImageLink is a URL or file path
                if (Uri.IsWellFormedUriString(eventInfo["ImageLink"], UriKind.Absolute))
                {
                    // If it's a URL, download the image
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageData = webClient.DownloadData(eventInfo["ImageLink"]);
                        using (var stream = new System.IO.MemoryStream(imageData))
                        {
                            pctEventImage.BackgroundImage = Image.FromStream(stream);
                        }
                    }
                }
                else
                {
                    // If it's a file path, load the image
                    pctEventImage.BackgroundImage = Image.FromFile(eventInfo["ImageLink"]);
                }
            }
            catch (Exception ex)
            {
                // Handle error (e.g., invalid path or URL)
                Console.WriteLine($"Error loading image: {ex.Message}");
                pctEventImage.BackgroundImage = TCC_App.Properties.Resources._event; // Set default image in case of error
            }
        }

        private void bookButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo() { FileName = bookingLink, UseShellExecute = true });
        }
    }
}

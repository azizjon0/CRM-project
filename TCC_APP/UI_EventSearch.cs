using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_App
{
    //Creator: Elliot

    //Displys a list of buttons which link to different events
    //Search bar can be used to filter events
    public partial class UI_EventSearch : UserControl
    {
        private FormUI form;
        Color DefaultSearchBoxColour = Color.Gray;
        public UI_EventSearch(FormUI form)
        {
            InitializeComponent();
            this.form = form;
            GenerateEventsFromDB();
        }


        //Generates a set of events within the event layout
        //Only shows events which contin the searchTerm (which is empty by default, resulting in all events being shown)
        private void GenerateEventsFromDB(string searchTerm = "")
        {
            // Clears events from layout if any exist
            if (eventFlowLayout.Controls.Count > 0)
            {
                eventFlowLayout.Controls.Clear();
            }

            // Stores events taken from the DB
            List<EventButton> events = new List<EventButton>();
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {

                    conn.Open();
                    string query = string.IsNullOrEmpty(searchTerm)
                        ? "SELECT * FROM event"
                        : "SELECT * FROM event WHERE EventName LIKE CONCAT('%', @searchTerm, '%') OR EventType LIKE CONCAT('%', @searchTerm, '%') OR Location LIKE CONCAT('%', @searchTerm, '%')";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", searchTerm);
                    }
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string eventName = reader["EventName"].ToString();
                            string eventType = reader["EventType"].ToString();
                            DateTime eventDate = reader.GetDateTime(reader.GetOrdinal("EventDate"));
                            string eventLocation = reader["Location"].ToString();
                            string eventLink = reader["EventSiteLink"].ToString();
                            string eventImageLink = reader["BannerImageAddress"].ToString();
                            double eventPrice = reader.GetDouble("EventCost");

                            EventButton e = new EventButton(form, $"{eventName}", $"{eventType}", eventLocation, eventDate, eventLink, eventImageLink, events.Count, eventPrice);

                            // Checking if date has already passed
                            if (e.dateTime > DateTime.Now)
                            {
                                events.Add(e);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load events: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            DisplayEvents(events);
        }


        //Adds events to the UI in chronological order
        private void DisplayEvents(List<EventButton> events)
        {
            //Iterates through events until all have been added
            while (events.Count > 0)
            {
                //Stores the earliest DateTime within events
                DateTime earliest = DateTime.MaxValue;
                //Stores the index of the earliest events
                int index = 0;

                //Finds the earliest event, and stores its index
                foreach (EventButton e in events)
                {
                    if (e.dateTime < earliest)
                    {
                        earliest = e.dateTime;
                        index = events.IndexOf(e);
                    }
                }

                //Event is removed from the list when added
                eventFlowLayout.Controls.Add(events[index]);
                events.RemoveAt(index);
            }
        }


        //Deletes the default text in the search box the first time it's clicked
        private void searchBox_Clicked(object sender, EventArgs e)
        {
            if (!IsSearchDefaultTextClear())
            {
                searchBox.Text = null;
                searchBox.ForeColor = Color.Black;
            }
        }

        //Updates the events display to only show events which contain the search term in their name, description, or tags
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Only runs search if the default text has been cleared
            if (IsSearchDefaultTextClear())
            {
                GenerateEventsFromDB(searchBox.Text);
            }
        }

        //Returns true if the default text has been cleared, otherwise returns false
        private bool IsSearchDefaultTextClear()
        {
            if (searchBox.ForeColor == DefaultSearchBoxColour)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

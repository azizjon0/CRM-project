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

    //Displys a list of buttons which link to different user profiles
    //Search bar can be used to filter users
    public partial class UI_UserSearch : UserControl
    {
        FormUI form;
        Color DefaultSearchBoxColour = Color.Gray;

        public UI_UserSearch(FormUI form)
        {
            InitializeComponent();
            this.form = form;
            GenerateUsersFromDB();
        }

        //Generates a set of users within the user layout
        //Only shows users which contin the searchTerm (which is empty by default, resulting in all users being shown)
        //Currently just generates "dummy" users - will eventually be changed to generate users from the DB
        //NOTE - split this into different functions after DB is implemented
        private void GenerateUsersFromDB(string searchTerm = "")
        {
            //Clears users from layout if any exist
            if (usersFlowLayoutPanel.Controls.Count > 0)
            {
                usersFlowLayoutPanel.Controls.Clear();
            }

            //Stores users taken from the DB
            List<UserButton> users = new List<UserButton>();

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query using a WHERE clause if searchTerm is provided
                    string query = string.IsNullOrEmpty(searchTerm)
                        ? "SELECT * FROM user"
                        : "SELECT * FROM user WHERE FirstName LIKE CONCAT('%', @searchTerm, '%') OR LastName LIKE CONCAT('%', @searchTerm, '%')";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", searchTerm);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string foreName = reader["FirstName"].ToString();
                            string surName = reader["LastName"].ToString();
                            string email = reader["Email"].ToString();
                            string phoneNumber = reader["PhoneNumber"].ToString();
                            string status = reader["Status"].ToString();
                            string profilePictureAddress = reader["ProfilePictureAddress"].ToString();

                            User u = new User(
                                foreName,
                                surName,
                                email,
                                phoneNumber,
                                status,
                                profilePictureAddress,
                                DateTime.Now
                            );

                            UserButton userButton = new UserButton(form, u);
                            users.Add(userButton);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load users: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            DisplayUsers(users);
        }

        //Adds users to the UI based on when they were last active
        private void DisplayUsers(List<UserButton> users)
        {
            //Iterates through events until all have been added
            while (users.Count > 0)
            {
                //Stores the earliest DateTime within users
                DateTime earliest = DateTime.MaxValue;
                //Stores the index of the most recently active user
                int index = 0;

                //Finds the most recently active user, and stores its index
                foreach (UserButton u in users)
                {
                    if (u.GetLastActive() < earliest)
                    {
                        earliest = u.GetLastActive();
                        index = users.IndexOf(u);
                    }
                }

                //Event is removed from the list when added
                usersFlowLayoutPanel.Controls.Add(users[index]);
                users.RemoveAt(index);
            }
        }

        //Deletes the default text in the search box the first time it's clicked
        private void searchBox_Click(object sender, EventArgs e)
        {
            if (!IsSearchDefaultTextClear())
            {
                searchBox.Text = null;
                searchBox.ForeColor = Color.Black;
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

        //Updates the users display to only show users which contain the search term in their name
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Only runs search if the default text has been cleared
            if (IsSearchDefaultTextClear())
            {
                GenerateUsersFromDB(searchBox.Text);
            }
        }
    }
}

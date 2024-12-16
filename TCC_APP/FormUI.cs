using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMApplication;
using Microsoft.VisualBasic.ApplicationServices;
namespace TCC_App
{
    //Creator: Elliot

    //Contains display panels which are used to hold UI elements
    //The majority of the UI is loaded into Display, with two exceptions:
        //The login screen is loaded into LoginPanel
        //The navigation bar is loaded into NavigationPanel

    public partial class FormUI : Form
    {
        //Contains information about the user currently logged in
        //Stored here to reduce load times whenever the profile is clicked
        public User user { get; private set; }
        public FormUI()
        {
            InitializeComponent();

            //Loads a placeholder from into Display - should be replaced with the login screen when that is implemented

            //NOTES FOR RUSHO
            //Replace all code below these comments with the following line: LoginPanel.Controls.Add(new UI_Login(this));
            //*Replace "UI_Login" with whatever your login class is called
            //The login class needs to be loaded with a copy of this class (called form), look at all the other UI classes to see how this works
            //Once the user logs in, load that user's information from the DB into a User object (see UI_UserSearch for how to do this)
            //Finally, call the following code to load the main UI: form.LoadMainUI(user)
            //*Replace "form" with whatever you called the copy of this class
            //*Replace "user" with whatever you called the user class
            this.user = user;
            Display.Controls.Add(new UI_Login(this)); // Test
            //NavigationPanel.Controls.Add(new UI_NavigationBar(this)); // Test
            LoginPanel.Controls.Add(new UI_Login(this)); // Test
            /*User dummyUser = new User("Example", "User", "notReal123@fake.com", "123 456789", "Active", "N/A", DateTime.Now);
            LoadMainUI(dummyUser);*/
        }


        //Switches Display to show the form passed to the method
        public void SwitchForm(UserControl form)
        {
            Display.Controls.Clear();
            Display.Controls.Add(form);
        }

        //Initilizes user with information passed to the class (from login)
        //Loads the navigation bar and the main page into their respective panels
        public void LoadMainUI(User user)
        {
            this.user = user;
            Display.Controls.Add(new UI_MainPage(this, user));
            NavigationPanel.Controls.Add(new UI_NavigationBar(this));
        }

        private void Display_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCC_App
{
    //Creator: Aziz

    //Allows a user to edit their profile.
    //This class contains the logic for displaying and saving user profile edits.

    public partial class UI_Edit_Profile : UserControl
    {
        // FormUI instance to switch between different forms
        FormUI form;
        // User instance to hold user profile data
        User user;

        // Constructor to initialize the form with the user's current data
        public UI_Edit_Profile(FormUI form, User user)
        {
            InitializeComponent();
            this.form = form;
            this.user = user;

            // Initialize text fields with the current user data
            NameBox1.Text = user.foreName;
            SurnameBox.Text = user.surName;
            EmailBox.Text = user.email;
            PhoneBox.Text = user.phoneNumber;
        }

        // Event handler for the "Back" button
        // Switches the view back to the user's profile screen
        private void button1_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Profile(form, user));
        }

        // Event handler for the "Save" button
        // Updates the user's profile data based on the input fields
        private void edit_BT_Click(object sender, EventArgs e)
        {
            // Update the user data with the new values entered in the text fields
            user.foreName = NameBox1.Text;
            user.surName = SurnameBox.Text;
            user.email = EmailBox.Text;
            user.phoneNumber = PhoneBox.Text;

            // Save the updated data (e.g., to a database or local storage)
            SaveUserData(user);

            // Return to the profile screen with the updated user data
            form.SwitchForm(new UI_Profile(form, user));
        }

        // Method to save the user data
        // This could involve saving to a database or other storage mechanisms
        private void SaveUserData(User user)
        {
            // Here you can implement the logic to save user data to a database or local storage.
            // For example, using an ORM (Entity Framework) or direct SQL queries.

            // Example with pseudocode:
            // dbContext.Users.Update(user);
            // dbContext.SaveChanges();
        }
    }
}

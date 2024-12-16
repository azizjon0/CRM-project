using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_App
{
    //Creators: Aziz (UI), Yusef (Code), Elliot (Code)

    //Displays a user's profile
    public partial class UI_Profile : UserControl
    {
        FormUI form;
        User user;

        public UI_Profile(FormUI form, User user)
        {
            InitializeComponent();
            this.form = form;
            this.user = user;

            //Display user information on the UI
            lblHeader.Text = user.GetNameAsString();
            lblUserFullName.Text = $"Full Name: {user.GetNameAsString()}";
            lblEmailAddress.Text = $"Email address: {user.email}";
            lblUserPhoneNumber.Text = $"Phone number: {user.phoneNumber}";
            lblSubStatus.Text = $"Subscription status: {user.status}";
            pctProfileImage.ImageLocation = user.imageLink;

            //Hides the edit profile button if viewing another user's profile
            if (user != form.user)
            {
                edit_BT.Visible = false;
            }
        }

        //Switch to profile edit view
        private void edit_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Edit_Profile(form, user));
        }

        private void edit_BT_Click_1(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Edit_Profile(form, user));
        }
    }
}

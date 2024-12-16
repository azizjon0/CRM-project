using Microsoft.VisualBasic.ApplicationServices;
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
    //Creator: Aziz

    public partial class UI_MainPage : UserControl
    {
        private FormUI form;
        private User user;

        public UI_MainPage(FormUI form, User user)
        {
            InitializeComponent();
            this.form = form;
            this.user = user;


            label1.Text = $"Hi, {user.GetNameAsString()}";
        }

        private void Profile_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Profile(form, form.user));
        }

        private void Subscription_BT_Click(object sender, EventArgs e)
        {
            //form.SwitchForm(new Subscription(form, form.user));
        }

        private void event_name_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_EventSearch(form));
        }

        private void Profile_BT_Click_1(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Profile(form, form.user));
        }
    }
}

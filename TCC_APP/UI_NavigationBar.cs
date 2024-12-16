using CRMApplication;
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
    public partial class UI_NavigationBar : UserControl
    {
        //Creator: Elliot

        //Navigation bar which is displayed alongside every page (past login) which contains buttons that link to other pages

        FormUI form;

        public UI_NavigationBar(FormUI form)
        {
            InitializeComponent();
            this.form = form;

        }


        //Below functions handle switching to different forms
        private void Main_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_MainPage(form, form.user));
        }

        private void events_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_EventSearch(form));
        }

        private void users_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_UserSearch(form));
        }

        private void profile_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Profile(form, form.user));
        }

        private void admin_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Admin(form));
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void logout_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Login(form));
        }

        private void logo_Click_1(object sender, EventArgs e)
        {

        }
    }
}

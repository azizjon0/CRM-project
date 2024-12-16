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
    //Creator: Elliot

    //Placeholder User Control which the project will load into (until it is eventually replaced with the login screen)
    //Contains buttons which link directly to other User Controls, so that we can navigate the project before the navigation bar has been implemented

    public partial class placeholder : UserControl
    {
        //Stores a reference to FormUI
        //This enables form.SwitchForm to be called from within this class
        FormUI form;


        //Constructor takes a reference to FormUI
        public placeholder(FormUI form)
        {
            InitializeComponent();

            //Storing reference to FormUI
            this.form = form;
        }


        //Displays the event search page
        private void buttonEvents_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_EventSearch(form));
        }

        private void buttonEvents_Click_1(object sender, EventArgs e)
        {

        }
    }
}

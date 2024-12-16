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
//By Yusef
namespace TCC_App
{
    public partial class UI_Admin : UserControl
    {
        private FormUI form;
        public UI_Admin(FormUI form)
        {
            InitializeComponent();
            this.form = form;
            ShowUserControl(new AddUserControl());
        }
        private void ShowUserControl(UserControl userControl)
        {
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl);
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ViewFeedbackControl());
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ViewAdminRequests());
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            ShowUserControl(new RemoveUserControl());
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            ShowUserControl(new AddUserControl());
        }

        private void btnViewAnalytics_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ViewUserTagControl());
        }

        private void btnScheduleAnnouncement_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ViewCurrentVisitorControl());
        }

        private void UI_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}

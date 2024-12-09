using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MainPage.Pages
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void edit_BT_Click(object sender, EventArgs e)
        {
            Profile_edit Profile_edit = new Profile_edit();
            Profile_edit.Show();
            Profile_edit.Left = (this.ClientSize.Width - Profile_edit.Width) / 2;
            Profile_edit.Top = (this.ClientSize.Height - Profile_edit.Height) / 2;
        }

        private void Main_BT_Click(object sender, EventArgs e)
        {
            Form1 Form1= new Form1();
            Form1.Show();
            this.Close();
        }
    }
}

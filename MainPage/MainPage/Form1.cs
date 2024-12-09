using MainPage.Pages;

namespace MainPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Profile_BT_Click(object sender, EventArgs e)
        {
            Profile secondForm = new Profile();
            secondForm.Show();
            this.Hide();



        }
    }
}

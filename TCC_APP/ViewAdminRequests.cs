using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
//by yusef
namespace CRMApplication
{
    public partial class ViewAdminRequests : UserControl
    {
         public ViewAdminRequests()
        {
            InitializeComponent();
            LoadAdminRequestData();
            dataGridViewAdminRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAdminRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void LoadAdminRequestData()
        {
            string query = "SELECT * from adminrequests";
            DataTable dataTable = DatabaseHandler.ExecuteQuery(query);
            dataGridViewAdminRequests.DataSource = dataTable;
        }


        private void btndeleterequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No DB is Attached");
           
            }

        

        private void ViewAdminRequests_Load(object sender, EventArgs e)
        {
        }


        private void dataGridViewAdminRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewAdminRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("No DB is Attached");

        }
    }
}

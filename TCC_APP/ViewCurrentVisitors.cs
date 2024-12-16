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
using Google.Protobuf.WellKnownTypes;
using System.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
//by yusef
namespace CRMApplication
{
    public partial class ViewCurrentVisitorControl : UserControl
    {
        public ViewCurrentVisitorControl()
        {
            InitializeComponent();
            LoadVisitorData();
            dataGridViewVisitors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVisitors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void LoadVisitorData()
        {
            string query = "SELECT * from visitorlog";
            DataTable dataTable = DatabaseHandler.ExecuteQuery(query);
            dataGridViewVisitors.DataSource = dataTable;
        }



    private void ScheduleAnnouncementControl_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveVisitors(object sender, EventArgs e)
        {
            MessageBox.Show("No DB is Attached");
          
        }


        private void dataGridViewVisitors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewVisitors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("No DB is Attached");
            
        }
    }
}

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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
//by yusef
namespace CRMApplication
{
    public partial class ViewFeedbackControl : UserControl
    {
        public ViewFeedbackControl()
        {
            InitializeComponent();
            LoadFeedbackData();
            dataGridViewFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFeedback.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void LoadFeedbackData()
        {
            string query = "SELECT * from feedback";
            DataTable dataTable = DatabaseHandler.ExecuteQuery(query);
            dataGridViewFeedback.DataSource = dataTable;

            
        }


        private void btnremovefeedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No DB is Attached");

        }




        private void dataGridViewFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void ViewFeedbackControl_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("No DB is Attached");
        }
    }
}

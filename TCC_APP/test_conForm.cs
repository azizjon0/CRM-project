using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration; // For ConfigurationManager

namespace TCC_App
{
    public partial class test_conForm : Form
    {
        public test_conForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Retrieve the connection string from App.config
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Attempt to open the connection

                    // Show a success message
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    // Show an error message if the connection fails
                    MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

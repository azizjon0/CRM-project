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

namespace CRMApplication
{
    public partial class RemoveUserControl : UserControl
    {
        public RemoveUserControl()
        {
            InitializeComponent();
            LoadUserData();
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        private void LoadUserData()
        {
            DataTable dataTable = new DataTable();

            
            dataTable.Columns.Add("UserID", typeof(string));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * from user";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userId = reader["UserID"].ToString(); 
                            string foreName = reader["FirstName"].ToString();
                            string surName = reader["LastName"].ToString();
                            string phoneNumber = reader["PhoneNumber"].ToString();
                            string email = reader["Email"].ToString();
                            string status = reader["Status"].ToString();
                           

                            dataTable.Rows.Add(userId, foreName, surName, phoneNumber, email, status);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load Users: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dataGridViewUsers.DataSource = dataTable;
        }



        private void btnRemoveUser(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                // Get the UserID of the selected user
                string selectedUserId = dataGridViewUsers.SelectedRows[0].Cells["UserID"].Value.ToString();

                // Confirmation dialog
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this user?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM `user` WHERE `UserID` = @UserID";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("User removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadUserData(); // Refresh the data grid view
                                }
                                else
                                {
                                    MessageBox.Show("Failed to remove user. User may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while removing the user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void RemoveUserForm_Load(object sender, EventArgs e)
        {
        }
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        

        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // For Testing the select feature
            //MessageBox.Show(dataGridViewUsers.SelectedCells.ToString());
        }
    }
    
}

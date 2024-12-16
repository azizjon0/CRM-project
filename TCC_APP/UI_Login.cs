using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMApplication;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System.Security.Cryptography;
namespace TCC_App // By Rusho
{
    public partial class UI_Login : UserControl
    {
        static string BytesToString(byte[] arrInput)
        {
            StringBuilder tmp =
                new StringBuilder(arrInput.Length);
            for
            (int i = 0;
            i < arrInput.Length;
            ++i)
            {
                tmp
                .Append(arrInput[i]
                .ToString("X")); // Uppercase hexadecimal
            }
            return tmp.ToString();
        }
        static string HashThis(string notMyPassword)
        {
            return BytesToString
            (
                new
                MD5CryptoServiceProvider()
                .ComputeHash
                (
                    ASCIIEncoding
                    .ASCII
                    .GetBytes
                    (
                        notMyPassword
                    )
                )
            );
        }
        private FormUI form;
        public UI_Login(FormUI form) // Death
        {
            InitializeComponent();
            this.form = form;
            // ShowUserControl(new UI_Login(form));
            // ShowUserControl(new AddUserControl());
            // panelMain.Controls.Add(new UI_Login(this));
            User dummyUser = new User("Example", "User", "notReal123@fake.com", "123 456789", "Active", "N/A", DateTime.Now);
            form.LoadMainUI(dummyUser);
        }

        private void ShowUserControl(UserControl userControl)
        {
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl);
            // form.LoadMainUI(user);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            try
            {
                string searchTerm = txtEmail.Text;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // SQL query for insertion
                    string query = string.IsNullOrEmpty(searchTerm)
                        ? "SELECT * FROM user"
                        : "SELECT * FROM user WHERE Email = \'@searchTerm\'";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", searchTerm);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    string passwordCurrent = txtPassword.Text;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string hashedPasswordCurrent = "";
                            string foreName = reader["FirstName"].ToString();
                            string surName = reader["LastName"].ToString();
                            string email = reader["Email"].ToString();
                            string phoneNumber = reader["PhoneNumber"].ToString();
                            string status = reader["Status"].ToString();
                            string profilePictureAddress = reader["ProfilePictureAddress"].ToString();
                            string hashedPassword = reader["HashedPassword"].ToString();
                            User u = new User(
                                foreName,
                                surName,
                                email,
                                phoneNumber,
                                status,
                                profilePictureAddress,
                                DateTime.Now
                            );
                            hashedPasswordCurrent = hashedPassword;

                            if (hashedPasswordCurrent == HashThis(txtPassword.Text))
                            {
                                MessageBox.Show("Logged in successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form.LoadMainUI(u);
                                form.SwitchForm(new UI_Profile(form, form.user));
                            }
                            else
                            {
                                MessageBox.Show("Either your username or your password does not match.", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
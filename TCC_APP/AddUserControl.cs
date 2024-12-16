using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace CRMApplication
{
    public partial class AddUserControl : UserControl
    {
        public AddUserControl()
        {
            InitializeComponent();
            txtHashedPassword.PasswordChar = '*';

        }

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

        private void AddUserControl_Load(object sender, EventArgs e)
        {
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtHashedPassword.Text) ||
                cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query for insertion
                    string query = @"INSERT INTO `user` 
                            (`FirstName`, `LastName`, `PhoneNumber`, `Email`, `HashedPassword`, `Status`, `ProfilePictureAddress`) 
                            VALUES 
                            (@FirstName, @LastName, @PhoneNumber, @Email, @HashedPassword, @Status, @ProfilePictureAddress)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Parameters
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@HashedPassword", HashThis(txtHashedPassword.Text)); // couldn't find the hash pass function
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@ProfilePictureAddress", selectedImagePath);

                        // Creating DB
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields(); // Clear form after successful insertion
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while Creating the User: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

  
           
        }

        private void ClearFormFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtHashedPassword.Clear();
            cmbStatus.SelectedIndex = -1;
            pictureBoximage.Image = null;
            selectedImagePath = string.Empty;
        }
    
        private string selectedImagePath = string.Empty;

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    pictureBoximage.Image = Image.FromFile(selectedImagePath);
                }
            }
        }


    }
}


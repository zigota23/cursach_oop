using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BCrypt;

namespace cursach
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private string connectionString = "Server = localhost ; port = 5432; user id = postgres; password = root; database = cursach;";
        private void submitButton_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;
            string firstname = firstNameField.Text;
            string lastname = lastNameField.Text;
            RegisterUser(email, password, firstname, lastname);
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
            this.Hide();
        }
        private void RegisterUser(string email, string password, string firstname, string lastname)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                    connection.Open();
                    if (connection.State == ConnectionState.Closed)
                    {
                        MessageBox.Show($"Error connection!");
                    }
                    
                    using (NpgsqlCommand cmdCheckUser = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE email = @email", connection))
                    {
                        cmdCheckUser.Parameters.AddWithValue("email", email);

                        int userCount = Convert.ToInt32(cmdCheckUser.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("User with this email already exists");
                            connection.Close();
                        } else { 
                        using (NpgsqlCommand cmd = new NpgsqlCommand())
                        {
                            string hashpass = BCrypt.Net.BCrypt.HashPassword(password);
                            cmd.Connection = connection;
                            cmd.CommandText = "INSERT INTO users (email, hashpass , firstname , lastname) VALUES (@email, @hashpass , @firstname , @lastname)";
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@hashpass", hashpass);
                            cmd.Parameters.AddWithValue("@firstname", firstname);
                            cmd.Parameters.AddWithValue("@lastname", lastname);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successful registration.");
                            connection.Close();
                        }
                                }
                    }
            }
            
        }
        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

    }
}

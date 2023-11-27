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
        }
        private void RegisterUser(string email, string password, string firstname, string lastname)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        Console.WriteLine(connection.State);
                    }
                    else
                    {
                        MessageBox.Show($"Error connection!");
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO users (email, password , firstname , lastname) VALUES (@email, @password , @firstname , @lastname)";
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.ExecuteNonQuery();
                    }
                }


                catch
                {
                    //MessageBox.Show($"Error connection!");
                }
                MessageBox.Show("Successful registration.");
                connection.Close();
                Console.WriteLine(connection.State);
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

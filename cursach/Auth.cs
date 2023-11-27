using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    internal class Auth
    {
        private string connectionString = "Server = localhost ; port = 5432; user id = postgres; password = root; database = cursach;";
        public void AutorizationUser(string email, string password, AuthorizationForm authForm)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM users WHERE email = @email", connection))
                {
                    cmd.Parameters.AddWithValue("email", email);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPasswordFromDB = reader["hashpass"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDB))
                            {
                                MessageBox.Show("Login successful");
                                VoteForm form = new VoteForm();
                                form.Show();
                                authForm.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found");
                        }
                    }
                }

                connection.Close();


            }
        }
        public void RegisterUser(string email, string password, string firstname, string lastname)
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
                    }
                    else
                    {
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
    }
}

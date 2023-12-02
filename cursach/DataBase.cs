using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    internal class DataBase
    {
        private static string connectionString = "Server = localhost ; port = 5432; user id = postgres; password = root; database = cursach;";
        private int loggedInUserId;
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
                            Guid userId = reader.GetGuid(0);
                            string hashedPasswordFromDB = reader["hashpass"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDB))
                            {
                                MessageBox.Show("Login successful");
                                GlobalData.LoggedInUserId = userId;
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
                            cmd.CommandText = "INSERT INTO users (id, email, hashpass , firstname , lastname) VALUES (uuid_generate_v4(), @email, @hashpass , @firstname , @lastname)";
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
        public static void LogOut() {
            GlobalData.LoggedInUserId = Guid.Empty;
        }
        public static void CreateTables()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS users (id UUID PRIMARY KEY, email VARCHAR(50) UNIQUE, hashPass VARCHAR(200),firstName VARCHAR(50),  lastName VARCHAR(50) )";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS votes (id UUID PRIMARY KEY, title VARCHAR(255), description VARCHAR(255), creatorId UUID NOT NULL, createAt VARCHAR(255), FOREIGN KEY (creatorId) REFERENCES users(id) )";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS votes_users_result (userId UUID NOT NULL, voteId UUID NOT NULL, result BOOLEAN NOT NULL, FOREIGN KEY (userId) REFERENCES users(id), FOREIGN KEY (voteId) REFERENCES votes(id), UNIQUE (userId, voteId) )";
                    cmd.ExecuteNonQuery();
                }
                connection.Close();

            }
        }

        public static bool FindUsersVotes(int userId, int voteId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string findVotesQuery = "SELECT result FROM votes_users_result WHERE userId = @UserId AND voteId = @VoteId;";

                using (NpgsqlCommand command = new NpgsqlCommand(findVotesQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@VoteId", voteId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetBoolean(0);
                        }
                    }
                }
                return false;
            }
        }

        public static void CreateVote(string title, string description,Guid creatorId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string insertVoteQuery = "INSERT INTO votes (id, title, description, creatorId, createAt) VALUES (uuid_generate_v4(),@Title, @Description, @creatorId, @createAt);";
                using (NpgsqlCommand command = new NpgsqlCommand(insertVoteQuery, connection))
                {
                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@creatorId", creatorId);
                    command.Parameters.AddWithValue("@createAt", sqlFormattedDate);
                    
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void AddUserVoteResult(int userId, int voteId, bool result)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string insertResultQuery = "INSERT INTO votes_users_result (userId, voteId, result) VALUES (@UserId, @VoteId, @Result);";
                using (NpgsqlCommand command = new NpgsqlCommand(insertResultQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@VoteId", voteId);
                    command.Parameters.AddWithValue("@Result", result);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static List<string> GetVoteTitles()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string getTitlesQuery = "SELECT title FROM votes;";

                using (NpgsqlCommand command = new NpgsqlCommand(getTitlesQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> titles = new List<string>();
                        while (reader.Read())
                        {
                            titles.Add(reader.GetString(0));
                        }
                        return titles;
                    }
                }
            }
        }

        public static Guid GetVoteIdByTitle(string title)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string getIdQuery = "SELECT id FROM votes WHERE title = @Title;";

                using (NpgsqlCommand command = new NpgsqlCommand(getIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetGuid(0);
                        }
                        throw new InvalidOperationException("can`t find by this title");;
                    }
                }
            }
        }
        public static List<(Guid Id, string Title, string Description)> GetVotes()
        {
            List<(Guid Id, string Title, string Description)> votes = new List<(Guid Id, string Title, string Description)>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string getVotesQuery = "SELECT id, title, description FROM votes;";

                using (NpgsqlCommand command = new NpgsqlCommand(getVotesQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Guid voteId = reader.GetGuid(0);
                            string title = reader.GetString(1);
                            string description = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                            votes.Add((voteId, title, description));
                        }
                    }
                }
            }
            return votes;
        }
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        public static bool IsValidPassword(string password)
        {
            return password.Length >= 6;
        }

        public static bool IsConfirmedPassword(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
    }
}

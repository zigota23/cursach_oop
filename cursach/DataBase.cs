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
    internal class DataBase
    {
        private string connectionString = "Server = localhost ; port = 5432; user id = postgres; password = root; database = cursach;";
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
                            int userId = reader.GetInt32(0);
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
        public void CreateTables()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS users (id SERIAL PRIMARY KEY, email VARCHAR(50) UNIQUE, hashPass VARCHAR(200),firstName VARCHAR(50),  lastName VARCHAR(50) )";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS votes (id SERIAL PRIMARY KEY, title VARCHAR(255), description VARCHAR(255) )";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS votes_users_result (userId SERIAL NOT NULL, voteId SERIAL NOT NULL, result BOOLEAN NOT NULL, FOREIGN KEY (userId) REFERENCES users(id), FOREIGN KEY (voteId) REFERENCES votes(id), UNIQUE (userId, voteId) )";
                    cmd.ExecuteNonQuery();
                }
                connection.Close();

            }
        }
        /*public void FindUsersVotesResult()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT v.id AS VoteID, v.title AS VoteTitle, v.descrption AS VoteDescription, vur.result AS VoteResult FROM votes_users_result vur JOIN votes v ON vur.voteId = v.id WHERE vur.userId = 1;";
                    //cmd.ExecuteNonQuery();
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}", reader.GetInt32(0),
                                reader.GetString(1), reader.GetString(2));
                        }

                        if (reader.Read())
                        {
                            string result = reader["result"].ToString();
                            string voteId = reader["voteId"].ToString();
                            string msg = voteId + ":" + result;
                            Console.WriteLine(msg);
                        }
                    }
                }

            }
        }
        public Boolean FindUsersVotes(int userId, int voteId)
        {
            return true;
        }
        */
        public bool FindUsersVotes(int userId, int voteId)
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

        public void CreateVote(string title, string description)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string insertVoteQuery = "INSERT INTO votes (title, description) VALUES (@Title, @Description);";
                using (NpgsqlCommand command = new NpgsqlCommand(insertVoteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void AddUserVoteResult(int userId, int voteId, bool result)
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
        public List<string> GetVoteTitles()
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

        public int GetVoteIdByTitle(string title)
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
                            return reader.GetInt32(0);
                        }
                        return -1;
                    }
                }
            }
        }

    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    public partial class VoteAddForm : Form
    {
        private string connectionString = "Server = localhost ; port = 5432; user id = postgres; password = root; database = cursach;";
        public VoteAddForm()
        {
            InitializeComponent();
        }

        private void CreateNewVotingButton_Click(object sender, EventArgs e)
        {
            string newVotingQuestion = titleField.Text;

            if (!string.IsNullOrEmpty(newVotingQuestion))
            {
                AddNewVotingQuestionToDatabase(newVotingQuestion);
                MessageBox.Show("New vote created!");
            }
            else
            {
                MessageBox.Show("New question text.");
            }
        }
        private void AddNewVotingQuestionToDatabase(string question)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO voting_questions (question) VALUES (@question)";
                    cmd.Parameters.AddWithValue("@question", question);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}

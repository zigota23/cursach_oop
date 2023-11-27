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
    public partial class VoteForm : Form
    {
        private string connectionString = "Server = localhost ; port = 5432; user id = postgres; password = root; database = cursach;";
        public VoteForm()
        {
            InitializeComponent();
            LoadVotingQuestionsFromDatabase();
            DisplayCurrentVotingQuestion();
        }

        private List<string> votingQuestions = new List<string>();
        private int currentQuestionIndex = 0;

        private void DisplayCurrentVotingQuestion()
        {
            if (votingQuestions.Count > 0 && currentQuestionIndex < votingQuestions.Count)
            {
                textBoxVotingQuestion.Text = votingQuestions[currentQuestionIndex];
            }
            else
            {
                textBoxVotingQuestion.Text = "No votes.";
            }
        }

        private void LoadVotingQuestionsFromDatabase()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT question FROM voting_questions";

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string question = reader["question"].ToString();
                            votingQuestions.Add(question);
                        }
                    }
                }
            }
        }

        private void NextVotingQuestionButton_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            if (currentQuestionIndex >= votingQuestions.Count)
            {
                MessageBox.Show("All votes gone.");
                currentQuestionIndex = 0;
            }
            DisplayCurrentVotingQuestion();
        }

    }
}

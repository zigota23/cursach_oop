using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace cursach.controls
{
    public partial class VoteItem : UserControl
    {
        public string title;
        public string description;
        private static string connectionString = "Server = localhost ; port = 5432; user id = postgres; password = maxim; database = users;";

        public VoteItem(string title, string description, string createAt)
        {
            InitializeComponent();
            titleLabel.Text = title;
            descriptionLabel.Text = description;
            lblCreateAt.Text = createAt;
            this.title = title;
            this.description = description;
        }

        private void VoteItem_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Name))
                {
                    Guid voteId = Guid.Parse(this.Name);
                    Guid userId = GlobalData.LoggedInUserId;

                    bool isUserCreator = DataBase.IsUserCreatorOfVote(userId, voteId);

                    // Установка видимости кнопки в зависимости от того, является ли пользователь создателем
                    clsVote.Visible = isUserCreator;

                    Console.WriteLine(isUserCreator);
                }
                else
                {
                    Console.WriteLine("Name не содержит информацию о дате и времени.");
                    HideVoteButton(); // Если произошла ошибка, скрываем кнопку
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HideVoteButton(); // Если произошла ошибка, скрываем кнопку
            }
        }

        private void HideVoteButton()
        {
            clsVote.Visible = false;
        }

        private void clsVote_Click(object sender, EventArgs e)
        {

            var objectIdToDelete = Guid.Parse(this.Name);

            var deleteSql = $"DELETE FROM votes_users_result WHERE voteid = '{objectIdToDelete}'";
            var deleteSql1 = $"DELETE FROM votes WHERE id = '{objectIdToDelete}'";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand(deleteSql, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new NpgsqlCommand(deleteSql1, connection))
                {
                    command.ExecuteNonQuery();
                }

                this.Parent.Controls.Remove(this);
            }
        }
    }
}
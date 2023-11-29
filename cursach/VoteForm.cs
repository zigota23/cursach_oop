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
        private DataBase database = new DataBase();
        public VoteForm()
        {
            InitializeComponent();
            LoadQuestions(); 
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(GlobalData.LoggedInUserId);
            string selectedQuestion = questionComboBox.SelectedItem.ToString();
            int voteId = database.GetVoteIdByTitle(selectedQuestion);
        }
        private void LoadQuestions()
        {
            List<string> questionTitles = database.GetVoteTitles(); 
            questionComboBox.DataSource = questionTitles; 
        }
    }
}

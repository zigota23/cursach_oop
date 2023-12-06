using System;
using System.Windows.Forms;

namespace cursach
{
    public partial class VoteAddForm : Form
    {


        private Action onAdd;
        public VoteAddForm(Action onAdd)
        {
            InitializeComponent();
            this.onAdd = onAdd;
        }

        private void CreateNewVotingButton_Click(object sender, EventArgs e)
        {
            string newVotingQuestion = titleField.Text;

            if (string.IsNullOrEmpty(newVotingQuestion))
            {
                MessageBox.Show("New question text.");
                return;
            }

            try
            {
                DataBase.AddNewVotingQuestionToDatabase(newVotingQuestion);
                MessageBox.Show("New vote created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string field1 = titleField.Text;
            string field2 = descriptionField.Text;

            if (string.IsNullOrEmpty(field1) || string.IsNullOrEmpty(field2))
            {
                MessageBox.Show("Fill both fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataBase.CreateVote(field1, field2, GlobalData.LoggedInUserId);
                MessageBox.Show("Vote saved successful", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.onAdd();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

using System;
using System.Windows.Forms;

namespace cursach
{
    public partial class VoteAddForm : Form
    {



        public VoteAddForm()
        {
            InitializeComponent();

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


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

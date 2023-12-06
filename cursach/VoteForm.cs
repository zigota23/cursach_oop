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
        private Guid voteId;
        public VoteForm(Guid voteId, string title, string description)
        {
            InitializeComponent();
            titleLabel.Text = title;
            descriptionLabel.Text = description;
            this.voteId = voteId;

        }

        private void setResult(bool result)
        {
            try
            {
                DataBase.AddUserVoteResult(GlobalData.LoggedInUserId, this.voteId, result);
                MessageBox.Show("Thanks!");
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void noButton_Click(object sender, EventArgs e)
        {
            setResult(false);
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            setResult(true);
        }
    }
}

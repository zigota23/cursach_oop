using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cursach.controls
{
    public partial class VoteList : UserControl
    {
        public VoteList()
        {
            InitializeComponent();
            this.Load += new EventHandler(VoteList_Shown);
        }


        private void VoteItem_Click(object sender, EventArgs e)
        {
            Guid voteId = new Guid(((VoteItem)sender).Name);
            try
            {
                bool result = DataBase.IsUserAnswerThisVote(GlobalData.LoggedInUserId, voteId);
                string message = result ? "You already voited 'Yes'" : "You already voited 'No'";
                MessageBox.Show(message);
            }
            catch
            {

                string title = ((VoteItem)sender).title;
                string description = ((VoteItem)sender).description;
                new VoteForm(voteId, title, description).ShowDialog();
            }
        }


        private void updateData()
        {
            try
            {
                List<Vote> list = DataBase.GetVotes();
                int count = 0;
                list.ForEach(delegate (Vote item)
                {
                    VoteItem control = new VoteItem(item.title, item.description, item.createAt);
                    control.Location = new Point(25, 95 * count);
                    control.Click += VoteItem_Click;
                    control.Name = item.id.ToString();

                    voteListPanel.Controls.Add(control);
                    count++;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VoteList_Shown(Object sender, EventArgs e)
        {
            updateData();
        }
        private void addVoteButton_Click(object sender, EventArgs e)
        {
            new VoteAddForm(updateData).ShowDialog();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string id = ((VoteItem)sender).Name;
            Guid voteId = new Guid(id);
            try
            {
                bool result = DataBase.IsUserAnswerThisVote(GlobalData.LoggedInUserId, voteId);
                if (result) { MessageBox.Show("You already voited yes"); }
                else { MessageBox.Show("You already voited no"); }
            } catch {
                
                string title = ((VoteItem)sender).title;
                string description = ((VoteItem)sender).description;
                VoteForm form = new VoteForm(voteId, title, description);
                form.ShowDialog();
            }
        }


        private void updateData()
        {
            List<Vote> list = DataBase.GetVotes();
            int count = 0;
            list.ForEach(delegate (Vote item)
            {
                VoteItem control = new VoteItem(item.title, item.description, item.createAt);
                control.Location = new Point(25, 110 * count);
                control.Click += VoteItem_Click;
                control.Name = item.id.ToString();
                

                Console.WriteLine(item.id);
                voteListPanel.Controls.Add(control);
                count++;
            });
        }
        private void VoteList_Shown(Object sender, EventArgs e) {
            updateData();
        }
        private void addVoteButton_Click(object sender, EventArgs e)
        {
            VoteAddForm voteAddForm = new VoteAddForm(updateData);
            voteAddForm.ShowDialog();
        }
    }
}

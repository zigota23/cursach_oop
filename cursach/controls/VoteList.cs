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
        private void VoteList_Shown(Object sender, EventArgs e) {
            List<Vote> list = DataBase.GetVotes();
            int count = 0;
            list.ForEach(delegate (Vote item)
            {
                VoteItem control = new VoteItem(item.title, item.description);
                control.Location = new Point(25, 110 * count);
                Console.WriteLine(item.id);
                voteListPanel.Controls.Add(control);
                count++;
            });
        }
        private void addVoteButton_Click(object sender, EventArgs e)
        {
            VoteAddForm voteAddForm = new VoteAddForm();
            voteAddForm.ShowDialog();
        }
    }
}

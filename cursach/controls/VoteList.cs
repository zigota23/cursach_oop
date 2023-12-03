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
        }

        private void addVoteButton_Click(object sender, EventArgs e)
        {
            VoteAddForm voteAddForm = new VoteAddForm();
            voteAddForm.ShowDialog();
        }
    }
}

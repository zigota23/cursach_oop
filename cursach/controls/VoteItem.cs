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
    public partial class VoteItem : UserControl
    {
        
        public string title;
        public string description;
        public VoteItem(string title,string description,string createAt)
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
            try { 
            Guid voteId = new Guid(this.Name);
            bool result = DataBase.IsUserAnswerThisVote(GlobalData.LoggedInUserId, voteId);
            Console.WriteLine(result);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

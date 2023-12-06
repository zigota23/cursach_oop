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
                    clsVote.Visible = isUserCreator;

                    
                }
                else
                {
                    clsVote.Visible = false;
                }
            }
            catch (Exception ex)
            {
                clsVote.Visible = false;
                MessageBox.Show(ex.Message);
            }
        }


        private void clsVote_Click(object sender, EventArgs e)
        {
            VoteDeleteForm form = new VoteDeleteForm(); 

            if(form.ShowDialog() == DialogResult.No)
            {
                return;
            }

            try
            {
                var voteId = Guid.Parse(this.Name);
                DataBase.deleteVote(voteId);
                this.Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
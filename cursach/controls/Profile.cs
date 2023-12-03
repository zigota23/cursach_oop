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
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
            this.Load += new EventHandler(Profile_Shown);
            
        }
        private void Profile_Shown(Object sender, EventArgs e)
        {
            if (GlobalData.LoggedInUserId == null) {
                return;
            }
            try
            {
                User info = DataBase.GetInfoById(GlobalData.LoggedInUserId);
                lblFirstName.Text = info.firstName;
                lblLastName.Text = info.lastName;
                lblEmail.Text = info.email;
                lblCreatedVotes.Text = info.createdQuestions.ToString();
                lblVoteCast.Text = info.answeredQuestions.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } 
    }
}

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

        User user {  get; set; }
        public Profile()
        {
            InitializeComponent();
            this.Load += new EventHandler(Profile_Shown);
        }

        private void Profile_Shown(object sender, EventArgs e)
        {
            try
            {
                if (GlobalData.LoggedInUserId == null)
                {
                    return;
                }

                user = DataBase.GetInfoById(GlobalData.LoggedInUserId);

                if (user != null)
                {
                    lblFirstName.Text = user.firstName;
                    lblLastName.Text = user.lastName;
                    lblEmail.Text = user.email;
                    lblCreatedVotes.Text = user.createdQuestions.ToString();
                    lblVoteCast.Text = user.answeredQuestions.ToString();
                }
                else
                {
                    MessageBox.Show("User don't found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EditProfileForm editProfileForm = new EditProfileForm(user.email,user.firstName,user.lastName);
                if (editProfileForm.ShowDialog() == DialogResult.OK)
                {
                    Profile_Shown(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

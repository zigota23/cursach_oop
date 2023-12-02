using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace cursach
{
    public partial class AuthorizationForm : Form
    {
        
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;
            try { 
                Guid userId = DataBase.AutorizationUser(email, password);
                GlobalData.LoggedInUserId = userId;
                GlobalData.AuthorizationForm.Hide();
                GlobalData.VoteForm.Show();
            }
            catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }
        
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            GlobalData.AuthorizationForm.Hide();
            GlobalData.RegistrationForm.Show();
        }

        private void OnFormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

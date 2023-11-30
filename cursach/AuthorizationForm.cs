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
        private DataBase authorization = new DataBase();
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;
            authorization.AutorizationUser(email, password, this);
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

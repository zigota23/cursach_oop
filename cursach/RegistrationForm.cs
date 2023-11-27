using Npgsql;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BCrypt;

namespace cursach
{
    public partial class RegistrationForm : Form
    { 
        Auth reg = new Auth();
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;
            string firstname = firstNameField.Text;
            string lastname = lastNameField.Text;
           
            reg.RegisterUser(email, password, firstname, lastname);
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

    }
}

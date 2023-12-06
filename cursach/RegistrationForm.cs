using System;
using System.Windows.Forms;

namespace cursach
{
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;
            string firstname = firstNameField.Text;
            string lastname = lastNameField.Text;
            string confirmPassword = repeatPasswordField.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords don't match", "Validation data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!(Validation.IsValidEmail(email) && Validation.IsValidPassword(password)))
            {
                MessageBox.Show("Entered Email and (or) Password are not valid.", "Validation Email & Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            try
            {
                DataBase.RegisterUser(email, password, firstname, lastname);
                MessageBox.Show("Successful registration.");
                GlobalData.RegistrationForm.Hide();
                GlobalData.AuthorizationForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void LogInButton_Click(object sender, EventArgs e)
        {
            GlobalData.RegistrationForm.Hide();
            GlobalData.AuthorizationForm.Show();
        }
    }
}

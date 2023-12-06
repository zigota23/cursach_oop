using System;
using System.Windows.Forms;


namespace cursach
{
    public partial class AuthorizationForm : Form
    {
        
        public AuthorizationForm()
        {
            InitializeComponent();
        }


        private void clearFields()
        {
            emailField.Text = "";
            passwordField.Text = "";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;
            try { 
                GlobalData.LoggedInUserId = DataBase.AutorizationUser(email, password);

                clearFields();

                GlobalData.AuthorizationForm.Hide();
                GlobalData.MainApp.Show();
            }
            catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }
        
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            clearFields();

            GlobalData.AuthorizationForm.Hide();
            GlobalData.RegistrationForm.Show();
        }
        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
             new ForgotPassword().ShowDialog();
        }


    }
}

using System;
using System.Windows.Forms;

namespace cursach
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;
            string repeatPassword = repeatPasswordField.Text;

            if(password != repeatPassword)
            {
                MessageBox.Show("Passwords don`t match");
                return;
            }

            try{

                DataBase.ForgotPassword(email, password);
                MessageBox.Show("Password changed.");
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

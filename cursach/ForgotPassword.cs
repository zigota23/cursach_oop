using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string password = passwordField.Text;
            string repeatPassword = repeatPasswordField.Text;
            string email = emailField.Text;
            if(password != repeatPassword)
            {
                MessageBox.Show("Passwords don`t match");
                return;
            }
            DataBase.ForgotPassword(email, password);
        }
    }
}

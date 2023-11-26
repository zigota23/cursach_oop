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
           
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            this.Hide();
        }
    }
}

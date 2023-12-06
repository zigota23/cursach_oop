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
    public partial class EditProfileForm : Form
    {
        public EditProfileForm(string email, string firstName, string lastName)
        {
            InitializeComponent();

            textBoxEmail.Text = email; 
            textBoxFirstName.Text = firstName; 
            textBoxLastName.Text = lastName;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newEmail = textBoxEmail.Text;
                string newFirstName = textBoxFirstName.Text;
                string newLastName = textBoxLastName.Text;

                DataBase.UpdateUserInfo(newEmail, newFirstName, newLastName);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

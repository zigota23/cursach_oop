using Npgsql;
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
    public partial class EditProfileForm : Form
    {

        public EditProfileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newFirstName = textBoxFirstName.Text;
                string newLastName = textBoxLastName.Text;
                string newEmail = textBoxEmail.Text;

                DataBase.UpdateUserInfo(newEmail, newFirstName, newLastName);

                /*this.DialogResult = DialogResult.OK;*/
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

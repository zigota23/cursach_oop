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
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();

            profileControl.Show();
            contactControl.Hide();
            voteListControl.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            profileControl.Show();
            contactControl.Hide();
            voteListControl.Hide();

        }

        private void Contact_Click(object sender, EventArgs e)
        {
            contactControl.Show();
            profileControl.Hide();
            voteListControl.Hide();
        }

        private void Vote_Click(object sender, EventArgs e)
        {
            voteListControl.Show();
            contactControl.Hide();
            profileControl.Hide();
        }


        private void LogOut_Click(object sender, EventArgs e)
        {
            DataBase.LogOut();
        }
    }
}

﻿using Npgsql;
using System;
using System.Text.RegularExpressions;
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
        DataBase registration = new DataBase();
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
            string confirmPassword = repeatPasswordField.Text;

            if(!Validation.IsConfirmedPassword(password, confirmPassword))
            {
                MessageBox.Show("Пароли не совпадают", "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (Validation.IsValidEmail(email) && Validation.IsValidPassword(password))
                {
                    registration.RegisterUser(email, password, firstname, lastname);
                    GlobalData.RegistrationForm.Hide();
                    GlobalData.AuthorizationForm.Show();
                }
                else
                {
                    MessageBox.Show("Введенные Email и(или) Пароль не являются действительными.", "Проверка Email и Пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {          
            GlobalData.RegistrationForm.Hide();
            GlobalData.AuthorizationForm.Show();
        }

        private void OnFormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

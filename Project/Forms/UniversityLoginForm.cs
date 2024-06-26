﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Project.Forms;
using Project.Models;
using Project.Repository;
using Project.Utilitys;
using static Project.Utilitys.Constants;


namespace Project.Forms
{
    public partial class UniversityLoginForm : MaterialForm
    {
        public UniversityLoginForm()
        {
            InitializeComponent();
            MaterialFormSkinChanger.SetParametersOfForm(this);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationWindow = new RegistrationForm();
            registrationWindow.FormClosed += (s, arg) =>
            {
                Show();
            };
            registrationWindow.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User loginUser = new User(UsernameTextBox.Text, null, null, PasswordTextBox.Text, null);
            User actualUser = RepositoryManager.GetRepo<User>(UsersDBPath).GetObjectByFilter(u => u.Username == loginUser.Username && u.Password == loginUser.Password);
            if (actualUser != null)
            {
                Hide();
                UniversityEnvironmentForm universityEnvironmentForm = new UniversityEnvironmentForm(actualUser);
                universityEnvironmentForm.FormClosed += (s, arg) =>
                {
                    Show();
                };
                universityEnvironmentForm.Show();
                return;
            }
            MessageBox.Show("Wrong username or password...","Login",MessageBoxButtons.OK);
        }
    }
}

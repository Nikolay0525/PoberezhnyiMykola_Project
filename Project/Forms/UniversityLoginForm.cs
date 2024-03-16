using System;
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
using Project.Forms;
using Project.Models;

namespace Project.Forms
{
    public partial class UniversityLoginForm : MaterialForm
    {
        public UniversityLoginForm()
        {
            InitializeComponent();
            DataBaseManager.CreateBaseDB();
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
            User User = DataBaseManager.DeserializationOfUsersFromFile(DataBaseManager.UsersDBPath,UsernameTextBox.Text, PasswordTextBox.Text);
            if (User != null)
            {
                Hide();
                UniversityEnvironmentForm universityEnvironmentForm = new UniversityEnvironmentForm(User);
                universityEnvironmentForm.FormClosed += (s, arg) =>
                {
                    Show();
                };
                universityEnvironmentForm.Show();
                return;
            }
            UsefullMethods.ShowMessage("Wrong username or password...","Login");
        }
    }
}

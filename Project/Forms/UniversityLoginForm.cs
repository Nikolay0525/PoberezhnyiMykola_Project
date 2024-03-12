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

namespace Project.Forms
{
    public partial class UniversityLoginForm : MaterialForm
    {
        public UniversityLoginForm()
        {
            InitializeComponent();
            DataBaseManager.CreateDB();
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
            string role = DataBaseManager.DeserializationOfUsersFromFile(DataBaseManager.UsersDBPath,UsernameTextBox.Text, PasswordTextBox.Text);
            if (role != null)
            {
                Hide();
                UniversityEnvironmentForm universityEnvironmentForm = new UniversityEnvironmentForm(UsernameTextBox.Text, role);
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

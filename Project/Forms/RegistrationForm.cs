using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Project.Models;
using static Project.DataBaseManager;

namespace Project.Forms
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        
        private void RegistrateAccountButton_Click(object sender, EventArgs e)
        {
            var role = (TeacherCheck.Checked == true) ? "Teacher" : "Student";
            var user = new User(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text, role);
            if (!ReadingBoolOperationWithObject(UsersDBPath, user, CheckIfUserExist))
            {
                RewritingOperationWithObject(UsersDBPath,user, RegistrationUserInFile);
                UsefullMethods.ShowMessage("Account created successfully!", "Registration");
                return;
            }
            UsefullMethods.ShowMessage("Account with such name exist...", "Registration");
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

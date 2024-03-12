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
            
            if (DataBaseManager.DeserializationOfUsersFromFile(DataBaseManager.UsersDBPath,UsernameTextBox.Text))
            {
                var role = (TeacherCheck.Checked == true) ? "Teacher" : "Student";
                DataBaseManager.SerializationUserInFile(UsernameTextBox.Text, PasswordTextBox.Text, role);
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

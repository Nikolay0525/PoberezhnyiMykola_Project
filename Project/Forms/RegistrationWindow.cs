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

namespace Project
{
    public partial class RegistrationWindow : MaterialForm
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegistrationWindow_Load(object sender, EventArgs e)
        {

        }

        private void RegistrateAccountButton_Click(object sender, EventArgs e)
        {
            using (StreamReader UsersDBReader = new StreamReader(DataBase.UsersDBPath))
            {
                string line = UsersDBReader.ReadToEnd();
                if (line.IndexOf(UsernameTextBox.Text) != -1)
                {
                    MessageLabel.Text = "Account with such username exist";
                    return;
                }
            }

            using (StreamWriter UsersDBWriter = new StreamWriter(DataBase.UsersDBPath, true))
            {
                if(UsernameTextBox.Text.Length >= 3 && PasswordTextBox.Text.Length >= 3)
                {
                    var role = TeacherCheck.Checked ? "Teacher" : "Student";
                    UsersDBWriter.WriteLine(UsernameTextBox.Text + ',' + PasswordTextBox.Text + ',' + role);
                    MessageLabel.Text = "Successfully registrated account!";
                }
                else { MessageLabel.Text = "Username or password is too short"; }
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void TeacherCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabelRegistration_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabelRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}

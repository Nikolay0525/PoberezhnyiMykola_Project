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
            using (StreamReader UserDBReader = new StreamReader(Utility.DBPath))
            {

                string line;
                while ((line = UserDBReader.ReadLine()) != null)
                {
                    if (UsernameTextBox.Text == UserDBReader.ReadLine())
                    {
                        MessageLabel.Text = "Account with such username exist";
                        return;
                    }
                }
            }

            using (StreamWriter UserDBWriter = new StreamWriter(Utility.DBPath, true))
            {
                if(UsernameTextBox.Text.Length >= 3 && PasswordTextBox.Text.Length >= 3)
                {
                    MessageLabel.Text = "Successfully registrated account!";
                    var role = TeacherCheck.Checked ? "teacher" : "student";
                    UserDBWriter.WriteLine(UsernameTextBox.Text);
                    UserDBWriter.WriteLine(PasswordTextBox.Text);
                    UserDBWriter.WriteLine(role);
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

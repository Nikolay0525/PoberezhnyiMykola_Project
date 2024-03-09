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

namespace Project
{
    public partial class UniversityLoginWindow : MaterialForm
    {
        public UniversityLoginWindow()
        {
            InitializeComponent();
            if (!File.Exists(Utility.DBPath))
            {
                File.Create(Utility.DBPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (StreamReader UserDBReader = new StreamReader(Utility.DBPath))
            {
                string line;
                while ((line = UserDBReader.ReadLine()) != null)
                {
                    if (line == UsernameTextBox.Text && UserDBReader.ReadLine() == PasswordTextBox.Text)
                    {
                        Console.WriteLine("Success!");
                        string role = UserDBReader.ReadLine();
                        MessageLabel.Text = "";
                        Console.WriteLine(role);

                        if (role == "student")
                        {
                            Hide();
                            UniversityEnvironment studentEnvironment = new UniversityEnvironment();
                            studentEnvironment.FormClosed += (s, arg) =>
                            {
                                Show();
                            };
                            studentEnvironment.Show();
                        }
                       /* else if (role == "teacher")
                        {
                            Hide();
                            TeacherProfile teacherProfile = new TeacherProfile();
                            teacherProfile.FormClosed += (s, arg) =>
                            {
                                Show();
                            };
                            teacherProfile.Show();
                        }*/
                    }
                    else
                    {
                        Console.WriteLine("I`m here!");
                        MessageLabel.Text = "Username or password is wrong";
                    } 
                }
            }
                
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.FormClosed += (s, arg) =>
            {
                Show();
            };
            registrationWindow.Show();
        }

        private void UsernameLabelLogin_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabelLogin_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        private readonly string _path = "UserDataBase.txt";

        public UniversityLoginWindow()
        {
            InitializeComponent();
            if (!File.Exists(_path))
            {
                File.Create(_path);
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
            using (StreamReader UserDBReader = new StreamReader(_path))
            {
                string line;
                while ((line = UserDBReader.ReadLine()) != null)
                {
                    if (line == UsernameTextBox.Text && (line = UserDBReader.ReadLine()) == PasswordTextBox.Text)
                    {
                        Console.WriteLine("Success!");
                        string role = UserDBReader.ReadLine();
                        Console.WriteLine(role);
                        if (role == "student")
                        {
                            this.Hide();
                            StudentProfile studentProfile = new StudentProfile();
                            studentProfile.Show();
                        }
                        else if (role == "teacher")
                        {
                            this.Hide();
                            TeacherProfile teacherProfile = new TeacherProfile();
                            teacherProfile.Show();
                        }
                        return;
                    }
                    FailLabel.Text = "Something is wrong";
                }
            }
                
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

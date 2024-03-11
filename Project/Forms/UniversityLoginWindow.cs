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
            DataBase.CreateDB();
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
            using (StreamReader UsersDBReader = new StreamReader(DataBase.UsersDBPath))
            {
                for (string line; (line = UsersDBReader.ReadLine()) != null;)
                {
                    string[] lineSplit = line.Split(',');
                    if (lineSplit[0] == UsernameTextBox.Text && lineSplit[1] == PasswordTextBox.Text)
                    {
                        Console.WriteLine("Success!");
                        string role = lineSplit[2];
                        MessageLabel.Text = "";
                        Hide();
                        
                        UniversityEnvironment universityEnvironment = new UniversityEnvironment(UsernameTextBox.Text,role);
                        universityEnvironment.FormClosed += (s, arg) =>
                        {
                            Show();
                        };
                        universityEnvironment.Show();

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

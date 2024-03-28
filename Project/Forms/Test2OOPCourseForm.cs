using Project.Models;
using Project.Utilitys;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Project.Forms
{
    public sealed partial class Test2OOPCourseForm : Project.Forms.BaseTestForm
    {
        public Test2OOPCourseForm()
        {
            InitializeComponent();
        }
        public Test2OOPCourseForm(User user, Course course, int testId) : base(user, course, testId)
        {
            InitializeComponent();
            List<Course> courses = DataBaseManager.MakeObjectsList<Course>(DataBaseManager.CoursesDBPath);
            if (user.Role != "Teacher")
            {
                Question1Table.Visible = false;
                Question2Table.Visible = false;
                Question3Table.Visible = false;
            }
        }


        private void Question1Check_CheckedChanged(object sender, EventArgs e)
        {
            bool[] question1Checkboxes = { Question1Check1.Checked, Question1Check2.Checked, Question1Check3.Checked };
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                Question1Check1.Checked = (checkBox == Question1Check1);
                Question1Check2.Checked = (checkBox == Question1Check2);
                Question1Check3.Checked = (checkBox == Question1Check3);
                for (int i = 0; i < question1Checkboxes.Length; i++)
                {
                    if (question1Checkboxes[i])
                    {
                        Question1Table.Rows.Clear();
                        Console.WriteLine("Oooooo");
                        foreach (var student in _course.Tests[_testId - 1].Questions[0].Answers[i].Students)
                        {
                            Console.WriteLine("YYYYYY");
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(Question1Table);
                            row.Cells[0].Value = student.Username;
                            Question1Table.Rows.Add(row);
                        }
                        break;
                    }
                }
            }
        }

        private void Question2Check_CheckedChanged(object sender, EventArgs e)
        {
            bool[] question2Checkboxes = { Question2Check1.Checked, Question2Check2.Checked, Question2Check3.Checked };
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                Question2Check1.Checked = (checkBox == Question2Check1);
                Question2Check2.Checked = (checkBox == Question2Check2);
                Question2Check3.Checked = (checkBox == Question2Check3);
                for (int i = 0; i < question2Checkboxes.Length; i++)
                {
                    if (question2Checkboxes[i])
                    {
                        Question2Table.Rows.Clear();
                        Console.WriteLine("Oooooo");
                        foreach (var student in _course.Tests[_testId - 1].Questions[1].Answers[i].Students)
                        {
                            Console.WriteLine("YYYYYY");
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(Question2Table);
                            row.Cells[0].Value = student.Username;
                            Question2Table.Rows.Add(row);
                        }
                        break;
                    }
                }
            }
        }

        private void Question3Check_CheckedChanged(object sender, EventArgs e)
        {
            bool[] question3Checkboxes = { Question3Check1.Checked, Question3Check2.Checked, Question3Check3.Checked };
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                Question3Check1.Checked = (checkBox == Question3Check1);
                Question3Check2.Checked = (checkBox == Question3Check2);
                Question3Check3.Checked = (checkBox == Question3Check3);
                for (int i = 0; i < question3Checkboxes.Length; i++)
                {
                    if (question3Checkboxes[i])
                    {
                        Question3Table.Rows.Clear();
                        Console.WriteLine("Oooooo");
                        foreach (var student in _course.Tests[_testId - 1].Questions[2].Answers[i].Students)
                        {
                            Console.WriteLine("YYYYYY");
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(Question3Table);
                            row.Cells[0].Value = student.Username;
                            Question3Table.Rows.Add(row);
                        }
                        break;
                    }
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            bool[] question1Checkboxes = { Question1Check1.Checked, Question1Check2.Checked, Question1Check3.Checked };
            bool[] question2Checkboxes = { Question2Check1.Checked, Question2Check2.Checked, Question2Check3.Checked };
            bool[] question3Checkboxes = { Question3Check1.Checked, Question3Check2.Checked, Question3Check3.Checked };
            if (_user.Role != "Teacher")
            {
                List<Course> courses = DataBaseManager.MakeObjectsList<Course>(DataBaseManager.CoursesDBPath);
                foreach (var studentCheker in courses[_course.Id - 1].Tests[_testId - 1].Students)
                {
                    Console.WriteLine(studentCheker.Username);
                    if (studentCheker.Username == _user.Username)
                    {
                        UsefullMethods.ShowMessage("You can't pass it twice...", _course.Name);
                        return;
                    }
                }
                Student student = new Student(_user.Username, _user.FirstName, _user.LastName);
                Test test = courses[_course.Id - 1].Tests[_testId - 1];

                test.AddObject(student);

                for (int i = 0; i < question1Checkboxes.Length; i++)
                {
                    var question = question1Checkboxes[i];
                    if (question == true)
                    {
                        List<Student> students = test.Questions[0].Answers[i].Students.ToList();
                        students.Add(student);
                        test.Questions[0].Answers[i].Students = students.ToArray();
                    }
                }
                for (int i = 0; i < question2Checkboxes.Length; i++)
                {
                    var question = question2Checkboxes[i];
                    if (question == true)
                    {
                        List<Student> students = test.Questions[1].Answers[i].Students.ToList();
                        students.Add(student);
                        test.Questions[1].Answers[i].Students = students.ToArray();
                    }
                }
                for (int i = 0; i < question3Checkboxes.Length; i++)
                {
                    var question = question3Checkboxes[i];
                    if (question == true)
                    {
                        List<Student> students = test.Questions[2].Answers[i].Students.ToList();
                        students.Add(student);
                        test.Questions[2].Answers[i].Students = students.ToArray();
                    }
                }

                courses[_course.Id - 1].Tests[_testId - 1] = test;

                string updatedCourses = JsonConvert.SerializeObject(courses, Formatting.Indented);

                File.WriteAllText(DataBaseManager.CoursesDBPath, updatedCourses);
                UsefullMethods.ShowMessage("Successful! Now wait for assessment...", Text);
                Close();
                return;
            }
            UsefullMethods.ShowMessage("You are not student...", Text);
        }


    }
}
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
using System.Text.Json;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Test1CybersecurityCourseForm : Project.Forms.BaseTestForm
    {
        private readonly User _user;
        private readonly Course _course;
        private readonly int _testId;
        public Test1CybersecurityCourseForm()
        {
            InitializeComponent();
        }
        public Test1CybersecurityCourseForm(User user, Course course, int testId) : base(user, course, testId)
        {
            _user = user;
            _course = course;
            _testId = testId;
            InitializeComponent();

            string json = File.ReadAllText(DataBaseManager.CoursesDBPath);
            Course[] courses = JsonSerializer.Deserialize<Course[]>(json);
            Console.WriteLine(courses[1].Tests[_testId - 1].Question[0].Id); 
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
                        foreach (var student in _course.Tests[_testId - 1].Question[0].Answer[i].Students)
                        {
                            Console.WriteLine("YYYYYY");
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(Question1Table);
                            row.Cells[0].Value = student.Name;
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
                        foreach (var student in _course.Tests[_testId - 1].Question[1].Answer[i].Students)
                        {
                            Console.WriteLine("YYYYYY");
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(Question2Table);
                            row.Cells[0].Value = student.Name;
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
                        foreach (var student in _course.Tests[_testId - 1].Question[2].Answer[i].Students)
                        {
                            Console.WriteLine("YYYYYY");
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(Question3Table);
                            row.Cells[0].Value = student.Name;
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
                foreach(Student studentCheker in _course.Tests[_testId - 1].Students)
                {
                    if(studentCheker.Name == _user.Name)
                    {
                        UsefullMethods.ShowMessage("You can't pass it twice...", _course.Name);
                        return;
                    }
                }
                Student student = new Student(_user);
                string json = File.ReadAllText(DataBaseManager.CoursesDBPath);
                Course[] courses = JsonSerializer.Deserialize<Course[]>(json);
                Test test = courses[_course.Id - 1].Tests[_testId - 1];
                if (test.Students != null)
                {
                    List<Student> studentsList = test.Students.ToList();
                    studentsList.Add(student);
                    test.Students = studentsList.ToArray();
                }
                else
                {
                    List<Student> studentsList = new List<Student>();
                    studentsList.Add(student);
                    test.Students = studentsList.ToArray();
                }
                
                for (int i = 0; i < question1Checkboxes.Length; i++)
                {
                    var question = question1Checkboxes[i];
                    if (question == true)
                    {
                        List<Student> students = test.Question[0].Answer[i].Students.ToList();
                        students.Add(student);
                        test.Question[0].Answer[i].Students = students.ToArray();
                    }
                }
                for (int i = 0; i < question2Checkboxes.Length; i++)
                {
                    var question = question2Checkboxes[i];
                    if (question == true)
                    {
                        List<Student> students = test.Question[1].Answer[i].Students.ToList();
                        students.Add(student);
                        test.Question[1].Answer[i].Students = students.ToArray();
                    }
                }
                for (int i = 0; i < question3Checkboxes.Length; i++)
                {
                    var question = question3Checkboxes[i];
                    if (question == true)
                    {
                        List<Student> students = test.Question[2].Answer[i].Students.ToList();
                        students.Add(student);
                        test.Question[2].Answer[i].Students = students.ToArray();
                    }
                }

                courses[_course.Id - 1].Tests[_testId - 1] = test;

                string updatedCourses = JsonSerializer.Serialize(courses, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(DataBaseManager.CoursesDBPath, updatedCourses);
                UsefullMethods.ShowMessage("Successful! Now wait for assessment...", Text);
                Close();
                return;
            }
            UsefullMethods.ShowMessage("You are not student...", Text);
        }


    }
}
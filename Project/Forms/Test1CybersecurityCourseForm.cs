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
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
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
                bool[] question1Checkboxes = { Question1Check1.Checked, Question1Check2.Checked, Question1Check3.Checked };
                bool[] question2Checkboxes = { Question2Check1.Checked, Question2Check2.Checked, Question2Check3.Checked };
                bool[] question3Checkboxes = { Question3Check1.Checked, Question3Check2.Checked, Question3Check3.Checked };
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
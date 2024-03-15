using Project.Models;
using Project.Utilitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class CybersecurityCourseEnvironmentForm : Project.Forms.CourseEnvironmentForm
    {
        private readonly User _user;
        private readonly Course _course;

        public CybersecurityCourseEnvironmentForm(User user, Course course) : base(user, course)
        {
            _user = user;
            _course = course;
            InitializeComponent();
        }

        private void Exam1Button_Click(object sender, EventArgs e)
        {
            Hide();
            Form formInstance = FormCreater.CreateTestForm("Test1" + _course.Name + "CourseForm", _user, _course, _course.Tests[0].Id);
            formInstance.FormClosed += (s, arg) =>
            {
                Show();
            };
            formInstance.Show();
        }
    }
}

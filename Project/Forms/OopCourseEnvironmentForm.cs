using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project.Forms;
using Project.Models;
using Project.Utilitys;

namespace Project.Forms
{
    public sealed partial class OOPCourseEnvironmentForm : Project.Forms.CourseEnvironmentForm
    {
        public OOPCourseEnvironmentForm(User user, Course course) : base(user, course)
        {

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

        private void Exam2Button_Click(object sender, EventArgs e)
        {
            Hide();

            Form formInstance = FormCreater.CreateTestForm("Test2" + _course.Name + "CourseForm", _user, _course, _course.Tests[1].Id);
            formInstance.FormClosed += (s, arg) =>
            {
                Show();
            };
            formInstance.Show();
        }
    }
}

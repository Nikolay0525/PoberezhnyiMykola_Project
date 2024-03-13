using Project.Models;
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
        public CybersecurityCourseEnvironmentForm(User user, Course course) : base(user, course)
        {
            InitializeComponent();
        }

        private void Exam1Button_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project.Forms;
using Project.Models;

namespace Project.Forms
{
    public partial class OOPCourseEnvironmentForm : Project.Forms.CourseEnvironmentForm
    {
        public OOPCourseEnvironmentForm(User user, Course course) : base(user, course)
        {
            InitializeComponent();
        }

        private void Exam1Button_Click(object sender, EventArgs e)
        {

        }

        private void Exam2Button_Click(object sender, EventArgs e)
        {

        }
    }
}

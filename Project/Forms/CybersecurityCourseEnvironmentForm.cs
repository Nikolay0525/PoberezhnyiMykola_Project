using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class CybersecurityCourseEnvironmentForm : CourseEnvironmentForm
    {
        public CybersecurityCourseEnvironmentForm(string accesslevel, string courseName, string dbName) : base(accesslevel, courseName, dbName)
        {
            InitializeComponent();
        }
    }
}

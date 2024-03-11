using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class OopCourseEnvironment : CourseEnvironment
    {
        public OopCourseEnvironment(string accesslevel,string courseName) : base(accesslevel, courseName)
        {
            InitializeComponent();
        }

        private void OopCourseEnvironment_Load(object sender, EventArgs e)
        {

        }
    }
}

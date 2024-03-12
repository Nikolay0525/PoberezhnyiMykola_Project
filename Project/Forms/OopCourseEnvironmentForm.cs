using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project.Forms;

namespace Project.Forms
{
    public partial class OopCourseEnvironmentForm : CourseEnvironmentForm
    {
        public OopCourseEnvironmentForm(string accesslevel,string courseName,string nameDB) : base(accesslevel, courseName, nameDB)
        {
            InitializeComponent();
        }

        private void OopCourseEnvironment_Load(object sender, EventArgs e)
        {

        }
    }
}

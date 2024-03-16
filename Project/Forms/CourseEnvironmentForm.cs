﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Project.Models;

namespace Project.Forms
{
    public partial class CourseEnvironmentForm : MaterialForm
    {
        private readonly User _user;
        private readonly Course _course;

        public CourseEnvironmentForm()
        {
            InitializeComponent();
        }
        public CourseEnvironmentForm(User User, Course course)
        {
            _user = User;
            _course = course;
            this.Text = "Welcome to " + course.Name + " course!";
            InitializeComponent();
            DataBaseManager.UpdateTeacherTable(TeacherTable, course);
        }

        private void JournalButton_Click(object sender, EventArgs e)
        {
            Hide();
            JournalForm journalForm = new JournalForm(_user, _course);
            journalForm.FormClosed += (s, arg) =>
            {
                Show();
            };
            journalForm.Show();
            return;
        }

        private void CloseButton_Click(object sender, EventArgs e )
        {
            Close();
        }
    }
}

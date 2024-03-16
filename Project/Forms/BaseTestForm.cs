﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Project.Models;

namespace Project.Forms
{
    public partial class BaseTestForm : MaterialForm
    {
        private readonly User _user;
        private readonly Course _course;
        private readonly int _testId;

        public BaseTestForm() 
        {
            InitializeComponent();
        }
        public BaseTestForm(User User, Course course, int testId)
        {
            Text = course.Name;
            _user = User;
            _course = course;
            _testId = testId;
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

﻿using System;
using System.IO;
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
using System.Xml.Linq;
using Project.Utilitys;
using Newtonsoft.Json;
using static Project.DataBaseManager;

namespace Project.Forms
{
    public partial class JournalForm : MaterialForm
    {
        private readonly User _user;
        private readonly Course _course;
        public JournalForm(User User, Course course)
        {
            _user = User;
            _course = course;
            this.Text = "Welcome to " + course.Name + " journal!";
            List<Course> courses = MakeObjectsList<Course>(CoursesDBPath);
            InitializeComponent();
            foreach (var courseFromDB in courses)
            {
                if (courseFromDB.Name == course.Name)
                {
                    ReadingCourseOperationsWithTable(JournalTable, 1, courseFromDB, UpdateContentOfTableJournal);
                }
            }
            if (_user.Role == "Student") // access to table
            {
                for (int i = 1; i < JournalTable.ColumnCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = true;
                }
            }
            else
            {
                for (int i = 1; i < JournalTable.ColumnCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = false;
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if(_user.Role == "Teacher")
            {
                ApplyChangesToDBJournal(JournalTable, _course);
                return;
            }
            UsefullMethods.ShowMessage("You aren't teacher!", "Journal");
        }

        private void JournalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = JournalTable.Rows[e.RowIndex];
                string selectedId = selectedRow.Cells["ActualGridColumnCourseId"].Value.ToString();
                List<Course> courses = MakeObjectsList<Course>(CoursesDBPath);
                foreach (var course in courses)
                {
                    if (course.Id == int.Parse(selectedId))
                    {
                        Hide();
                        Form formInstance = FormCreater.CreateForm(course.Name + "CourseEnvironmentForm", _user, course);
                        formInstance.FormClosed += (s, arg) =>
                        {
                            Show();
                        };
                        formInstance.Show();
                    }
                }

            }*/
            
        }
    }
}

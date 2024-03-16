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

using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;

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
            string json = File.ReadAllText(DataBaseManager.CoursesDBPath);
            Course[] courses = JsonConvert.DeserializeObject<Course[]>(json);
            InitializeComponent();
            foreach (var courseFromDB in courses)
            {
                if (courseFromDB.Name == course.Name)
                {
                    DataBaseManager.UpdateJournal(JournalTable, courseFromDB);
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
            string json = File.ReadAllText(DataBaseManager.CoursesDBPath);
            Course[] courses = JsonConvert.DeserializeObject<Course[]>(json);

            foreach (var course in courses)
            {
                if (_course.Name == course.Name)
                {
                    foreach (DataGridViewRow row in JournalTable.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            foreach (var test in course.Tests)
                            {
                                if (test.Name == cell.OwningColumn.Name)
                                {
                                    int rowIndex = cell.RowIndex;
                                    int columnIndex = cell.ColumnIndex;
                                    if (rowIndex < test.Students.Length && columnIndex > 0)
                                    {
                                        var student = test.Students[rowIndex];
                                        string cellValue = Convert.ToString(cell.Value);

                                        if (!string.IsNullOrEmpty(cellValue) && int.TryParse(cellValue, out int mark))
                                        {
                                            student.Mark = mark;
                                        }
                                        else
                                        {
                                            student.Mark = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            string updatedCoursesString = JsonConvert.SerializeObject(courses);

            File.WriteAllText(DataBaseManager.CoursesDBPath, updatedCoursesString);
        }

        private void JournalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(row)
        }
    }
}

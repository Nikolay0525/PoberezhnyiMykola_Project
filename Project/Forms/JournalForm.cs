using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Project.Models;
using System.Xml.Linq;

namespace Project.Forms
{
    public partial class JournalForm : MaterialForm
    {
        private readonly User _user;
        private readonly Course _course;
        public JournalForm(User user, Course course)
        {
            _user = user;
            _course = course;
            this.Text = "Welcome to " + course.Name + " journal!";
            string json = File.ReadAllText(DataBaseManager.CoursesDBPath);
            Course[] courses = JsonSerializer.Deserialize<Course[]>(json);
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
            Course[] courses = JsonSerializer.Deserialize<Course[]>(json);
            foreach (var course in courses)
            {
                if (_course.Name == course.Name)
                {
                    foreach (DataGridViewRow row in JournalTable.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            Console.WriteLine("I");
                            foreach (var test in course.Tests)
                            {
                                Console.WriteLine("I`m");
                                Console.WriteLine(cell.OwningColumn.Name);

                                if (test.Name == cell.OwningColumn.Name)
                                {
                                    Console.WriteLine("I`m h");
                                    foreach (var student in test.Students)
                                    {
                                        Console.WriteLine("I`m he");
                                        {
                                            string cellValue = Convert.ToString(cell.Value);
                                            if (!string.IsNullOrEmpty(cellValue) && int.TryParse(cellValue, out int mark))
                                            {
                                                student.Mark = mark;
                                                Console.WriteLine("I`m here");
                                            }
                                        }
                                    }
                                }
                            }                    
                        }
                    }
                }
            }
            string updatedCoursesString = JsonSerializer.Serialize(courses, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(DataBaseManager.CoursesDBPath, updatedCoursesString);
        }
    }
}

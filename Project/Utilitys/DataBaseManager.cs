﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;
using Newtonsoft;
using Project.Forms;
using System.Configuration;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.Data;
using Newtonsoft.Json;
using Project.Utilitys;

namespace Project
{
    public static class DataBaseManager
    {
        public const string UsersDBPath = "../../UsersDataBase.json";
        public const string CoursesDBPath = "../../CoursesDataBase.json";

        public static List<User> MakeUsersList()
        {
            List<User> users = null;

            if (File.Exists(UsersDBPath) && new FileInfo(UsersDBPath).Length > 0)
            {
                string json = File.ReadAllText(UsersDBPath);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }

            return users ?? new List<User>();
        }

        public static List<Course> MakeCoursesList()
        {
            List<Course> courses = null;

            if (File.Exists(CoursesDBPath) && new FileInfo(CoursesDBPath).Length > 0)
            {
                string json = File.ReadAllText(CoursesDBPath);
                courses = JsonConvert.DeserializeObject<List<Course>>(json);

            }
            return courses ?? new List<Course>();
        }

        public static void RegistrationUserInFile(User user)
        {
            List<User> users = MakeUsersList();

            users.Add(user);

            string updatedUsersString = JsonConvert.SerializeObject(users);

            File.WriteAllText(UsersDBPath, updatedUsersString);
        }

        
        public static bool UserExist(string userName)
        {
            if (File.ReadAllText(UsersDBPath) != null) 
            {
                List<User> users = MakeUsersList();
                foreach (var User in users)
                {
                    if (User.Name == userName)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static User DeserializationOfUsersWithPassword(string dbName, string userName, string password)
        {
            if (File.ReadAllText(UsersDBPath) != null)
            {
                List<User> users = MakeUsersList();
                foreach (var User in users)
                {
                    if (User.Name == userName && User.Password == password)
                    {
                        return User;
                    }
                }
            }
            return null;
        }

        public static void UpdateTableWithAvailableCourses(DataGridView table)
        {
            table.Rows.Clear();

            List<Course> courses = MakeCoursesList();

            foreach (var course in courses)
            {
                table.Rows.Add(false, course.Id, course.Name, course.FacultyName);
            }
        }

        public static void UpdateTableWithActualCourses(DataGridView table, string userName)
        {
            table.Rows.Clear();

            List<Course> courses = MakeCoursesList();

            foreach (var course in courses)
            {
                for (int i = 0; i < course.Users.Length; i++)
                {
                    if (userName == course.Users[i].Name)
                    {
                        table.Rows.Add(course.Id, course.Name, course.FacultyName);
                    }
                }
            }
        }

        public static void SignUserOnCourse(DataGridView CoursesTable, User User)
        {
            List<Course> courses = MakeCoursesList();
            for (int i = 0; i < courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    List<User> updatedUsers = new List<User>(course.Users ?? new User[0]);
                    foreach (var currentUser in course.Users)
                    {
                        if (currentUser.Name == User.Name)
                        {
                            UsefullMethods.ShowMessage("You already signed on some of checked courses...", "Registration");
                            return;
                        }
                    }
                    updatedUsers.Add(User);

                    course.Users = updatedUsers.ToArray();
                }
            }

            Console.WriteLine(!string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)));

            string updatedUsersString = JsonConvert.SerializeObject(courses);

            File.WriteAllText(CoursesDBPath, updatedUsersString);
        }
        public static void UnsignUserFromCourse(DataGridView CoursesTable, User User)
        {
            List<Course> courses = MakeCoursesList();
            for (int i = 0; i < courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    List<User> updatedUsers = new List<User>(course.Users ?? new User[0]);
                    for (int j = updatedUsers.Count - 1; j >= 0; j--)
                    {
                        var currentUser = updatedUsers[j];
                        if (currentUser.Name == User.Name)
                        {
                            updatedUsers.RemoveAt(j);
                        }
                    }
                    course.Users = updatedUsers.ToArray();
                }
            }

            Console.WriteLine(!string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)));

            string updatedUsersString = JsonConvert.SerializeObject(courses);

            File.WriteAllText(CoursesDBPath, updatedUsersString);
        }

        public static void CreateBaseDB()
        {
            if (!File.Exists(UsersDBPath))
            {
                using (StreamWriter sw = File.CreateText(UsersDBPath))
                {
                }
            }
            if (!File.Exists(CoursesDBPath))
            {
                using (StreamWriter sw = File.CreateText(CoursesDBPath))
                {
                }
            }
        }

        public static void UpdateTeacherTable(DataGridView table, Course course)
        {
            table.Rows.Clear();
            table.Columns.Clear();

            User[] users = course.Users;
            foreach (var User in users)
            {
                if (User.Role == "Teacher")
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = User.Name;
                    newRow.Cells.Add(nameCell);
                    table.Rows.Add(newRow);
                }
            }
        }
        public static void UpdateJournal(DataGridView table, Course course)
        {
            table.Rows.Clear();
            table.Columns.Clear();

            table.Columns.Add("StudentName", "Student");
            if (course.Tests != null && course.Tests.Length > 0)
            {
                foreach (var test in course.Tests)
                {
                    table.Columns.Add("Test" + test.Id, "Test " + test.Id);
                }
            }

            foreach (var User in course.Users)
            {
                if (User.Role == "Student")
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = User.Name;
                    newRow.Cells.Add(nameCell);

                    if (course.Tests != null && course.Tests.Length > 0)
                    {
                        foreach (var test in course.Tests)
                        {
                            DataGridViewTextBoxCell testCell = new DataGridViewTextBoxCell();
                            Student student = test.Students.FirstOrDefault(s => s.Name == User.Name);
                            if (student != null)
                            {
                                testCell.Value = student.Mark;
                            }
                            else
                            {
                                testCell.Value = "";
                            }
                            newRow.Cells.Add(testCell);
                        }
                    }
                    table.Rows.Add(newRow);
                }
            }

        }
    }
}

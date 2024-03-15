using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
using Project.Forms;
using System.Configuration;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.Data;

namespace Project
{
    public static class DataBaseManager
    {
        public const string UsersDBPath = "UsersDataBase.json";
        public const string CoursesDBPath = "CoursesDataBase.json";

        public static void SerializationUserInFile(string userName, string password, string role)
        {
            List<User> users;

            Console.WriteLine(!string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)));

            if (File.Exists(UsersDBPath) && !string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)))
            {
                string usersJson = File.ReadAllText(UsersDBPath);
                users = JsonSerializer.Deserialize<List<User>>(usersJson);
            }
            else
            {
                users = new List<User>();
            }

            users.Add(new User { Name = userName, Password = password, Role = role });

            string updatedUsersString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(UsersDBPath, updatedUsersString);

            Console.WriteLine("Користувач був успішно доданий та збережений у файл.");
        }

        public static bool DeserializationOfUsersFromFile(string dbName, string userName)
        {
            if (File.ReadAllText(dbName).Length == 0)
            {
                return true;
            }

            string json = File.ReadAllText(dbName);
            if (File.ReadAllText(dbName) == null) { Console.WriteLine("Empty file"); }
            User[] users = JsonSerializer.Deserialize<User[]>(json);
            foreach (var user in users)
            {
                if (user.Name == userName)
                {
                    return false;
                }
            }
            return true;
        }
        public static User DeserializationOfUsersFromFile(string dbName, string userName, string password)
        {
            if (File.ReadAllText(dbName).Length == 0)
            {
                Console.WriteLine("Файл з користувачами не знайдено.");
                return null;
            }

            string json = File.ReadAllText(dbName);
            if (json != "")
            {
                User[] users = JsonSerializer.Deserialize<User[]>(json);
                foreach (var user in users)
                {
                    if (user.Name == userName && user.Password == password)
                    {
                        return user;
                    }
                }
            }
            return null;
        }

        public static void DeserializationOfCoursesFromFile(DataGridView table, string dbName)
        {
            table.Rows.Clear();

            if (!File.Exists(dbName))
            {
                return;
            }

            string json = File.ReadAllText(dbName);
            Course[] courses = JsonSerializer.Deserialize<Course[]>(json);

            foreach (var course in courses)
            {
                table.Rows.Add(false, course.Id, course.Name, course.FacultyName);
            }
        }

        public static void DeserializationOfCoursesFromFile(DataGridView table, string dbName, string userName)
        {
            table.Rows.Clear();

            if (!File.Exists(dbName))
            {
                return;
            }

            string json = File.ReadAllText(dbName);
            Course[] courses = JsonSerializer.Deserialize<Course[]>(json);

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

        public static void SignUserOnCourse(DataGridView CoursesTable, User user)
        {
            List<Course> courses;
            if (!File.Exists(CoursesDBPath))
            {
                return;
            }

            string json = File.ReadAllText(CoursesDBPath);
            courses = JsonSerializer.Deserialize<Course[]>(json).ToList();
            for (int i = 0; i < courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    List<User> updatedUsers = new List<User>(course.Users ?? new User[0]);
                    foreach (var currentUser in course.Users)
                    {
                        if (currentUser.Name == user.Name)
                        {
                            UsefullMethods.ShowMessage("You already signed on some of checked courses...", "Registration");
                            return;
                        }
                    }
                    updatedUsers.Add(user);

                    course.Users = updatedUsers.ToArray();
                }
            }

            Console.WriteLine(!string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)));

            string updatedUsersString = JsonSerializer.Serialize(courses, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(CoursesDBPath, updatedUsersString);
        }
        public static void UnsignUserFromCourse(DataGridView CoursesTable, User user)
        {
            List<Course> courses;
            if (!File.Exists(CoursesDBPath))
            {
                return;
            }

            string json = File.ReadAllText(CoursesDBPath);
            courses = JsonSerializer.Deserialize<Course[]>(json).ToList();
            for (int i = 0; i < courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    List<User> updatedUsers = new List<User>(course.Users ?? new User[0]);
                    for (int j = updatedUsers.Count - 1; j >= 0; j--)
                    {
                        var currentUser = updatedUsers[j];
                        if (currentUser.Name == user.Name)
                        {
                            updatedUsers.RemoveAt(j);
                        }
                    }
                    course.Users = updatedUsers.ToArray();
                }
            }

            Console.WriteLine(!string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)));

            string updatedUsersString = JsonSerializer.Serialize(courses, new JsonSerializerOptions { WriteIndented = true });

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
            User[] users = course.Users;
            foreach (var user in users)
            {
                if (user.Role == "Teacher")
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = user.Name;
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

            foreach (var user in course.Users)
            {
                if (user.Role == "Student")
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = user.Name;
                    newRow.Cells.Add(nameCell);

                    if (course.Tests != null && course.Tests.Length > 0)
                    {
                        foreach (var test in course.Tests)
                        {
                            DataGridViewTextBoxCell testCell = new DataGridViewTextBoxCell();
                            Student student = test.Students.FirstOrDefault(s => s.Name == user.Name);
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

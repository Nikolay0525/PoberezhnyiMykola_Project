using System;
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
using static System.Net.Mime.MediaTypeNames;

namespace Project
{
    public static class DataBaseManager
    {
        public delegate void VoidOperationWithObject<T>(List<T> objects, T obj);
        public delegate T TypeOperationWithObject<T>(List<T> objects, T obj);
        public delegate bool BoolOperationWithObject<T>(List<T> objects, T obj);

        public static List<T> MakeObjectsList<T>(string filePath)
        {
            List<T> objects = null;

            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                string json = File.ReadAllText(filePath);
                objects = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return objects ?? new List<T>();
        }


        public static void RewritingOperationWithObject<T>(string filePath, T obj, params VoidOperationWithObject<T>[] operations)
        {
            List<T> objects = MakeObjectsList<T>(filePath);
            if (operations.Length == 0) { return; }
            foreach (var operation in operations)
            {
                operation(objects, obj);
            }
            string updatedObjects = JsonConvert.SerializeObject(objects, Formatting.Indented);

            File.WriteAllText(filePath, updatedObjects);
        }
        public static T ReadingOperationWithObject<T>(string filePath, T obj, params TypeOperationWithObject<T>[] operations)
        {
            List<T> objects = MakeObjectsList<T>(filePath);
            if (operations.Length == 0) { return default; }
            foreach (var operation in operations)
            {
                return operation(objects, obj);
            }
            return default;
        }
        public static bool ReadingBoolOperationWithObject<T>(string filePath, T obj, params BoolOperationWithObject<T>[] operations)
        {
            List<T> objects = MakeObjectsList<T>(filePath);
            var returnValue = false;
            if (operations.Length == 0) { return returnValue; }
            foreach (var operation in operations)
            {
                returnValue = operation(objects, obj);
                if (returnValue == true)
                {
                    return returnValue;
                }
            }
            return returnValue;
        }

        public static bool CheckIfUserExist(List<User> users, User user)
        {
            if (users.Exists(currentUser => currentUser.Username == user.Username))
            {
                return true;
            }
            return false;
        }
        public static void RegistrationUserInFile(List<User> users, User user)
        {
            users.Add(user);
        }
        public static User DeserializationOfUsersWithPassword(List<User> users, User user)
        {
            foreach (var currentUser in users)
            {
                if (currentUser.Username == user.Username && currentUser.Password == user.Password)
                {
                    return currentUser;
                }
            }
            return null;
        }

        public delegate void TableCourseOperation<Course>(DataGridView table, Course course);

       /* public static void ReadingOperationsWithTable<T>(string filePath, DataGridView table, int clear, User user, params TableOperation<T>[] operations)
        {
            switch (clear)
            {
                case 0:
                    break;
                case 1:
                    table.Rows.Clear();
                    break;
                case 2:
                    table.Rows.Clear();
                    table.Columns.Clear();
                    break;
                default:
                    break;
            }

            List<T> objects = MakeObjectsList<T>(filePath);

            foreach (var operation in operations)
            {
                operation(table, objects, user);
            }
        }*/
        /*public static void ReadAndWriteOperationsWithTable<T>(string filePath, DataGridView table, int clear, User user, params TableOperation<T>[] operations)
        {
            switch (clear)
            {
                case 0:
                    break;
                case 1:
                    table.Rows.Clear();
                    break;
                case 2:
                    table.Rows.Clear();
                    table.Columns.Clear();
                    break;
                default:
                    break;
            }

            List<T> objects = MakeObjectsList<T>(filePath);

            foreach (var operation in operations)
            {
                operation(table, objects, user);
            }

            string updatedObjects = JsonConvert.SerializeObject(objects, Formatting.Indented);

            File.WriteAllText(filePath, updatedObjects);
        }
        public static void ReadingCourseOperationsWithTable(DataGridView table, int clear, Course course, params TableCourseOperation<Course>[] operations)
        {
            switch (clear)
            {
                case 0:
                    break;
                case 1:
                    table.Rows.Clear();
                    break;
                case 2:
                    table.Rows.Clear();
                    table.Columns.Clear();
                    break;
                default:
                    break;
            }

            foreach (var operation in operations)
            {
                operation(table, course);
            }
        }*/

        public static void UpdateTableWithAvailableCourses(DataGridView table, List<Course> courses, User user)
        {
            foreach (var course in courses)
            {
                table.Rows.Add(false, course.Id, course.Name, course.FacultyName, course.Users);
            }
        }
        public static void UpdateTableWithActualCourses(DataGridView table, List<Course> courses, User user)
        {
            foreach (var course in courses)
            {
                for (int i = 0; i < course.Users.Count; i++)
                {
                    if (user.Username == course.Users[i].Username)
                    {
                        table.Rows.Add(course.Id, course.Name, course.FacultyName);
                    }
                }
            }
        }

        public static void SignUserOnCourse(DataGridView CoursesTable, List<Course> courses, User user)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    foreach (var currentUser in course.Users)
                    {
                        if (currentUser.Username == user.Username)
                        {
                            MessageBox.Show("You already signed on some of checked courses...", "Registration", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    course.AddObject(user);
                }
            }
        }
        public static void UnsignUserFromCourse(DataGridView CoursesTable, List<Course> courses, User user)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    for (int j = course.Users.Count() - 1; j >= 0; j--)
                    {
                        var currentUser = course.Users[j];
                        if (currentUser.Username == user.Username)
                        {
                            course.RemoveObject(currentUser);
                            break;
                        }
                    }
                }
            }
        }


        /*public static void UpdateTeacherTable(DataGridView table, Course course)
        {
            List<User> users = course.Users;
            foreach (var user in users)
            {
                if (user.Role == "Teacher" && table != null)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = user.Username;
                    newRow.Cells.Add(nameCell);
                    table.Rows.Add(newRow);
                }
            }
        }*/
        /*public static void UpdateContentOfTableJournal(DataGridView table, Course course)
        {
            foreach (var test in course.Tests)
            {
                if (table.Columns["Test " + test.Id] == null)
                {
                    DataGridViewTextBoxColumn testColumn = new DataGridViewTextBoxColumn();
                    testColumn.HeaderText = "Test " + test.Id;
                    testColumn.Name = "Test" + test.Id;
                    testColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                    table.Columns.Add(testColumn);
                }
            }

            foreach (var test in course.Tests)
            {
                foreach (var student in test.Students)
                {
                    bool match = false;
                    if(table.Rows.Count != 0)
                    {
                        foreach (DataGridViewRow row in table.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == student.Username)
                            {
                                row.Cells[test.Id].Value = student.Mark;
                                match = true;
                                break;
                            }
                        }
                    }
                    if (!match)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(table);
                        newRow.Cells[0].Value = student.Username;
                        newRow.Cells[test.Id].Value = student.Mark;
                        table.Rows.Add(newRow);
                    }
                }
            }
        }
        public static void ApplyChangesToDBJournal(DataGridView table, Course course)
        {
            List<Course> courses = MakeObjectsList<Course>(CoursesDBPath);
            
            foreach(DataGridViewRow row in table.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    foreach (var test in courses[course.Id - 1].Tests)
                    {
                        if (test.Name == cell.OwningColumn.Name)
                        {
                            foreach (var student in test.Students)
                            {
                                if (row.Cells[0].Value.ToString() == student.Username)
                                {
                                    if(int.TryParse(cell.Value.ToString(), out int mark))
                                    {
                                        student.Mark = mark;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            string updatedCourses = JsonConvert.SerializeObject(courses, Formatting.Indented);

            File.WriteAllText(CoursesDBPath, updatedCourses);
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
        }*/
    }
}
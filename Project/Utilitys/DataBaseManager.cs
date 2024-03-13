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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace Project
{
    public static class DataBaseManager
    {
        public const string UsersDBPath = "UsersDataBase.json";
        public const string CoursesDBPath = "CoursesDataBase.json";
        public const string CoursesJournalDBPath = "JournalDB.json";

        public static void SerializationUserInFile(string userName, string password, string role) // reg
        {
            List<User> users;

            Console.WriteLine(!string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)));

            if (File.Exists(UsersDBPath) && !string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)))
            {
                // Якщо файл існує, здійснюємо десеріалізацію його вмісту
                string usersJson = File.ReadAllText(UsersDBPath);
                users = JsonSerializer.Deserialize<List<User>>(usersJson);
            }
            else
            {
                // Якщо файл не існує, створюємо новий пустий список користувачів
                users = new List<User>();
            }

            // Додаємо нового користувача до списку
            users.Add(new User { Name = userName, Password = password, Role = role });

            // Серіалізуємо оновлений список користувачів у JSON рядок
            string updatedUsersString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            // Записуємо оновлені дані у файл
            File.WriteAllText(UsersDBPath, updatedUsersString);

            Console.WriteLine("Користувач був успішно доданий та збережений у файл.");
        }

        public static bool DeserializationOfUsersFromFile(string dbName,string userName)
        {
            if (File.ReadAllText(dbName).Length == 0)
            {
                return true;
            }

            // Десеріалізуємо дані з JSON файлу у масив користувачів
            string json = File.ReadAllText(dbName);
            if(File.ReadAllText(dbName) == null) { Console.WriteLine("Empty file"); }
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
            if (!File.Exists(dbName))
            {
                Console.WriteLine("Файл з користувачами не знайдено.");
                return null;
            }

            // Десеріалізуємо дані з JSON файлу у масив користувачів
            string json = File.ReadAllText(dbName);
            User[] users = JsonSerializer.Deserialize<User[]>(json);
            foreach (var user in users)
            {
                if(user.Name == userName && user.Password == password)
                {
                    return user;
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

            // Десеріалізуємо дані з JSON файів
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

            // Десеріалізуємо дані з JSON файлу у масив користувачів
            string json = File.ReadAllText(dbName);
            Course[] courses = JsonSerializer.Deserialize<Course[]>(json);

            foreach (var course in courses)
            {
                for(int i = 0; i < course.Users.Length; i++)
                {
                    if(userName == course.Users[i].Name)
                    {
                        table.Rows.Add(course.Id, course.Name, course.FacultyName);
                    }
                }
                
            }
        }

        public static void SignUserOnCourse(DataGridView CoursesTable, User user) // reg
        {
            List<Course> courses;
            if (!File.Exists(CoursesDBPath))
            {
                return;
            }

            // Десеріалізуємо дані з JSON файлу у масив користувачів
            string json = File.ReadAllText(CoursesDBPath);
            courses = JsonSerializer.Deserialize<Course[]>(json).ToList();
            for (int i = 0; i<courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    // Створюємо новий масив користувачів, який містить всі існуючі користувачі на курсі разом із новим користувачем
                    List<User> updatedUsers = new List<User>(course.Users ?? new User[0]); // Якщо Users є null, створюємо пустий масив
                    foreach(var currentUser in course.Users)
                    {
                        if (currentUser.Name == user.Name)
                        {
                            UsefullMethods.ShowMessage("You already signed on some of checked courses...", "Registration");
                            return;
                        }
                    }
                    updatedUsers.Add(user); // Додаємо нового користувача

                    // Присвоюємо оновлений масив користувачів полю Users об'єкта course
                    course.Users = updatedUsers.ToArray();
                }
            }

            Console.WriteLine(!string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)));
            
            // Серіалізуємо оновлений список користувачів у JSON рядок

            string updatedUsersString = JsonSerializer.Serialize(courses, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(CoursesDBPath, updatedUsersString);
        }
        public static void UnsignUserFromCourse(DataGridView CoursesTable, User user) // reg
        {
            List<Course> courses;
            if (!File.Exists(CoursesDBPath))
            {
                return;
            }

            // Десеріалізуємо дані з JSON файлу у масив користувачів
            string json = File.ReadAllText(CoursesDBPath);
            courses = JsonSerializer.Deserialize<Course[]>(json).ToList();
            for (int i = 0; i<courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    // Створюємо новий масив користувачів, який містить всі існуючі користувачі на курсі разом із новим користувачем
                    List<User> updatedUsers = new List<User>(course.Users ?? new User[0]); // Якщо Users є null, створюємо пустий масив
                    for (int j = updatedUsers.Count - 1; j >= 0; j--)
                    {
                        var currentUser = updatedUsers[j];
                        if (currentUser.Name == user.Name)
                        {
                            updatedUsers.RemoveAt(j);
                        }
                    }
                    // Присвоюємо оновлений масив користувачів полю Users об'єкта course
                    course.Users = updatedUsers.ToArray();
                }
            }

            Console.WriteLine(!string.IsNullOrWhiteSpace(File.ReadAllText(UsersDBPath)));
            
            // Серіалізуємо оновлений список користувачів у JSON рядок

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

        public static string CreateDB(string name)
        {
            name += CoursesJournalDBPath;
            if (!File.Exists(name))
            {
                using (StreamWriter sw = File.CreateText(name))
                {
                }
            }
            return name.Replace(".json","");
        }

        public static void UpdateTeacherTable(DataGridView table, Course course)
        {
            User[] users = course.Users;
            foreach (var user in users)
            {
                if(user.Role == "Teacher")
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    // Додаємо комірки зі значенням Name для кожного користувача
                    DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = user.Name; // Значення Name користувача
                    newRow.Cells.Add(nameCell);
                    table.Rows.Add(newRow);
                }
            }
        }
        public static void UpdateJournal(DataGridView table, Course course)
        {
            User[] users = course.Users;
            foreach (var user in users)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                // Додаємо комірки зі значенням Name для кожного користувача
                DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                nameCell.Value = user.Name; // Значення Name користувача
                newRow.Cells.Add(nameCell);
                table.Rows.Add(newRow);
            }
        }
        public static void StudentMark(User user)
        {
            UserWithMarks userWithMarks
        }
    }
}

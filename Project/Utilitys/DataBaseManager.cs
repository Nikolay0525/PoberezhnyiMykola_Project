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
            string updatedUsersString = JsonSerializer.Serialize(users);

            // Записуємо оновлені дані у файл
            File.WriteAllText(UsersDBPath, updatedUsersString);

            Console.WriteLine("Користувач був успішно доданий та збережений у файл.");
        }

        public static bool DeserializationOfUsersFromFile(string dbName,string userName)
        {
            if (!File.Exists(dbName))
            {
                Console.WriteLine("Файл з користувачами не знайдено.");
                return false;
            }

            // Десеріалізуємо дані з JSON файлу у масив користувачів
            string json = File.ReadAllText(dbName);
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
        public static string DeserializationOfUsersFromFile(string dbName, string userName, string password)
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
                    return user.Role;
                }   
            }
            return null;
        }

        public static void DeserializationOfCoursesFromFile(DataGridView table, string dbName)
        {
            if (!File.Exists(dbName))
            {
                return;
            }

            // Десеріалізуємо дані з JSON файлу у масив користувачів
            string json = File.ReadAllText(dbName);
            Course[] courses = JsonSerializer.Deserialize<Course[]>(json);

            foreach (var course in courses)
            {
                Console.WriteLine(course.Id[0]);
                table.Rows.Add(false, course.Id, course.Name, course.FacultyName);
            }
        }

        public static void DeserializationOfCoursesFromFile(DataGridView table, string dbName, string userName)
        {
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

        public static void UpdateTable(DataGridView dataGridView, string name)
        {
            while (dataGridView.Rows.Count > 0)
            {
                dataGridView.Rows.RemoveAt(0);
            }
            using (StreamReader CourseDBReader = new StreamReader(CoursesDBPath))
            {
                for (string line; (line = CourseDBReader.ReadLine()) != null;)
                {
                    if (line.IndexOf(name) != -1)
                    {
                        Console.WriteLine("Yes i find");
                        string[] lineSplit = line.Split(',');
                        dataGridView.Rows.Add(lineSplit[0], lineSplit[1], lineSplit[2]);
                    }
                }
            }
        }

        public static void CreateDB()
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
            return name;
        }

        public static void UpdateJournal(DataGridView dataGridView)
        {
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";


            /*dataGridView.Columns.Add(nameColumn);
            for (int i = 0; i < 7; i++)
            {
                DataGridViewTextBoxColumn dayColumn = new DataGridViewTextBoxColumn();
                dayColumn.HeaderText = "Day" + Convert.ToString(i);
                dataGridView.Columns.Add(dayColumn);
            }*/

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public static class DataBase
    {
        public const string UsersDBPath = "UsersDataBase.txt";
        public const string CoursesDBPath = "CoursesDataBase.txt";
        public const string CoursesJournalDBPath = "JournalDB.txt";
        
        public static void UpdateTable(DataGridView dataGridView,string name)
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
                File.Create(UsersDBPath);
            }
            if (!File.Exists(CoursesDBPath))
            {
                File.Create(CoursesDBPath);
            }

        }

        public static string CreateDB(string name)
        {
            name += CoursesJournalDBPath;
            if (!File.Exists(name))
            {
                File.Create(name);
            }
            return name;
        }

        public static void CreateJournal(DataGridView dataGridView)
        {
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            DataGridViewTextBoxColumn dayColumn = new DataGridViewTextBoxColumn();
            dayColumn.HeaderText = "1";
            dataGridView.Columns.Add(nameColumn);
        }
    }
}

using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class UniversityEnvironment : MaterialForm
    {
        private readonly string _accessLevel;

        public UniversityEnvironment(string name, string role)
        {
            InitializeComponent();
            _accessLevel = role;
            PersonName.Text = name;
            PersonRole.Text = role;
            using (StreamReader CourseDBReader = new StreamReader(DataBase.CoursesDBPath))
            {
                for (string line; (line = CourseDBReader.ReadLine()) != null;)
                {
                    string[] lineSplit = line.Split(',');
                    AvailableCoursesTable.Rows.Add(false, lineSplit[0], lineSplit[1], lineSplit[2]);
                }
            }
            using (StreamReader CourseDBReader = new StreamReader(DataBase.CoursesDBPath))
            {
                for (string line; (line = CourseDBReader.ReadLine()) != null;)
                {
                    if (line.IndexOf(PersonName.Text) != -1)
                    {
                        Console.WriteLine("Yes i find");
                        string[] lineSplit = line.Split(',');
                        ActualCoursesTable.Rows.Add(lineSplit[0], lineSplit[1], lineSplit[2]);
                    }
                }
            }
        }

        private void UniversityEnvironment_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(DataBase.CoursesDBPath);
            for (int i = 0; i < AvailableCoursesTable.Rows.Count; i++)
            {
                var checkCell = AvailableCoursesTable.Rows[i].Cells[0].Value;
                if ((bool)checkCell == true && lines[i].IndexOf("," + PersonName.Text) == -1)
                {
                    lines[i] += ("," + PersonName.Text);
                    File.WriteAllLines(DataBase.CoursesDBPath, lines);
                }
            }
            DataBase.UpdateTable(ActualCoursesTable, PersonName.Text);
        }

        private void UnsignButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(DataBase.CoursesDBPath);
            for (int i = 0; i < AvailableCoursesTable.Rows.Count; i++)
            {
                var checkCell = AvailableCoursesTable.Rows[i].Cells[0].Value;
                if ((bool)checkCell == true && lines[i].IndexOf("," + PersonName.Text) != -1)
                {
                    lines[i] = lines[i].Remove(lines[i].IndexOf(',' + PersonName.Text));
                    File.WriteAllLines(DataBase.CoursesDBPath, lines);
                }

            }
            DataBase.UpdateTable(ActualCoursesTable, PersonName.Text);
        }

        private void ActualCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = AvailableCoursesTable.Rows[e.RowIndex];
                string selectedId = selectedRow.Cells["GridColumnCourseId"].Value.ToString();
                string selectedName = selectedRow.Cells["GridColumnCourseName"].Value.ToString();
                string[] lines = File.ReadAllLines(DataBase.CoursesDBPath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].IndexOf(selectedId) != -1)
                    {
                        Hide();
                        string[] lineSplit = lines[i].Split(',');
                        DataBase.CreateDB(lineSplit[3]);
                        Form formInstance = CourseFormCreator.CreateForm(lineSplit[3], _accessLevel, selectedName);
                        formInstance.FormClosed += (s, arg) =>
                        {
                            Show();
                        };
                        formInstance.Show();
                    }
                }
            }
        }

        private void AvailableCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

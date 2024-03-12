using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace Project.Forms

{
    public partial class UniversityEnvironmentForm : MaterialForm
    {
        private readonly string _accessLevel;
        private readonly string _name;

        public UniversityEnvironmentForm(string name, string role)
        {
            InitializeComponent();
            _accessLevel = role;
            _name = name;

            PersonName.Text = name;
            PersonRole.Text = role;

            DataBaseManager.DeserializationOfCoursesFromFile(AvailableCoursesTable,DataBaseManager.CoursesDBPath);
            DataBaseManager.DeserializationOfCoursesFromFile(ActualCoursesTable,DataBaseManager.CoursesDBPath, name);
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(DataBaseManager.CoursesDBPath);
            for (int i = 0; i < AvailableCoursesTable.Rows.Count; i++)
            {
                var checkCell = AvailableCoursesTable.Rows[i].Cells[0].Value;
                if ((bool)checkCell == true && lines[i].IndexOf("," + PersonName.Text) == -1)
                {
                    lines[i] += ("," + PersonName.Text);
                    File.WriteAllLines(DataBaseManager.CoursesDBPath, lines);
                }
            }
            DataBaseManager.UpdateTable(ActualCoursesTable, PersonName.Text);
        }

        private void UnsignButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(DataBaseManager.CoursesDBPath);
            for (int i = 0; i < AvailableCoursesTable.Rows.Count; i++)
            {
                var checkCell = AvailableCoursesTable.Rows[i].Cells[0].Value;
                if ((bool)checkCell == true && lines[i].IndexOf("," + PersonName.Text) != -1)
                {
                    lines[i] = lines[i].Remove(lines[i].IndexOf(',' + PersonName.Text));
                    File.WriteAllLines(DataBaseManager.CoursesDBPath, lines);
                }

            }
            DataBaseManager.UpdateTable(ActualCoursesTable, PersonName.Text);
        }

        private void ActualCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = AvailableCoursesTable.Rows[e.RowIndex];
                string selectedId = selectedRow.Cells["GridColumnCourseId"].Value.ToString();
                string selectedName = selectedRow.Cells["GridColumnCourseName"].Value.ToString();
                string[] lines = File.ReadAllLines(DataBaseManager.CoursesDBPath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].IndexOf(selectedId) != -1)
                    {
                        Hide();
                        string[] lineSplit = lines[i].Split(',');
                        string dbName = DataBaseManager.CreateDB(lineSplit[3]);
                        Form formInstance = UsefullMethods.CreateForm(lineSplit[3], _accessLevel, selectedName, dbName);
                        formInstance.FormClosed += (s, arg) =>
                        {
                            Show();
                        };
                        formInstance.Show();
                    }
                }
            }
        }

    }
}

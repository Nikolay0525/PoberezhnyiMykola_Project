using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;
using Project.Models;
using System.Text.Json;
using System.Xml.Linq;

namespace Project.Forms

{
    public partial class UniversityEnvironmentForm : MaterialForm
    {
        private readonly string _accessLevel;
        private readonly User _user;

        public UniversityEnvironmentForm(User user)
        {
            InitializeComponent();
            _accessLevel = user.Role;
            _user = user;
            PersonName.Text = user.Name;
            PersonRole.Text = user.Role;
            DataBaseManager.DeserializationOfCoursesFromFile(AvailableCoursesTable,DataBaseManager.CoursesDBPath);
            DataBaseManager.DeserializationOfCoursesFromFile(ActualCoursesTable,DataBaseManager.CoursesDBPath, user.Name);
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            DataBaseManager.SignUserOnCourse(AvailableCoursesTable, _user);
            DataBaseManager.DeserializationOfCoursesFromFile(ActualCoursesTable, DataBaseManager.CoursesDBPath, _user.Name);
        }

        private void UnsignButton_Click(object sender, EventArgs e)
        {
            DataBaseManager.UnsignUserFromCourse(AvailableCoursesTable, _user);
            DataBaseManager.DeserializationOfCoursesFromFile(ActualCoursesTable, DataBaseManager.CoursesDBPath, _user.Name);
        }

        private void ActualCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = AvailableCoursesTable.Rows[e.RowIndex];
                string selectedId = selectedRow.Cells["GridColumnCourseId"].Value.ToString();
                string json = File.ReadAllText(DataBaseManager.CoursesDBPath);
                Course[] courses = JsonSerializer.Deserialize<Course[]>(json);
                foreach (var course in courses)
                {
                    if (course.Id == selectedId)
                    {
                        Hide();
                        DataBaseManager.CreateDB(course.Name);
                        Form formInstance = UsefullMethods.CreateForm(course.Name + "CourseEnvironmentForm", _user, course);
                        formInstance.FormClosed += (s, arg) =>
                        {
                            Show();
                        };
                        formInstance.Show();
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

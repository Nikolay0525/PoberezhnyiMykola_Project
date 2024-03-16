using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;
using Project.Models;
using Newtonsoft;
using System.Xml.Linq;
using Project.Utilitys;
using Newtonsoft.Json;

namespace Project.Forms

{
    public partial class UniversityEnvironmentForm : MaterialForm
    {
        private readonly User _user;

        public UniversityEnvironmentForm(User User)
        {
            InitializeComponent();
            _user = User;
            PersonName.Text = User.Name;
            PersonRole.Text = User.Role;
            DataBaseManager.DeserializationOfCoursesFromFile(AvailableCoursesTable,DataBaseManager.CoursesDBPath);
            DataBaseManager.DeserializationOfCoursesFromFile(ActualCoursesTable,DataBaseManager.CoursesDBPath, User.Name);
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
                DataGridViewRow selectedRow = ActualCoursesTable.Rows[e.RowIndex];
                string selectedId = selectedRow.Cells["ActualGridColumnCourseId"].Value.ToString();
                string json = File.ReadAllText(DataBaseManager.CoursesDBPath);
                Course[] courses = JsonConvert.DeserializeObject<Course[]>(json);
               // Console.WriteLine(courses[1].Tests[0].Id);
                foreach (var course in courses)
                {
                    if (course.Id == int.Parse(selectedId))
                    {
                        Hide();
                        Form formInstance = FormCreater.CreateForm(course.Name + "CourseEnvironmentForm", _user, course);
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

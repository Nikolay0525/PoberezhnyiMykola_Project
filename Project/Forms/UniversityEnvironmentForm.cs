using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;
using Project.Models;
using Newtonsoft;
using System.Xml.Linq;
using Project.Utilitys;
using Newtonsoft.Json;
using System.Collections.Generic;
using static Project.Utilitys.Predicates;
using static Project.Utilitys.Constants;
using Project.Repository;

namespace Project.Forms

{
    public partial class UniversityEnvironmentForm : MaterialForm
    {
        private readonly User _user;

        public UniversityEnvironmentForm(User user)
        {
            InitializeComponent();
            _user = user;
            PersonName.Text = user.FirstName + " " + user.LastName ;
            PersonRole.Text = user.Role;
            //ReadingOperationsWithTable<Course>(CoursesDBPath, AvailableCoursesTable, 1, _user, UpdateTableWithAvailableCourses);
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<User>(AvailableCoursesTable, 1, _user, UpdateTableWithAvailableCourses);
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<User>(ActualCoursesTable, 1, _user, UpdateTableWithActualCourses);
            //ReadingOperationsWithTable<Course>(CoursesDBPath, ActualCoursesTable, 1, _user, UpdateTableWithActualCourses);
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            //ReadAndWriteOperationsWithTable<Course>(CoursesDBPath, AvailableCoursesTable, 0,_user, SignUserOnCourse);
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadAndWriteOperationsWithTable<User>(AvailableCoursesTable, 0, _user, SignUserOnCourse);
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<User>(ActualCoursesTable, 1, _user, UpdateTableWithActualCourses);
            //ReadingOperationsWithTable<Course>(CoursesDBPath, ActualCoursesTable, 1, _user, UpdateTableWithActualCourses);
        }

        private void UnsignButton_Click(object sender, EventArgs e)
        {
            /*ReadAndWriteOperationsWithTable<Course>(CoursesDBPath, AvailableCoursesTable, 0, _user, UnsignUserFromCourse);
            ReadingOperationsWithTable<Course>(CoursesDBPath, ActualCoursesTable, 1, _user, UpdateTableWithActualCourses);*/
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadAndWriteOperationsWithTable<User>(AvailableCoursesTable, 0, _user, UnsignUserFromCourse);
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<User>(ActualCoursesTable, 1, _user, UpdateTableWithActualCourses);
        }

        private void ActualCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = ActualCoursesTable.Rows[e.RowIndex];
                string selectedId = selectedRow.Cells["ActualGridColumnCourseId"].Value.ToString();
                if (RepositoryManager.GetRepo<Course>(CoursesDBPath).GetObjectByFilter(c => c.Id == Guid.Parse(selectedId)) != null)
                {
                    var course = RepositoryManager.GetRepo<Course>(CoursesDBPath).GetObjectByFilter(c => c.Id == Guid.Parse(selectedId));
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

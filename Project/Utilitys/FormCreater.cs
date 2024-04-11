using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Forms;

namespace Project.Utilitys
{
    public class FormCreater
    {
        public static Form CreateForm(string formName, User user, Course course)
        {
            Type formType = Type.GetType("Project.Forms." + formName);

            if (formType != null && formType.IsSubclassOf(typeof(Form)))
            {
                Form formInstance = (Form)Activator.CreateInstance(formType, user, course);
                return formInstance;
            }
            else
            {
                throw new ArgumentException("Форму з назвою " + formName + " не знайдено.");
            }
        }
        public static Form CreateTestForm(string formName, User user, Course course, Test test)
        {
            Type formType = Type.GetType("Project.Forms." + formName);

            if (formType != null && formType.IsSubclassOf(typeof(Form)))
            {
                Form formInstance = (Form)Activator.CreateInstance(formType, user, course, test);
                return formInstance;
            }
            else
            {
                throw new ArgumentException("Форму з назвою " + formName + " не знайдено.");
            }
        }
    }
}

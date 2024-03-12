﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace Project
{
    public class UsefullMethods
    {
        public static Form CreateForm(string formName, params object[] parameters)
        {
            // Знайдемо тип форми за її назвою
            Type formType = Type.GetType("Project." + formName);

            // Перевіримо, чи знайдено тип
            if (formType != null && formType.IsSubclassOf(typeof(Form)))
            {
                // Створимо екземпляр форми за допомогою конструктора за замовчуванням
                Form formInstance = (Form)Activator.CreateInstance(formType, parameters);
                return formInstance;
            }
            else
            {
                // Якщо форму не знайдено, повернемо null або викличемо виняток, якщо це потрібно
                throw new ArgumentException("Форму з назвою " + formName + " не знайдено.");
            }
        }

        public static void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }
    }
}
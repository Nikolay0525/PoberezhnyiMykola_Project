using Project.Models;
using System;
using System.Reflection;
using System.Windows.Forms;
using Project.Forms;

namespace Project
{
    public class UsefullMethods
    {
        public static void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }
    }
}
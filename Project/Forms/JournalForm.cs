using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Project.Models;

namespace Project.Forms
{
    public partial class JournalForm : MaterialForm
    {
        private readonly User _user;
        private readonly Course _course;
        public JournalForm(User user, Course course)
        {
            _user = user;
            _course = course;
            this.Text = "Welcome to " + course.Name + " journal!";
            InitializeComponent();
            DataBaseManager.UpdateJournal(JournalTable, course);
            if (_user.Role == "Student")
            {
                for (int i = 1; i < JournalTable.ColumnCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = true;
                }
            }
            else
            {
                for (int i = 1; i < JournalTable.ColumnCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = false;
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }
    }
}

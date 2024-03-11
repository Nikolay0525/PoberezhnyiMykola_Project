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

namespace Project
{
    public partial class CourseEnvironment : MaterialForm
    {
        private readonly string _accessLevel;
        public CourseEnvironment(string accessLevel, string courseName)
        {
            InitializeComponent();
            DataBase.CreateJournal(JournalTable);
            if (_accessLevel == "Student")
            {
                for (int i = 0; i < JournalTable.RowCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = true;
                }
            }
            else 
            {
                for (int i = 0; i < JournalTable.RowCount; i++)
                {
                    JournalTable.Columns[i].ReadOnly = false;
                }
            }
            this.Text = "Welcome to " + courseName + "!";
            _accessLevel = accessLevel;
        }

        private void CourseEnvironment_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void JournalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

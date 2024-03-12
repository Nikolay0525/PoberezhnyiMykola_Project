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


namespace Project.Forms
{
    public partial class CourseEnvironmentForm : MaterialForm
    {
        private readonly string _accessLevel;
        private readonly string _dbName;
        public CourseEnvironmentForm(string accessLevel, string courseName, string dbName)
        {
            _dbName = dbName;
            _accessLevel = accessLevel;
            this.Text = "Welcome to " + courseName + "!";
            InitializeComponent();
            DataBaseManager.UpdateJournal(JournalTable);
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
        }

        private void CourseEnvironment_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void JournalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

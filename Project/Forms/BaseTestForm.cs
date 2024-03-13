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
    public partial class BaseTestForm : MaterialForm
    {
        private readonly User _user;
        private readonly Course _course;
        public BaseTestForm(User user, Course course)
        {
            _user = user;
            _course = course;
            InitializeComponent();
        }


    }
}

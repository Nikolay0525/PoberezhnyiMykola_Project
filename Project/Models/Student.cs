using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class Student : User
    {
        public Student()
        {

        }

        public Student(string name, string password, string role) : base(name, password, role)
        {

        }

    }
}

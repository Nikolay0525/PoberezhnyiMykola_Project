using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class Teacher : User
    {
        public Teacher()
        {

        }

        public Teacher(string name, string password, string role) : base(name, password, role)
        {
            
        }

    }
}

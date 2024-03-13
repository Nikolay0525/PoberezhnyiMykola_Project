using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class UserWithMarks : User
    {
        private int[] _marks;
        public int[] Marks
        {
            get
            {
                return _marks;
            }
            set
            {
                foreach (var mark in value)
                {
                    if (mark < 2 || mark > 5)
                    {
                        throw new ArgumentException("Неприпустима оцінка. Оцінка повинна бути 2, 3, 4 або 5.");
                    }
                }
                _marks = value;
            }
        }
        public UserWithMarks() { }

        public UserWithMarks(string name, string password, string role) : base(name,password,role)
        {
        }
    }
}

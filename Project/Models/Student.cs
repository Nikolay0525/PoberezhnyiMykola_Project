using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class Student
    {
        private int _mark;
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                
                if (value < 2 && value != 0 || value > 5 && value != 0)
                {
                    throw new ArgumentException("Неприпустима оцінка. Оцінка повинна бути 2, 3, 4 або 5.");
                }
                _mark = value;
            }
        }
        public string Name { get; set; }
        public Student() { }
        public Student(User user) 
        {
            Name = user.Name;
            Mark = 0;
        }
    }
}

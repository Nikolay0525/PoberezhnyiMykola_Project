using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class Student : EnvironmentObject
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
        public Student(User User) 
        {
            Name = User.Name;
            Mark = 0;
        }

        public override string GetJson()
        {
            return "{name: " + Name + ", mark: " + Mark + "}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Interfaces;

namespace Project.Models
{
    public sealed class Student : User, MyInterfaces.IStudentFeatures, MyInterfaces.IIndexerGet<Student>
    {
        private static readonly List<Student> _students = new List<Student>();
        private int _mark;
        
        public int Mark
        {
            get => _mark;
            
            set
            {
                
                if (value < 2 && value != 0 || value > 5 && value != 0)
                {
                    throw new ArgumentException("Неприпустима оцінка. Оцінка повинна бути 2, 3, 4 або 5.");
                }
                _mark = value;
            }
        }
        public new Student this[int index]
        {
            get => _students[index];
        }
        public Student(string username = "", string firstName = "", string lastName = "") : base(username, firstName, lastName) 
        {
            Mark = 0;
            if (!_students.Exists(student => student.Username == Username))
            {
                _students.Add(this);
            }
        }

        public override string GetJson()
        {
            return "{name: " + Username + ", mark: " + Mark + "}";
        }

        public void ShowProfile(string username = "")
        {

        }
        public void UnsignFromCourse()
        {

        }
    }
}

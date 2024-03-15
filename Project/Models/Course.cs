using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class Course : EnvironmentObject
    {
        public string FacultyName { get; set; }
        public User[] Users {  get; set; }
        public Test[] Tests { get; set; }
        public Course() { }
        public Course(int id, string name, string facultyName)
        {
            Id = id;
            Name = name;
            FacultyName = facultyName;
        }
    }
}

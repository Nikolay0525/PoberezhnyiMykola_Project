using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Course : EnvironmentObject
    {
        public string FacultyName { get; set; }
        public User[] Users {  get; set; }
        public Test[] Tests { get; set; }
        public Course() { }
        public Course(string id, string name, string facultyName, User[] users)
        {
            Id = id;
            Name = name;
            FacultyName = facultyName;
            Users = users;
        }
    }
}

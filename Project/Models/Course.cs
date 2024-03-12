using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FacultyName { get; set; }
        public User[] Users {  get; set; }

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

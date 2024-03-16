using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class Course : EnvironmentObject
    {
        public string Name { get; set; }
        public string FacultyName { get; set; }
        public User[] Users {  get; set; }
        public Test[] Tests { get; set; }
        public Course(int id, string name, string facultyName)
        {
            Id = id;
            Name = name;
            FacultyName = facultyName;
        }
        public override string GetJson()
        {
            var json = "{ name: " + Name + ", facultyname: " + FacultyName + ",";
            if (Users?.Length > 0)
            {
                json = " users: [";
                foreach (var user in Users)
                {
                    json += user.GetJson() + ",";
                }

                json += "], ";
            }

            if (Tests?.Length > 0)
            {
                json = " tests: [";

                foreach (var test in Tests)
                {
                    json += test.GetJson() + ",";
                }

                json += "], ";
            }
            json += " id: " + Id + "}";

            return json;
        }
    }

}

using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class Course : EnvironmentObject, MyInterfaces.IObjectManager<User>
    {
        private string _name;
        private string _facultyName;
        private List<Test> _tests;
        private List<User> _users;

        public string Name { get => _name; set => _name = value; }
        public string FacultyName { get => _facultyName; set => _facultyName = value; }
        public List<Test> Tests { get => _tests; set => _tests = value; }
        public List<User> Users { get => _users; set => _users = value; }
        public Course(int id) : base(id) 
        {

        }
        public Course(int id, string Name, string FacultyName,List<Test> tests, List<User> users) : base(id) 
        {
            _name = Name;
            _facultyName = FacultyName;
            _tests = tests;
            _users = users;
        }
        public List<User> AddObject(User user)
        {
            _users.Add(user);
            return _users;
        }
        public List<User> RemoveObject(User user)
        {
            _users.Remove(user);
            return _users;
        }
        public override string GetJson()
        {
            var json = "{ name: " + Name + ", facultyname: " + FacultyName + ",";
            if (Users?.Count > 0)
            {
                json = " users: [";
                foreach (var user in Users)
                {
                    json += user.GetJson() + ",";
                }

                json += "], ";
            }

            if (Tests?.Count > 0)
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

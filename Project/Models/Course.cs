using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class Course : EnvironmentObject, IObjectManager<User>, IIndexerGet<Course>
    {
        private static readonly List<Course> _courses = new List<Course>();
        private string _name;
        private string _facultyName;
        private List<Test> _tests;
        private List<User> _users;

        public string Name { get => _name; set => _name = value; }
        public string FacultyName { get => _facultyName; set => _facultyName = value; }
        public List<Test> Tests { get => _tests; set => _tests = value; }
        public List<User> Users { get => _users; set => _users = value; }
        public Course this[int index]
        {
            get => _courses[index];
        }
        public Course()
        {

        }
        /*public Course(int id) : base(id)
        {
            _name = "";
            _facultyName = "";
            _tests = new List<Test>();
            _users = new List<User>();
        }*/
        public Course(int id, string name = "", string facultyName = "") : base()
        {
            _name = name;
            _name = facultyName;
            _tests = new List<Test>();
            _users = new List<User>();
            if (!_courses.Exists(obj => obj.Name == Name))
            {
                _courses.Add(this);
            }
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

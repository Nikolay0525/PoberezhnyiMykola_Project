using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class User : EnvironmentObject , IManualWritingToFile, IObjectManager<Course>, IIndexerGet<User>
    {
        private static readonly List<User> _users = new List<User>();
        private string _username;
        private string _firstName;
        private string _lastName;
        private string _password;
        private string _role;
        private List<Course> _courses;

        public string Username { get => _username; set => _username = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
        public User this[int index]
        {
            get => _users[index];
        }
        public List<Course> Courses { get => _courses; set => _courses = value; }
        public User() { }
        public User(string username = "", string firstName = "", string lastName = "")
        {
            _username = username;
            _firstName = firstName;
            _lastName = lastName;
            _courses = new List<Course>();
        }

        public User(string username = "",string firstName = "",string lastName = "", string password = "", string role = "")
        {
            _username = username;
            _firstName = firstName;
            _lastName = lastName;
            _password = password;
            _role = role;
            _courses = new List<Course>();
            if (!_users.Exists(currentUser => currentUser.Username == username))
            {
                _users.Add(this); 
            }
        }
        public List<Course> AddObject(Course course)
        {
            _courses.Add(course);
            return _courses;
        }
        public List<Course> RemoveObject(Course course)
        {
            _courses.Remove(course);
            return _courses;
        }
        public override string GetJson()
        {
            return "{ id: "+ Id + ", username: " + Username + ", password: " + Password + ", role: " + Role + "}";
        }
        public virtual void ShowProfile()
        {

        }
    }
}

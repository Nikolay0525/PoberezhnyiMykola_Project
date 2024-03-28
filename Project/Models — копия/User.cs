using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class User : MyInterfaces.IManualWritingToFile, MyInterfaces.IPersonFeatures, MyInterfaces.IObjectManager<Course>, MyInterfaces.IIndexerGet<string>
    {
        private readonly List<string> _userData;
        private Guid _id;
        private string _username;
        private string _firstName;
        private string _lastName;
        private string _password;
        private string _role;
        private List<Course> _courses;

        public Guid Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
        public List<Course> Courses { get => _courses; set => _courses = value; }
        public string this[int index]
        {
            get => _userData[index];
        }
        public User() { }
        public User(string username, string firstName, string lastName)
        {
            _id = Guid.NewGuid();
            _username = username;
            _firstName = firstName;
            _lastName = lastName;
            _courses = new List<Course>();
            _userData = new List<string>() {_id.ToString(),_username,_firstName,_lastName};
        }

        public User(string username,string firstName,string lastName, string password, string role)
        {
            _id = Guid.NewGuid();
            _username = username;
            _firstName = firstName;
            _lastName = lastName;
            _password = password;
            _role = role;
            _courses = new List<Course>();
            _userData = new List<string>() {_id.ToString(),_username,_firstName,_lastName,_password,_role};
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
        public virtual string GetJson()
        {
            return "{ id: "+ Id + ", username: " + Username + ", password: " + Password + ", role: " + Role + "}";
        }
        public virtual void ShowProfile()
        {

        }
    }
}

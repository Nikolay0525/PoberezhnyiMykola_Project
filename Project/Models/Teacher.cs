using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Models
{
    public class Teacher : User, MyInterfaces.IPersonFeatures, MyInterfaces.IIndexerGet<Teacher>
    {
        private static readonly List<Teacher> _teachers = new List<Teacher>();
        private string _scienceDegree;
        public string ScienceDegree { get => _scienceDegree; set => _scienceDegree = value; }
        public new Teacher this[int index]
        {
            get => _teachers[index];
        }
        public Teacher(string username, string firstName, string lastName, string scienceDegree) : base(username, firstName, lastName)
        {
            _scienceDegree = scienceDegree;
            if (!_teachers.Exists(teacher => teacher.Username == Username))
            {
                _teachers.Add(this);
            }
        }
        public void ShowProfile(string username)
        {

        }

    }
}

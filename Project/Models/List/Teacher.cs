using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Models
{
    public class Teacher : User, MyInterfaces.IPersonFeatures
    {
        private string _scienceDegree;

        public string ScienceDegree { get => _scienceDegree; set => _scienceDegree = value; }
        public Teacher(string username, string firstName, string lastName, string scienceDegree) : base(username, firstName, lastName)
        {
            _scienceDegree = scienceDegree;
        }
        public void ShowProfile(string username)
        {

        }

    }
}

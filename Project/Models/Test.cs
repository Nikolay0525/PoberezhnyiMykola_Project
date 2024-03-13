using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Test : EnvironmentObject
    {
        public string Description { get; set; }
        public UserWithMarks[] Users { get; set; }
        
        public Test() { }
        public Test(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}

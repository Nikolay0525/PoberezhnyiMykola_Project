using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TestQuestion[] Question { get; set; }
        public Student[] Students { get; set; }
        public Test() { }
        public Test(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}

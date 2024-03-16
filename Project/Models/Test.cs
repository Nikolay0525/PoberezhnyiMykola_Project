using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class Test : EnvironmentObject
    {
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

        public override string GetJson()
        {
            var json = "{ name: " + Name + ", Description: " + Description + ",";
            if (Question?.Length > 0)
            {
                json = " question: [";
                foreach (var question in Question)
                {
                    json += question.GetJson() + ",";
                }

                json += "], ";
            }

            if (Students?.Length > 0)
            {
                json = " students: [";

                foreach (var student in Students)
                {
                    json += student.GetJson() + ",";
                }

                json += "], ";
            }
            json += " id: " + Id + "}";

            return json;
        }
    }
}

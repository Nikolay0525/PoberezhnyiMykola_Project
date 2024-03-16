using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class QuestionAnswer : EnvironmentObject
    {
        public Student[] Students { get; set; }
        public QuestionAnswer() { }

        public override string GetJson()
        {
            var json = "{";
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

    public static class MyDeserialize<T> where T : EnvironmentObject
    {
        public static string Deserialize(T obj)
        {
            return obj.GetJson();
        }
    }
}

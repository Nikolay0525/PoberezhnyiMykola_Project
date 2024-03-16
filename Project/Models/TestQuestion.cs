using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class TestQuestion : EnvironmentObject
    {
        public QuestionAnswer[] Answer { get; set; }
        public TestQuestion() { }

        public override string GetJson()
        {
            var json = "{";
            if(Answer?.Length > 0)
            {
                json = " answer: [";
                foreach(var answer in Answer)
                {
                    json += answer.GetJson() + ",";
                }

                json += "], ";
            }
            json += " id: " + Id + "}";

            return json;
        }
    }
}

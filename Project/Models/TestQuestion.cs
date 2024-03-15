using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class TestQuestion
    {
        public int Id { get; set; }
        public QuestionAnswer[] Answer { get; set; }
        public TestQuestion() { }
    }
}

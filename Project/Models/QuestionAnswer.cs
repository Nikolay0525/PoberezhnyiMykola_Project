using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class QuestionAnswer
    {
        public int Id { get; set; }
        public Student[] Students { get; set; }
        public QuestionAnswer() { }
    }
}

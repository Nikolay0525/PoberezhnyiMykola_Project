using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;

namespace Project.Models
{
    public abstract class EnvironmentObject
    {
        public int Id { get; set; }
        public virtual string GetJson()
        {
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public sealed class User : EnvironmentObject
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User(string name, string password, string role)
        {
            Name = name;
            Password = password;
            Role = role;
        }
        public User()
        {
        }
        public User(User User)
        {
            Name = User.Name;
            Password = User.Password;
            Role = User.Role;
        }
        public override string GetJson()
        {
            return "{name: " + Name + ", password: " + Password + ", role: " + Role + "}";
        }
    }
}

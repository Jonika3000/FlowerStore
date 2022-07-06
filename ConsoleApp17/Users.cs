using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Users
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public Users(string obj_username, string obj_password)
        {
            Name = obj_username;
            Password = obj_password;
        }

    }
}

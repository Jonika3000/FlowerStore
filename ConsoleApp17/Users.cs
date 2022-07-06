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
        
        public void Exit()
        {
            Console.WriteLine("Enter your username -> ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your password -> ");
            Password = Console.ReadLine();


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Menu
    {
        ConsoleKeyInfo k;
        string path = "C:\\Users\\nazam\\source\\repos\\FlowerStore\\ConsoleApp17\\bin\\Debug\\net6.0\\users.json";
        public string username { get; set; }
        public string password { get; set; }
        List<Users> users = new List<Users>();
        
        public void AddNewUserName()
        {
            Console.WriteLine("Enter your username ->");
        a:
            username = Console.ReadLine();
            if (CheckRepeat(username) == 1)
                goto a;
            Console.WriteLine("Enter your password ->");
            password = Console.ReadLine();
            Console.WriteLine("Enter your date of birthday ->");
            users.Add(new Users(username, password));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Users>>(fs, users);
            }
        }

        public void AddUsersFromFile()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                users = JsonSerializer.Deserialize<List<Users>>(fs);
            }
        }
        public int CheckRepeat(string obj_user)
        {
            foreach (Users user in users)
            {
                if (user.Name == obj_user)
                {
                    Console.WriteLine("Such a login already exists,");
                    Console.WriteLine("enter username again!");
                    return 1;
                }
            }
            return 0;
        }
        public void Login()
        {
            
        b:
            Console.WriteLine("Enter your username ->");
            username = Console.ReadLine();
            Console.WriteLine("Enter your password ->");
            password = Console.ReadLine();
            foreach (Users user in users)
            {
                if (username == user.Name && password == user.Password)
                {
                    user.Name = username;
                    user.Password = password;;
                    Console.WriteLine("You have successfully logged in!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid login or password,");
                    Console.WriteLine("please try again(enter 9), or enter 10 if you want to register!");
                    int q;
                    q = int.Parse(Console.ReadLine());
                    if (q == 10)
                        AddNewUserName();
                    else
                        goto b;
                }

            }
        }

        public void MenuShow()
        {
            Console.Clear();
            Console.WriteLine("Make a choice:");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.WriteLine("Else->Exit");
            k = Console.ReadKey();
            Console.WriteLine("");
            if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
            {
                AddUsersFromFile();
                Login();
            }
            else if (k.Key == ConsoleKey.D2 && k.Key == ConsoleKey.NumPad2)
            {
                AddNewUserName();
            }
        }

    }
}

using System.Text.Json;

namespace ConsoleApp17
{
    public class Menu
    {
        FlowerStore flowerStore = new FlowerStore();
        ConsoleKeyInfo k;
        string path = @"users.json";
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

        private void ViewOrders()
        {

        }
        public void AdminMenu(Users u)
        {
            Console.Clear();
            Console.WriteLine("Make a choice:");
            Console.WriteLine("1.Add Flowers");
            Console.WriteLine("2.View orders");
            Console.WriteLine("Else->Exit");
            k = Console.ReadKey();
            Console.WriteLine("");
            if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
            {
                AddFlowers();
            }
            else if (k.Key == ConsoleKey.D2 && k.Key == ConsoleKey.NumPad2)
            {
                ViewOrders();
            }
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
                    Console.WriteLine("You have successfully logged in!");

                    if (user.Name == "Admin" && user.Password == "Admin")
                    {
                        AdminMenu(user);
                    }
                    else
                    {
                        user.Name = username;
                        user.Password = password; ;
                        break;
                    }

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
        public void EditPassword()
        {
            foreach (Users user in users)
            {
                if (user.Name == username)
                {
                    Console.WriteLine("Enter your new password -> ");
                    string pass = Console.ReadLine();
                    user.Password = pass;
                    password = pass;
                }
            }
        }
        public void MenuShow()
        {
            Console.Clear();
            Console.WriteLine("Make a choice:");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.WriteLine("3.Edit password");
            Console.WriteLine("Else->Exit");
            k = Console.ReadKey();
            Console.WriteLine("");
            if (k.Key == ConsoleKey.D1 || k.Key == ConsoleKey.NumPad1)
            {
                AddUsersFromFile();
                Login();
            }
            else if (k.Key == ConsoleKey.D2 || k.Key == ConsoleKey.NumPad2)
            {
                AddNewUserName();
            }
            else if (k.Key == ConsoleKey.D3 && k.Key == ConsoleKey.NumPad3)
            {
                EditPassword();
            }
        }
        public void UserMenu()
        {
            ConsoleKeyInfo k;
            while (true)
            {
                int count;
                Console.WriteLine("What flowers want you buy?");
                Console.WriteLine("1-Roza , 2 -Romashka  , 3 - Toulpan,4 - This is it");
                k = Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("How much to add?");
                count = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
                    {
                        
                    }
                    else if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
                    {
                        
                    }
                    else if (k.Key == ConsoleKey.D3 && k.Key == ConsoleKey.NumPad3)
                    {
                        
                    }
                    else if (k.Key == ConsoleKey.D4 && k.Key == ConsoleKey.NumPad4)
                        break;
                }
            }
            
        }

    }
}

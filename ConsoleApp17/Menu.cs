using System.Text.Json;

namespace ConsoleApp17
{
    public class Menu
    {
        FlowerStore flowerStore = new FlowerStore();
        ConsoleKeyInfo k;
        List<Users> users = new List<Users>();
        List<Order> orders = new List<Order>();
        public string username { get; set; }
        public string password { get; set; }
       public Menu ()
        {
            Users d = new Users();
            d.Password = "Admin";
            d.Name = "Admin";
            users.Add(d);
        }
        public void Loginer()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Make a choice:");
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register");
                Console.WriteLine("Else->Exit");
                k = Console.ReadKey();
                Console.WriteLine("");
                if (k.Key == ConsoleKey.D1 || k.Key == ConsoleKey.NumPad1)
                {
                    Users r = new Users();
                    Console.WriteLine("Enter login:");
                    r.Name = Console.ReadLine();

                    Console.WriteLine("Enter password");
                    r.Password = Console.ReadLine();
                    var d = users.Where(a => a.Name == r.Name && a.Password == r.Password).FirstOrDefault();

                    if (d != null)
                    {
                         
                        if (r.Name != "Admin")
                            MenuU(r);
                        else
                            AdminMenu(r);
                    }
                    else
                    {
                        Console.WriteLine("Invalid password or login");
                        Console.ReadKey();
                    }
                }
                else if (k.Key == ConsoleKey.D2 || k.Key == ConsoleKey.NumPad2)
                {
                    Users ro = new Users();
                    ro.Register();
                    var d = users.Where(a => a.Name == ro.Name).FirstOrDefault();

                    if (d == null)
                    {
                        users.Add(ro);
                        Console.WriteLine("Ready");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("User already registered");
                        Console.ReadKey();
                    }

                }
                else
                {
                    GC.Collect();
                    Environment.Exit(0);
                    break;
                }
            }
        }
        void MenuU(Users u)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Make a choice:");
                Console.WriteLine("1.Change password");
                Console.WriteLine("2.Make an order");
                Console.WriteLine("Else->Exit");
                k = Console.ReadKey();
                Console.WriteLine("");
                if (k.Key == ConsoleKey.D1 || k.Key == ConsoleKey.NumPad1)
                {
                    ChangePass(u);
                }
                else if (k.Key == ConsoleKey.D2 || k.Key == ConsoleKey.NumPad2)
                {
                    UserMenu();
                }
                
                else
                {

                    break;
                }
                Console.WriteLine("Ready");
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
            foreach(var order in orders)
            {
                if (order.Status == false)
                {
                    Console.WriteLine($"ID oreder: {order.id}");
                    foreach(var q in order.flowers)
                    {
                        if (q.GetType() == typeof(Roza))
                            Console.Write($"Roza,");
                        if (q.GetType() == typeof(Romashka))
                            Console.Write($"Romashka,");
                        if (q.GetType() == typeof(Tulpan))
                            Console.Write($"Tulpan,");
                    }
                    Console.Write($".");
                    Console.WriteLine("");
                    Console.WriteLine("Accept an order? (1-yes , 2- no)");
                    k = Console.ReadKey();
                    Console.WriteLine("");
                    if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
                    {
                        order.Status = true;
                        flowerStore.Del(order);
                    }
                   else if (k.Key == ConsoleKey.D2 && k.Key == ConsoleKey.NumPad2)
                    {
                        orders.Remove(order);
                    }
                }

            }
        }
        public void AdminMenu(Users u)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Make a choice:");
                Console.WriteLine("1.Add Flowers");
                Console.WriteLine("2.View orders");
                Console.WriteLine("3.Change password");
                Console.WriteLine("Else->Exit");
                k = Console.ReadKey();
                Console.WriteLine("");
                if (k.Key == ConsoleKey.D1 || k.Key == ConsoleKey.NumPad1)
                {
                    flowerStore.AddFlower();
                }
                else if (k.Key == ConsoleKey.D2 || k.Key == ConsoleKey.NumPad2)
                {
                    ViewOrders();
                }
                else if (k.Key == ConsoleKey.D3 || k.Key == ConsoleKey.NumPad3)
                {
                    ChangePass(u);
                }
                else
                    break;
            }
            
        }
        void ChangePass(Users u)
        {
            string g;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name == u.Name)
                {
                    Console.WriteLine("Enter new pass");
                    g = Console.ReadLine();
                    users[i].Password = g;
                    Console.WriteLine("Ready");
                    break;
                }
            }
        }
        
        public void UserMenu()
        {
            ConsoleKeyInfo k;
            Random r = new Random();    
            Order or = new Order(r.Next(0,1000));
            int t_count, roza_count, romashka_count;
            Console.WriteLine("Enter the number of daisies -> ");
            romashka_count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of toulpan -> ");
            t_count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of rose -> ");
            roza_count = Int32.Parse(Console.ReadLine());

            Console.WriteLine("1 - Just add, 2 - Add with sequence");
            k = Console.ReadKey();
            if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
            {
                or.flowers = flowerStore.Sell(roza_count,romashka_count,t_count);
            }
            else if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
            {
                or.flowers =flowerStore.sellSequence(roza_count, romashka_count, t_count);
            }

            orders.Add(or);
        }

    }
}

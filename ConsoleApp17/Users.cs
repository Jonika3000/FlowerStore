namespace ConsoleApp17
{
    public class Users
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public void Register()
        {
            Console.WriteLine("Enter login:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter password:");
            Password = Console.ReadLine();
        }

     }
}

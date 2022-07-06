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

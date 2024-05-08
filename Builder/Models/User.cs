namespace Builder.Models
{
    internal class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string? PhoneNumber { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
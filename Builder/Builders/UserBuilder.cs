using Builder.Models;

namespace Builder.Builders
{
    internal class UserBuilder
    {
        private string _name { get; set; }
        private string _email { get; set; }
        private string? _phoneNumber { get; set; }
        private int _age { get; set; }
        private int _height { get; set; }
        private int _weight { get; set; }

        public UserBuilder(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public UserBuilder WithPhoneNumber(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
            return this;
        }
        public UserBuilder WithAge(int age)
        {
            _age = age;
            return this;
        }
        public UserBuilder WithHeight(int height)
        {
            _height = height;
            return this;
        }
        public UserBuilder WithWeight(int weight)
        {
            _weight = weight;
            return this;
        }
        public User Build()
        {
            return new User(_name, _email)
            {
                PhoneNumber = _phoneNumber,
                Age = _age,
                Height = _height,
                Weight = _weight
            };
        }
    }
}
using Composite.Contracts;

namespace Composite.Models
{
    internal class Leaf : IDisplayComponent
    {
        private string _name;

        public Leaf(string name)
        {
            _name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }
    }
}
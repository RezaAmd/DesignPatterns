using Decorator.Contracts;

namespace Decorator.Components
{
    internal class ConcreteComponent : IOperationComponent
    {
        public void Operation()
        {
            Console.WriteLine("Concrete Component operation.");
        }
    }
}
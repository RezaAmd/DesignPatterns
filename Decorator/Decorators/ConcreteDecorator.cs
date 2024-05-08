using Decorator.Contracts;

namespace Decorator.Decorators
{
    internal class ConcreteDecorator : DecoratorObj
    {
        public ConcreteDecorator(IOperationComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        private void AddedBehavior()
        {
            Console.WriteLine("Added behavior by Concrete Decorator.");
        }
    }
}
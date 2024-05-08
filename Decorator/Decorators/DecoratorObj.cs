using Decorator.Contracts;

namespace Decorator.Decorators
{
    internal class DecoratorObj : IOperationComponent
    {
        protected IOperationComponent _component;

        public DecoratorObj(IOperationComponent component)
        {
            _component = component;
        }

        public virtual void Operation()
        {
            _component.Operation();
        }
    }
}
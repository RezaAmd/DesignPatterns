using Composite.Contracts;

namespace Composite.Composites
{
    internal class CompositeNode : IDisplayComponent
    {
        private List<IDisplayComponent> _children = new List<IDisplayComponent>();

        public void Add(IDisplayComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IDisplayComponent component)
        {
            _children.Remove(component);
        }

        public void Display(int depth)
        {
            foreach (var child in _children)
            {
                child.Display(depth + 1);
            }
        }
    }
}
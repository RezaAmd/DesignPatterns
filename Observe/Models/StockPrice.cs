namespace Observe.Models
{
    internal class StockPrice : ISubject
    {
        private decimal _price;
        private List<IObserver> _observers = new List<IObserver>();

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    NotifyObservers();
                }
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            Console.WriteLine("....");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
            Console.WriteLine("....");
        }

    }
}
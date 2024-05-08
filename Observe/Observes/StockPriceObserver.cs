using Observe.Models;

namespace Observe.Observes
{
    internal class StockPriceObserver : IObserver
    {
        private string _name;

        public StockPriceObserver(string name)
        {
            _name = name;
        }

        public void Update(ISubject subject)
        {
            if (subject is StockPrice stockPrice)
            {
                Console.WriteLine($"{_name} received an update: the stock price is now {stockPrice.Price}");
            }
        }
    }
}
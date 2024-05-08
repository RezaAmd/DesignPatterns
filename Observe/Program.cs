using Observe.Models;
using Observe.Observes;

Console.WriteLine("Observe design pattern:");

var stockPrice = new StockPrice();
var observer1 = new StockPriceObserver("Investor A");
var observer2 = new StockPriceObserver("Investor B");

stockPrice.RegisterObserver(observer1);
stockPrice.RegisterObserver(observer2);

stockPrice.Price = 100.0m;
// Output:
// Investor A received an update: the stock price is now 100.0
// Investor B received an update: the stock price is now 100.0

stockPrice.Price = 120.0m;
// Output:
// Investor A received an update: the stock price is now 120.0
// Investor B received an update: the stock price is now 120.0

//stockPrice.RemoveObserver(observer1);
stockPrice.Price = 110.0m;
// Output:
// Investor B received an update: the stock price is now 110.0
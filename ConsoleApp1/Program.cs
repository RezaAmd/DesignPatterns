using Adapter.Adapters;
using Adapter.Models;

Console.WriteLine("Adapter design pattern:");

var electricCar = new ElectricCar();
electricCar.Charge(220, 32); // Outputs: Charging electric car with 220V and 32A.

var hybridCar = new HybridCar();
var hybridCarAdapter = new HybridCarAdapter(hybridCar);
hybridCarAdapter.Charge(220, 16); // Outputs: Charging hybrid car battery with 220V. Charging hybrid car with 16A.
// See https://aka.ms/new-console-template for more information
using Prototype.Models;

Console.WriteLine("Prototype design pattern:");

List<string> fordOptions = new() { "Sunroof", "Navigation" };
Car ford = new("Mustang", 2022, fordOptions);

// Clone from ford.
Car newFord = ford.Clone();

// Change ford detail;
ford.Year = 2025;

Console.WriteLine($"New ford year {newFord.Year}");

namespace Prototype.Models
{
    internal class Car : Prototype<Car>
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public List<string> Options { get; set; }

        public Car(string model, int year, List<string> options)
        {
            Model = model;
            Year = year;
            Options = options;
        }

        public override Car Clone()
        {
            return new Car(Model, Year, Options);
        }
    }
}
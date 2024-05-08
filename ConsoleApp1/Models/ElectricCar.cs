namespace Adapter.Models
{
    public class ElectricCar
    {
        public virtual void Charge(int voltage, int amperage)
        {
            Console.WriteLine($"Charging electric car with {voltage}V and {amperage}A.");
        }
    }
}
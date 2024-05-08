namespace Adapter.Models
{
    public class HybridCar
    {
        public void ChargeBattery(int voltage)
        {
            Console.WriteLine($"Charging hybrid car battery with {voltage}V.");
        }
    }
}
using Adapter.Models;

namespace Adapter.Adapters
{
    public class HybridCarAdapter : ElectricCar
    {
        private HybridCar _hybridCar;

        public HybridCarAdapter(HybridCar hybridCar)
        {
            _hybridCar = hybridCar;
        }

        public override void Charge(int voltage, int amperage)
        {
            // Adapt the charging interface to match the HybridCar's requirements
            _hybridCar.ChargeBattery(voltage);
            Console.WriteLine($"Charging hybrid car with {amperage}A.");
        }
    }
}
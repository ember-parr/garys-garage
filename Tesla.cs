using System;

namespace GarysGarage
{
    public class Tesla : Vehicle, IElectricVehicle  // Electric car
    {
        public double BatteryKWh { get; set; } = 100;

        public double CurrentChargePercentage { get; set; } = 40;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"Your Tesla is now charged to {BatteryKWh}kWh");
        }


        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. Swoosh!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla rolls to a stop after 12 feet on the runway");
        }
    }
}
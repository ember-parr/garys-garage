using System;

namespace GarysGarage
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; } = 14;
        public double CurrentChargePercentage { get; set; } = 40;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"Your Zero is now charged to {BatteryKWh}kWh");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. Squeeeekkkkk!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero rolls to a stop after 3 inches on the runway");
        }
    }
}
using System;

namespace GarysGarage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; } = 38;
        public double CurrentTankPercentage { get; set; } = 50;
        public void RefuelTank()
        {
            {
                CurrentTankPercentage = 100;
                Console.WriteLine($"Your Ram is all gassed up, {FuelCapacity} gal");
            }
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. RRrrrrummbbble!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram rolls to a stop after six miles on the runway");
        }
    }
}
using System;

// child class or 'subclass'
namespace GarysGarage
{
    public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; } = 20;
        public double CurrentTankPercentage { get; set; } = 50;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            Console.WriteLine($"Your Cessna now has a full tank at {FuelCapacity} gallons.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past. Zoom!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after a mile on the runway");
        }


        // public override string ToString()
        // {
        //     return $"This is a Cessna with a fuel capacity of {FuelCapacity}";
        // }
    }
}
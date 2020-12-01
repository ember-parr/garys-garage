using System;
// parent or "base" class

namespace GarysGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public string Engine { get; set; }
        public int Passengers { get; set; }
        public string Move { get; set; }
        public string Accelerate { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vroom!!!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine("Turn Now");
        }

        public virtual void Stop()
        {
            Console.WriteLine("STOP NOW!!");
        }
    }
}
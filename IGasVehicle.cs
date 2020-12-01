using System;

namespace GarysGarage
{
    public interface IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank();
    }
}
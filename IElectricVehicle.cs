using System;

namespace GarysGarage
{
    public interface IElectricVehicle
    {
        public double CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // empty method
        }
    }
}
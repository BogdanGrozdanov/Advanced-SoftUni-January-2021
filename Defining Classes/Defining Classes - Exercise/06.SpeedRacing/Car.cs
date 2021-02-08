using System;

namespace SpeedRacing
{
    public class Car
    {
        public Car()
        {
            Model = String.Empty;
            FuelAmount = 0;
            FuelConsumptionPerKilometer = 0;
        }

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km) : this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionFor1km;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(double amountOfKm)
        {
            double fuelNeeded = FuelConsumptionPerKilometer * amountOfKm;

            if (FuelAmount >= fuelNeeded)
            {
                FuelAmount -= fuelNeeded;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }





    }
}

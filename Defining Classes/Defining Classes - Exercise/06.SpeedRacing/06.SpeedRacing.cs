using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>()
                ;
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
                if (!cars.Contains(currentCar))
                {
                    cars.Add(currentCar);
                }
            }

            string[] drive = Console.ReadLine().Split();

            while (drive[0] != "End")
            {

                string model = drive[1];
                double amountOfKm = double.Parse(drive[2]);

                Car car = cars.First(car => car.Model == model);
                car.Drive(amountOfKm);
                drive = Console.ReadLine().Split();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }


    }
}

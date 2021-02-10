using System;
using System.Collections.Generic;

namespace _08.CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            int numEngine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numEngine; i++)
            {
                Engine engine = new Engine();
                var paramEngine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                engine.AddEngine(paramEngine);
                engines.Add(engine);
            }
            List<Car> cars = new List<Car>();
            int numCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCars; i++)
            {
                Car car = new Car();
                var paramCar = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                car.AddCar(paramCar);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                foreach (var engin in engines)
                {
                    if (car.Engine == engin.Model)
                    {
                        Console.WriteLine($"{car.Model}:\n  {engin.Model}:\n    Power: {engin.Power}\n    Displacement: {engin.Displacement}\n    Efficiency: {engin.Efficiency}\n  Weight: {car.Weight}\n  Color: {car.Color}");
                    }
                }
            }
        }
    }
}

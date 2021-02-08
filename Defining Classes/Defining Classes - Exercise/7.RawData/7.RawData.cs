using System;
using System.Collections.Generic;

namespace RawData
{
    public class StartUpProgram
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numOfCar = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCar; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
                double[] splitTire = new double[] { double.Parse(input[5]), double.Parse(input[6]), double.Parse(input[7]), double.Parse(input[8]) };
                List<Tire> tires = new List<Tire>();
                for (int t = 0; t < splitTire.Length; t += 2)
                {
                    Tire currTire = new Tire(splitTire[t], splitTire[t + 1]);
                    tires.Add(currTire);
                }
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string comand = Console.ReadLine();
            if (comand == "fragile")
            {
                foreach (Car car in cars)
                {
                    foreach (var tire in car.Tires)
                    {
                        if (tire.TirePressure < 1)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }
            }
            else
            {

            }
        }
    }
}

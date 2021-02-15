using System;
using System.Collections.Generic;

namespace _06ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parkedCar = new HashSet<string>();

            while (input != "END")
            {
                string[] splitted = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string status = splitted[0];
                string numPlate = splitted[1];
                if (status == "IN")
                {
                    parkedCar.Add(numPlate);
                }
                if (status == "OUT")
                {
                    parkedCar.Remove(numPlate);
                }
                input = Console.ReadLine();
            }
            if (parkedCar.Count > 0)
            {
                foreach (var car in parkedCar)
                {
                    Console.WriteLine(car);
                }
            }
            else if (parkedCar.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }


        }
    }
}

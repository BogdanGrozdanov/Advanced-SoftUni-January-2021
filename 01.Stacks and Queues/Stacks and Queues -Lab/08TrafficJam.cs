using System;
using System.Collections.Generic;

namespace _8TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCarPass = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int counter = 0;
            while (comand != "end")
            {
                if (comand != "green")
                {
                    cars.Enqueue(comand);
                }
                else if (comand == "green")
                {
                    for (int i = 0; i < numCarPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            counter++;
                            Console.WriteLine(cars.Dequeue() + " passed!");
                        }
                    }
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}

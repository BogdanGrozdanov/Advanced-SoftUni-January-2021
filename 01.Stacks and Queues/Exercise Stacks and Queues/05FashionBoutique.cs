using System;
using System.Collections.Generic;
using System.Linq;

namespace _05FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int capacity = int.Parse(Console.ReadLine());

            int currentCapacity = capacity;
            Stack<int> clotnes = new Stack<int>(input);
            int counter = 1;

            while (clotnes.Count > 0)
            {
                if (currentCapacity >= clotnes.Peek())
                {
                    currentCapacity -= clotnes.Pop();
                }
                else
                {
                    counter++;
                    currentCapacity = capacity;
                }

            }
            Console.WriteLine(counter);
        }
    }
}
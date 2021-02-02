using System;
using System.Collections.Generic;
using System.Linq;

namespace _5PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    queue.Enqueue(numbers[i]);
                }
            }

            while (queue.Count > 0)
            {
                if (queue.Count > 1)
                {
                    Console.Write(queue.Dequeue() + ", ");
                }
                else
                {
                    Console.Write(queue.Dequeue());
                }
            }
        }
    }
}

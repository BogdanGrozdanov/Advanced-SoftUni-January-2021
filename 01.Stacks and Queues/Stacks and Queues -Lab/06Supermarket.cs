using System;
using System.Collections.Generic;

namespace _6Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            while (input != "End")
            {
                if (input != "Paid")
                {
                    queue.Enqueue(input);
                }
                else if (input == "Paid")
                {
                    int counter = queue.Count;

                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}

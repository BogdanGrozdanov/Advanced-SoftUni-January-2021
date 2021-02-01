using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int allQuantity = int.Parse(Console.ReadLine());
            int[] allOrders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(allOrders);
            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                int currOrderQuantity = orders.Peek();

                if (currOrderQuantity > allQuantity)
                {
                    break;
                }
                else
                {
                    allQuantity -= orders.Dequeue();
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            if (orders.Count > 0)
            {
                Console.WriteLine("Orders left: " + string.Join(" ", orders));
            }

        }
    }
}
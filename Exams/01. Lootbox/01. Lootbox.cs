using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBoxData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondBoxData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> firstBox = new Queue<int>(firstBoxData);
            Stack<int> secondBox = new Stack<int>(secondBoxData);
            int items = 0;
            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int firstValue = firstBox.Peek();
                int secondValue = secondBox.Peek();
                int sum = firstValue + secondValue;
                if (sum % 2 == 0)
                {
                    firstBox.Dequeue();
                    secondBox.Pop();
                    items += sum;
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            else
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (items >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {items}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {items}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liliesData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] rosesData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> lilies = new Stack<int>();
            for (int i = 0; i < liliesData.Length; i++)
            {
                int curr = liliesData[i];
                lilies.Push(curr);
            }
            Queue<int> roses = new Queue<int>();
            for (int i = 0; i < rosesData.Length; i++)
            {
                roses.Enqueue(rosesData[i]);
            }
            int mixed = 0;
            int wreath = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int sum = lilies.Peek() + roses.Peek();
                if (sum == 15)
                {
                    wreath++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                if (sum > 15)
                {
                    int lilie = (lilies.Pop()) - 2;
                    lilies.Push(lilie);
                }
                if (sum < 15)
                {
                    mixed += ((lilies.Pop() + roses.Dequeue()));
                }
            }
            wreath+=( mixed / 15);

            if (wreath >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-wreath} wreaths more!");
            }
        }
    }
}

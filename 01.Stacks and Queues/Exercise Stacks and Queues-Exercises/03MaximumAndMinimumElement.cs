using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numComands = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numComands; i++)
            {
                int[] comand = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (comand[0] == 1)
                {
                    stack.Push(comand[1]);
                }
                else if (comand[0] == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();

                    }
                }
                if (stack.Count > 0)
                {
                    if (comand[0] == 3)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else if (comand[0] == 4)
                    {
                        Console.WriteLine(stack.Min());

                    }
                }


            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
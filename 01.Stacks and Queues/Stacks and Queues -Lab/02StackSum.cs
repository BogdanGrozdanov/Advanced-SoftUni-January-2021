using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string[] comand = Console.ReadLine().ToLower().Split(" ");

            while (comand[0] != "end")
            {
                if (comand[0] == "add")
                {
                    stack.Push(int.Parse(comand[1]));
                    stack.Push(int.Parse(comand[2]));
                }

                if (comand[0] == "remove")
                {
                    if (stack.Count > int.Parse(comand[1]))
                    {
                        for (int i = 0; i < int.Parse(comand[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        continue;
                    }


                }
                comand = Console.ReadLine().ToLower().Split(" ");
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}

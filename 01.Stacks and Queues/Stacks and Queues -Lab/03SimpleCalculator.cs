using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> stack = new Stack<string>(input);

            int result = 0;

            while (stack.Count > 1)
            {
                string number1 = stack.Pop();
                string sing = stack.Pop();
                string number2 = stack.Pop();
                if (sing == "-")
                {
                    result = int.Parse(number1) - int.Parse(number2);
                    stack.Push(result.ToString());
                }
                else
                {
                    result = int.Parse(number1) + int.Parse(number2);
                    stack.Push(result.ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}

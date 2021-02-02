using System;
using System.Collections.Generic;

namespace _4MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string exspression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < exspression.Length; i++)
            {
                if (exspression[i] == '(')
                {
                    stack.Push(i);
                }
                if (exspression[i] == ')')
                {
                    int startIndex = stack.Pop();
                    Console.WriteLine(exspression.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}

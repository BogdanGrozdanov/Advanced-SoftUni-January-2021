using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRetakeExam16_December_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquidData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] elementData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> liquid = new Queue<int>(liquidData);
            Stack<int> element = new Stack<int>(elementData);
            int bread = 0;
            int cake = 0;
            int fruitPie = 0;
            int pastry = 0;
            while (liquid.Count > 0 && element.Count > 0)
            {
                int liquidValue = liquid.Peek();
                int elementValue = element.Peek();
                int sum = liquidValue + elementValue;
                if (sum == 25)
                {
                    bread++;
                    liquid.Dequeue();
                    element.Pop();
                }
                else if (sum == 50)
                {
                    cake++;
                    liquid.Dequeue();
                    element.Pop();
                }
                else if (sum == 75)
                {
                    pastry++;
                    liquid.Dequeue();
                    element.Pop();
                }
                else if (sum == 100)
                {
                    fruitPie++;
                    liquid.Dequeue();
                    element.Pop();
                }
                else
                {
                    liquid.Dequeue();
                    element.Pop();
                    element.Push(elementValue + 3);
                }
            }

            if (bread >= 1 && cake >= 1 && fruitPie >= 1 && pastry >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            //liquid output
            if (liquid.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.Write($"Liquids left: ");
                while (liquid.Count > 0)
                {
                    if (liquid.Count == 1)
                    {
                        Console.WriteLine(liquid.Dequeue());
                    }
                    else
                    {
                        Console.Write($"{liquid.Dequeue()}, ");
                    }
                }
            }
            //element output
            if (element.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.Write($"Ingredients left: ");
                while (element.Count > 0)
                {
                    if (element.Count == 1)
                    {
                        Console.WriteLine(element.Pop());
                    }
                    else
                    {
                        Console.Write($"{element.Pop()}, ");
                    }
                }
            }
            Console.WriteLine($"Bread: {bread}\nCake: {cake}\nFruit Pie: {fruitPie}\nPastry: {pastry}");
        }
    }
}

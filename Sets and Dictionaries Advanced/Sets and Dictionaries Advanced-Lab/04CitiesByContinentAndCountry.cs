using System;
using System.Collections.Generic;

namespace _04CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> normal = new HashSet<string>();
            HashSet<string> vips = new HashSet<string>();
            while (input != "PARTY")
            {
                bool vip = char.IsDigit(input[0]);
                if (vip)
                {
                    vips.Add(input);
                }
                else
                {
                    normal.Add(input);
                }
                input = Console.ReadLine();
            }
            while (input != "END")
            {
                if (vips.Contains(input))
                {
                    vips.Remove(input);
                }
                normal.Remove(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(normal.Count + vips.Count);
            foreach (var guest in vips)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in normal)
            {
                Console.WriteLine(guest);
            }


        }
    }
}

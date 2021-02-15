using System;
using System.Collections.Generic;

namespace _03ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, double>> output = new SortedDictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                var splitted = input.Split(",");
                string supermarket = splitted[0];
                string product = splitted[1];
                double price = double.Parse(splitted[2]);
                if (!output.ContainsKey(supermarket))
                {
                    output.Add(supermarket, new Dictionary<string, double>());
                }

                if (!output[supermarket].ContainsKey(product))
                {
                    output[supermarket].Add(product, price);
                }

                input = Console.ReadLine();
            }
            foreach (var shop in output)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product:{product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}

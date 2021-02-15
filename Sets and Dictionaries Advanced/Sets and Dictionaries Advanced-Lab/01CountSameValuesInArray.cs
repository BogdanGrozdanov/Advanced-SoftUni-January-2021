using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountSameValuesInArray
{
    class Program
    {
        public static object Split { get; private set; }

        static void Main(string[] args)
        {
            double[] inputNum = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> times = new Dictionary<double,int>();

            for (int i = 0; i < inputNum.Length; i++)
            {
                if (!times.ContainsKey(inputNum[i]))
                {
                    times.Add(inputNum[i],0);
                }
                times[inputNum[i]]++;
            }
            foreach (var nums in times)
            {
                Console.WriteLine($"{nums.Key} - {nums.Value} times");
            }
        }
    }
}

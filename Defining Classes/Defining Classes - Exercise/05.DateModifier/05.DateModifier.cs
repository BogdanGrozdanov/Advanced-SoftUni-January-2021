using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int days = DateModifier.GetDiffBetweenTwoDates(first, second);

            Console.WriteLine(Math.Abs(days));
        }
    }
}

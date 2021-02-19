using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];
            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            }
            Analyze(jaggedArray);
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] comandInfo = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = comandInfo[0];
                int row = int.Parse(comandInfo[1]);
                int col = int.Parse(comandInfo[2]);
                int value = int.Parse(comandInfo[3]);

                if (!IsInSide(jaggedArray, row, col))
                {
                    comand = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (action == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                comand = Console.ReadLine();
            }
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }

        private static bool IsInSide(double[][] jaggedArray, int row, int col)
        {
            return row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length;
        }

        private static void Analyze(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }

                }
            }
        }
    }
}

using System;
using System.Linq;

namespace _02SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];


            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            for (int col = 0; col < cols; col++)
            {
                int sumCol = 0;

                for (int row = 0; row < rows; row++)
                {
                    sumCol += matrix[row, col];
                }
                Console.WriteLine(sumCol);

            }

        }
    }
}

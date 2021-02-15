using System;
using System.Linq;

namespace _02._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            CreateMatrix(matrix);
            string firstChar=string.Empty;
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    firstChar = matrix[row, col];
                    if (firstChar == matrix[row, col] && firstChar == matrix[row, col + 1] && firstChar == matrix[row + 1, col] && firstChar == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }

                }
            }
            Console.WriteLine(counter);
        }

        public static string[,] CreateMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ").ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
    }
}

using System;
using System.Linq;

namespace _03PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] rowData = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            int counter = 0;
            int sumDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = counter; col <= counter; col++)
                {
                    sumDiagonal += matrix[row, col];
                }
                counter++;
            }
            Console.WriteLine(sumDiagonal);


        }

        public static void PrimeDiagonal(int matrixSize)
        {

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] rowData = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            int counter = 0;
            int sumDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = counter; col <= counter; col++)
                {
                    sumDiagonal += matrix[row, col];
                }
                counter++;
            }
            Console.WriteLine(sumDiagonal);
        }
    }
}

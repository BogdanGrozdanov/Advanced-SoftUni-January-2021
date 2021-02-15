using System;
using System.Linq;

namespace _04SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (symbol == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}

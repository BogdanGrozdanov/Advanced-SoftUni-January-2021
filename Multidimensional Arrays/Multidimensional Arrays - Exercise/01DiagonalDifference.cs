using System;
using System.Linq;

namespace _01DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            ////creat matrix ********************************************************
            //Sum Primary diagonal **************************************************
            int primarySumDiagonal = 0;
            for (int row = 0; row < size; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];
                    if (row == col)
                    {
                        primarySumDiagonal += matrix[row, col];
                    }
                }
            }
            //Sum secondary diagonal ******************************************
            int secondaryDiagonalSum = 0;
            for (int i = size - 1; i >= 0; i--)
            {
                int row = size - i - 1;
                int col = i;


                secondaryDiagonalSum += matrix[row, col];
            }
            Console.WriteLine($"{Math.Abs(primarySumDiagonal - secondaryDiagonalSum)}");
        }
    }
}

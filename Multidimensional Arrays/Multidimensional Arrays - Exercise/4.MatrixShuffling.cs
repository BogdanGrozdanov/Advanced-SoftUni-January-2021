using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            string[,] matrix = new string[size[0], size[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] matrixData = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixData[col];
                }
            }

            string[] comand = Console.ReadLine().Split();
            while (comand[0] != "END")
            {
                if (comand[0] != "swap" || comand.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    comand = Console.ReadLine().Split();
                    continue;
                }
                bool isValidCoordinatsOne = ValidateCell(matrix, int.Parse(comand[1]), int.Parse(comand[2]));
                bool isValidCoordinatsTwo = ValidateCell(matrix, int.Parse(comand[3]), int.Parse(comand[4]));
                if (!isValidCoordinatsOne || !isValidCoordinatsTwo)
                {
                    Console.WriteLine("Invalid input!");
                    comand = Console.ReadLine().Split();
                    continue;
                }
                string temp = matrix[int.Parse(comand[1]), int.Parse(comand[2])];
                matrix[int.Parse(comand[1]), int.Parse(comand[2])] = matrix[int.Parse(comand[3]), int.Parse(comand[4])];
                matrix[int.Parse(comand[3]), int.Parse(comand[4])] = temp;
                PrintMatrix(matrix);
                comand = Console.ReadLine().Split();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool ValidateCell(string[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}

using System;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            string snake = Console.ReadLine();

            int rows = size[0];
            int cols = size[1];
            int counter = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                counter = CheckMovesSnake(snake, counter, matrix, row);

            }
            PrintMatrix(matrix);
        }

        private static int CheckMovesSnake(string snake, int counter, char[,] matrix, int row)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = snake[counter++];
                    if (counter == snake.Length)
                    {
                        counter = 0;
                    }
                }
            }
            else
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    matrix[row, col] = snake[counter++];
                    if (counter == snake.Length)
                    {
                        counter = 0;
                    }
                }
            }

            return counter;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

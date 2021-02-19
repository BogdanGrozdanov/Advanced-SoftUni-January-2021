using System;
using System.Linq;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[size, size];
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = input[col];
                }
            }
            int knightCounts = 0;
            int killerRow = 0;
            int killerCol = 0;
            while (true)
            {
                int maxAtack = 0;

                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int currentKnightAttacks = 0;
                        if (chessBoard[row, col] == 'K')
                        {
                            if (IsInSide(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInSide(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInSide(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInSide(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInSide(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInSide(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInSide(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInSide(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                        }
                        if (currentKnightAttacks > maxAtack)
                        {
                            maxAtack = currentKnightAttacks;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }
                if (maxAtack > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    knightCounts++;
                }
                else
                {
                    Console.WriteLine(knightCounts);
                    break;
                }
            }
        }

        private static bool IsInSide(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}

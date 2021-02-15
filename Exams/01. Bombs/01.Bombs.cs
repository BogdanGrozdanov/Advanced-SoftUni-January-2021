using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] effectData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] casingData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> casing = new Stack<int>(casingData);
            Queue<int> effect = new Queue<int>(effectData);
            int bombPunch = 0;
            int daturaBombs = 0;
            int cherryBombs = 0;
            int SmokeDecoyBombs = 0;
            while (casing.Count > 0 && effect.Count > 0 && bombPunch < 3)
            {
                int effectValue = effect.Peek();
                int casingValue = casing.Peek();
                int sum = effectValue + casingValue;

                if (sum == 40)
                {
                    effect.Dequeue();
                    casing.Pop();
                    daturaBombs++;
                    if (daturaBombs == 3)
                    {
                        bombPunch++;
                    }
                }
                else if (sum == 60)
                {
                    effect.Dequeue();
                    casing.Pop();
                    cherryBombs++;
                    if (cherryBombs == 3)
                    {
                        bombPunch++;
                    }
                }
                else if (sum == 120)
                {
                    effect.Dequeue();
                    casing.Pop();
                    SmokeDecoyBombs++;
                    if (SmokeDecoyBombs == 3)
                    {
                        bombPunch++;
                    }
                }
                else
                {
                    casing.Pop();
                    casing.Push(casingValue - 5);
                }
            }

            if (bombPunch >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");

            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effect.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.Write($"Bomb Effects: ");

                while (effect.Count > 0)
                {

                    if (effect.Count == 1)
                    {
                        Console.WriteLine($"{effect.Dequeue()}");
                    }
                    else
                    {
                        Console.Write($"{effect.Dequeue()}, ");
                    }
                }
            }

            if (casing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.Write($"Bomb Casings: ");

                while (casing.Count > 0)
                {
                    if (casing.Count == 1)
                    {
                        Console.WriteLine($"{casing.Pop()}");
                    }
                    else
                    {
                        Console.Write($"{casing.Pop()}, ");
                    }
                }
            }
            Console.WriteLine($"Cherry Bombs: {cherryBombs}\nDatura Bombs: {daturaBombs}\nSmoke Decoy Bombs: {SmokeDecoyBombs}");

        }
    }
}

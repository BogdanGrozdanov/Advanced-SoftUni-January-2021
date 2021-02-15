using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasksData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] threadsData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int kill = int.Parse(Console.ReadLine());
            Stack<int> tasks = new Stack<int>(tasksData);
            Queue<int> threads = new Queue<int>(threadsData);

            //threads>= tasks

            while (threads.Count > 0)
            {
                if (tasks.Peek() == kill)
                {
                    Console.WriteLine($"Thread with value {threads.Peek()} killed task {kill}");
                    break;
                }
                else if (tasks.Peek() > threads.Peek())
                {
                    threads.Dequeue();
                }
                else if (tasks.Peek() <= threads.Peek())
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
            }
            while (threads.Count > 0)
            {
                Console.Write(threads.Dequeue() + " ");
            }

        }
    }
}

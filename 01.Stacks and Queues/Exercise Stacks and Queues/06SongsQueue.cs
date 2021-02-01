using System;
using System.Collections.Generic;

namespace _06SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceOfSongs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> allSong = new Queue<string>(sequenceOfSongs);
            string comand = Console.ReadLine();


            while (!comand.Contains("No more songs!"))
            {
                if (comand.Contains("Play"))
                {
                    allSong.Dequeue();
                }
                else if (comand.Contains("Add"))
                {
                    var songAdd = comand.Split("Add ");
                    if (allSong.Contains(songAdd[1]))
                    {
                        Console.WriteLine($"{songAdd[1]} is already contained!");
                    }
                    else
                    {
                        allSong.Enqueue(songAdd[1]);
                    }
                }
                else if (comand.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", allSong));
                }
                comand = Console.ReadLine();
            }
        }
    }
}

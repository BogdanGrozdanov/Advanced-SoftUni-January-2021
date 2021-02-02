using System;
using System.Text;

namespace _09SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numComands = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < numComands; i++)
            {
                string[] comand = Console.ReadLine().Split();

                if (comand[0] == "1")
                {
                    text.Append(comand[1]);
                }
                else if (comand[0] == "2")
                {
                    text.Remove((text.Length - int.Parse(comand[1])), text.Length);
                }
                else if (comand[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(comand[1]) - 1]);
                }
            }

        }
    }
}

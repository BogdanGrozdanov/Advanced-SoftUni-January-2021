using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person first = new Person();
            Person second = new Person(7);
            Person thirth = new Person("Simona",7);
            Console.WriteLine();
        }

    }
}

using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person personOne = new Person()
            {
                Name = "Pesho",
                Age = 20
            };

            Person personTwo = new Person()
            {
                Name = "Gosho",
                Age = 18
            };

            Person personThree = new Person()
            {
                Name = "Stamat",
                Age = 43
            };

        }
    }
}

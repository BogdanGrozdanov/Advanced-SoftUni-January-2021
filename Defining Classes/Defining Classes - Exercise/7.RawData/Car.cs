using System.Collections.Generic;

namespace RawData
{
    public class Car
    {
        public Car()
        {
            
        }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            tires = new List<Tire>();

        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }

    }

}

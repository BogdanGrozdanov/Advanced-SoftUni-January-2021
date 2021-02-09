using System.Collections.Generic;

namespace RawData
{
    public class Tire
    {
        public Tire()
        {
            TirePressure = 0;
            TireAge = 0;
        }
        public Tire(double tirePressure, double tireAge)
        {
            TirePressure = tirePressure;
            TireAge = tireAge;
        }

        public double TirePressure { get; set; }
        public double TireAge { get; set; }
        public List<Tire> Tires = new List<Tire>();


    }
}

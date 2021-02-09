using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        public Engine()
        {
            EngineSpeed = 0;
            EnginePower = 0;
        }
        public  Engine(int egineSpeed, int enginePower)
        {
            EngineSpeed = egineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }

    }
}

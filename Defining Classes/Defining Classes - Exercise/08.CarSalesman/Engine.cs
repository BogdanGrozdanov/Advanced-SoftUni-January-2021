namespace _08.CarSalesman
{
    public class Engine
    {
        public Engine()
        {

        }
        public void AddEngine(string[] paramEngine)
        {
            Engine engine = new Engine();

            if (paramEngine.Length == 2)
            {
                Model = paramEngine[0];
                Power = paramEngine[1];
                Displacement = "n/a";
                Efficiency = "n/a";
            }
            if (paramEngine.Length == 3)
            {
                Model = paramEngine[0];
                Power = paramEngine[1];
                Displacement = paramEngine[2];
                Efficiency = "n/a";
            }
            if (paramEngine.Length == 4)
            {
                Model = paramEngine[0];
                Power = paramEngine[1];
                Displacement = paramEngine[2];
                Efficiency = paramEngine[3];
            }
        }

        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}

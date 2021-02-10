namespace _08.CarSalesman
{
    public class Car
    {
        public Car()
        {

        }
        public void AddCar(string[] paramCar)
        {
            Car car = new Car();
            if (paramCar.Length == 2)
            {
                Model = paramCar[0];
                Engine = paramCar[1];
                Weight = "n/a";
                Color = "n/a";
            }
            if (paramCar.Length == 3)
            {
                Model = paramCar[0];
                Engine = paramCar[1];
                Weight = "n/a";
                Color = paramCar[2];
            }
            if (paramCar.Length == 4)
            {
                Model = paramCar[0];
                Engine = paramCar[1];
                Weight = paramCar[2];
                Color = paramCar[3];
            }

        }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
    }
}

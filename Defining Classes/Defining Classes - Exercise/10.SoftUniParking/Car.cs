namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNnumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNnumber;
        }


        public override string ToString()
        {
            return $"Make: {Make}\nModel: {Model}\nHorsePower: {HorsePower}\nRegistrationNumber: { RegistrationNumber}";
        }


        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }
    }
}

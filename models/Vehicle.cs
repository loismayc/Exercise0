namespace CarFactory
{
    namespace Models
    {
        public class Vehicle
        {
            public string Color { get; set; }
            public string Brand { get; set; }

            public Vehicle(string color, string brand)
            {
                this.Color = color;
                this.Brand = brand;

            }

            public void DisplayVehicle()
            {
                Console.WriteLine("Color: " + this.Color);
                Console.WriteLine("Brand: " + this.Brand);


            }
        }
    }

}
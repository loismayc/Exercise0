namespace CarFactory
{
    namespace Models
    {
        public class Car : Vehicle
        {
            public string Model { get; set; }

            public Car(string color, string brand, string model)
            : base(color, brand)
            {
                this.Model = model;

            }

            public void DisplayVehicle()
            {
                base.DisplayVehicle();
                Console.WriteLine("Model: " + this.Model);
            }
        }

    }
}
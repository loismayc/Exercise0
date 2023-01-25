namespace CarFactory
{
    namespace Models
    {
        public class Truck : Vehicle
        {
            public string Model { get; set; }
            public float Capacity { get; set; }

            public Truck(string color, string brand, string model, float capacity)
            : base(color, brand)
            {
                this.Capacity = capacity;
                this.Model = model;

            }

            public void DisplayVehicle()
            {
                base.DisplayVehicle();
                Console.WriteLine("Model: " + this.Model);
                Console.WriteLine("Capacity: " + this.Capacity);

            }

        }
    }
}
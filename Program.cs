using CarFactory.Models;

namespace CarFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Console.WriteLine("Enter number of vehicles: ");
            int input = int.Parse(Console.ReadLine());

            //Car car = new Car ("Black","Toyota","Car");
            //Truck truck = new Truck ("White","Toyota","Truck", 40.20f);
            int i = 0;

            while (i < input)
            {
                for (i = 0; i < input; i++)
                {
                    Console.WriteLine("\nEnter which type of vehicle (Car/Truck): ");
                    string type = Console.ReadLine().ToLower();
                    if (type == "car")
                    {
                        Console.Write("Enter color: ");
                        string color = Console.ReadLine();

                        Console.Write("Enter brand: ");
                        string brand = Console.ReadLine();

                        Console.Write("Enter model: ");
                        string model = Console.ReadLine();

                        Car car = new Car(color, brand, model);

                        vehicles.Add(car);
                    }
                    else if (type == "truck")
                    {
                        Console.Write("Enter color: ");
                        string color = Console.ReadLine();

                        Console.Write("Enter brand: ");
                        string brand = Console.ReadLine();

                        Console.Write("Enter model: ");
                        string model = Console.ReadLine();

                        Console.Write("Enter capacity: ");
                        float capacity = float.Parse(Console.ReadLine());

                        Truck truck = new Truck(color, brand, model, capacity);

                        vehicles.Add(truck);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }

            }
            Console.WriteLine("\n===================\nList of Vehicles:");


            foreach (Vehicle v in vehicles)
            {
                if (v.GetType() == typeof(Car))
                {
                    // Typecasting 
                    Car temp = (Car)v;

                    Console.WriteLine("\nVehicle is a car:");
                    temp.DisplayVehicle();

                }
                else if (v.GetType() == typeof(Truck))
                {
                    Truck temp = (Truck)v;
                    Console.WriteLine("\nVehicle is a truck:");
                    temp.DisplayVehicle();

                }
            }

        }
    }
}

using CarFactory.Models;

namespace CarFactory
{
    public class Program {
        static void Main(string[] args){
            List<Vehicle> vehicles = new List<Vehicle>();
            Console.WriteLine("Enter number of vehicles: ");
            int input = int.Parse(Console.ReadLine());

            Car car = new Car ("Black","Toyota","Car");
            Truck truck = new Truck ("White","Toyota","Truck", 40.20f);
            int i =0;

                while(i < input){
                    for ( i=0; i < input; i++){
                    Console.WriteLine("\nEnter which type of vehicle (Car/Truck): ");
                    string type = Console.ReadLine().ToLower();
                    if (type == "car"){
                       /* Console.WriteLine("Enter color");
                        string color = Console.ReadLine();

                        Console.WriteLine("Enter brand");
                        string brand = Console.ReadLine();

                        Console.WriteLine("Enter model");
                        string model = Console.ReadLine();

                        Car car = new Car (color, brand, model);*/
                   
                        vehicles.Add(car);
                    } else if (type == "truck"){
                        vehicles.Add(truck);
                    } else {
                        Console.WriteLine("Invalid input. Please try again.");
                    }  
                }
               
            }
            Console.WriteLine("\n===================\nList of Vehicles:\n");


            foreach (Vehicle v in vehicles){
                if (v.GetType() == typeof(Car))
                {
                    // Typecasting 
                    Car temp = (Car)v;
                    Console.WriteLine("Vehicle is a Car");
                }
                else if (v.GetType() == typeof(Truck))
                {
                    Truck temp = (Truck)v;
                    Console.WriteLine("Vehicle is a Truck");
                }
            }
                                    
        }
    }
}

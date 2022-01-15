using System;
namespace WindowsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Engine = Engines.Cylinder_4,
                Make = "BMW",
                Year = 2021,
                Model = "X3"
            };

            Car car2 = new Car()
            {
                Engine = Engines.Cylinder_4,
                Make = "Toyota",
                Year = 2020,
                Model = "Corola"
            }

            Program.Display(car);
            Program.Display(car2);
        }

        public static void Display(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.Make);
            Console.WriteLine(vehicle.Model);
            Console.WriteLine(vehicle.Year);
        }

        public static void Display2(Truck truck)
        {

        }
    }
}

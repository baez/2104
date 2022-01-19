using System;
using System.Collections.Generic;
using Assignment2.Entities;
using Assignment2.Interfaces;
using Assignment2.Enums;
namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck1 = new Truck("L234H79JG8", 5, 1999, 422223, TruckMake.chevrolet, "Boulder", TruckBodyStyle.flatbed);
            Car car1 = new Car("0JHlH8986G", 6, 2011, 4238, CarMake.toyota, "Corola", CarBodyStyle.convertible);
            Motorcycle motor1 = new Motorcycle("2234K34H2H", 2, 2019, 234242, MotorcycleMake.vespa, "Bruno", MotorcycleBodyStyle.moped);


            List<IVehicle> listOfVehicles = new List<IVehicle>();
            listOfVehicles.Add(truck1);
            listOfVehicles.Add(car1);
            listOfVehicles.Add(motor1);

            /*  Console.WriteLine(truck1);
              Console.WriteLine(car1);
              Console.WriteLine(motor1);*/

            foreach (IVehicle vehicle in listOfVehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}

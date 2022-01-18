using System;

namespace Assignment2.Entities
{
    public class Vehicle
    {

        public int Capacity { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string VIN { get; set; }
        public string VehicleType { get; set; }
        public Vehicle() { }
        public Vehicle(string vin, int capacity, int year, decimal price, string vehicleType)
        {
            this.VIN = vin;
            this.Capacity = capacity;
            this.Year = year;
            this.Price = price;
            this.VehicleType = vehicleType;
        }
    }
}

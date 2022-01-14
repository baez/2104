using System;

namespace Assignment1.Entities
{
    public class Vehicle
    {

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Year { get; set; }
        /*        public int Mileage { get; set; }*/
        public decimal Price { get; set; }

        public Vehicle() { }
        public Vehicle(string name, int capacity, int year, decimal price)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Year = year;
            this.Price = price;
        }
    }
}

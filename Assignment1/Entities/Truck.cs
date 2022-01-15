using System;
using System.Collections.Generic;
using System.Text;
using Assignment1.Enums;

namespace Assignment1.Entities
{
    class Truck: Vehicle
    {
        public TruckMake Make { get; set; }
        public string Model { get; set; }
        public TruckBodyStyle BodyStyle { get; set; }

        public Truck() { }
        public Truck (string name, int capacity, int year, decimal price,  string vin, TruckMake make, string model, TruckBodyStyle bodyStyle) : base(name, capacity, year, price, vin)
        {
            this.Make = make;
            this.Model = model;
            this.BodyStyle = bodyStyle;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Assignment1.Enums;

namespace Assignment1.Entities
{
    class Motorcycle: Vehicle
    {
        public MotorcycleMake Make { get; set; }
        public string Model { get; set; }
        public MotorcycleBodyStyle BodyStyle { get; set; }

        public Motorcycle() { }

        public Motorcycle(string name, int capacity, int year, decimal price, string vin, MotorcycleMake make, string model, MotorcycleBodyStyle bodyStyle) : base(name, capacity, year, price, vin)
        {
            this.Make = make;
            this.Model = model;
            this.BodyStyle = bodyStyle;
        }


    }
}

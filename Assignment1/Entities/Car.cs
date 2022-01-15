using System;
using System.Collections.Generic;
using System.Text;
using Assignment1.Enums;
namespace Assignment1.Entities
{
    class Car: Vehicle
    {
        public CarMake Make { get; set; }
        public string Model { get; set; }
        public CarBodyStyle BodyStyle { get; set; } 

        public Car() { }

        public Car (string name, int capacity, int year, decimal price, CarMake make, string model, CarBodyStyle bodyStyle) : base(name, capacity, year, price)
        {
            this.Make = make;
            this.Model = model;
            this.BodyStyle = bodyStyle;
        }


    }
}

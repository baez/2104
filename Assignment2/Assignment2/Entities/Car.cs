using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Enums;
using System.Reflection;
using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    class Car: Vehicle, IVehicle
    {
        public CarMake Make { get; set; }
        public string Model { get; set; }
        public CarBodyStyle BodyStyle { get; set; }

        public Car() { }
        public override string ToString()
        {
            Type Car = typeof(Car);
            PropertyInfo[] propertyInfo = Car.GetProperties();

            StringBuilder manifest = new StringBuilder();

            foreach (PropertyInfo property in propertyInfo)
            {
/*                manifest.Append(property.Name + ": " + property.GetValue(this) + "\n");
                */
                manifest.Append(property.Name + ": " + property.GetValue(this) + " || ");
            }

            return manifest.ToString();
        }
        public Car(string vin, int capacity, int year, decimal price, CarMake make, string model, CarBodyStyle bodyStyle,string vehicleType = "Car") : base(vin, capacity, year, price, vehicleType)
        {
            this.Make = make;
            this.Model = model;
            this.BodyStyle = bodyStyle;
        }


    }
}

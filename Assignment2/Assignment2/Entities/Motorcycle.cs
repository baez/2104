using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Enums;
using System.Reflection;
using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    class Motorcycle: Vehicle, IVehicle
    {
        public MotorcycleMake Make { get; set; }
        public string Model { get; set; }
        public MotorcycleBodyStyle BodyStyle { get; set; }

        public override string ToString()
        {
            Type Motorcycle = typeof(Motorcycle);
            PropertyInfo[] propertyInfo = Motorcycle.GetProperties();

            StringBuilder manifest = new StringBuilder();

            foreach (PropertyInfo property in propertyInfo)
            {
/*                manifest.Append(property.Name + ": " + property.GetValue(this) + "\n");
*/                manifest.Append(property.Name + ": " + property.GetValue(this) + " || ");
            }

            return manifest.ToString();
        }
        public Motorcycle() { }

        public Motorcycle(string vin, int capacity, int year, decimal price, MotorcycleMake make, string model, MotorcycleBodyStyle bodyStyle, string vehicleType = "Motorcylce") : base(vin, capacity, year, price, vehicleType)
        {
            this.Make = make;
            this.Model = model;
            this.BodyStyle = bodyStyle;
        }


    }
}

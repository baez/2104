using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Assignment2.Interfaces;
using Assignment2.Enums;

namespace Assignment2.Entities
{
    class Truck: Vehicle, IVehicle
    {
        public TruckMake Make { get; set; }
        public string Model { get; set; }
        public TruckBodyStyle BodyStyle { get; set; }


        public override string ToString()
        {
            Type Truck = typeof(Truck);
            PropertyInfo[] propertyInfo = Truck.GetProperties();

            StringBuilder manifest = new StringBuilder();

            foreach (PropertyInfo property in propertyInfo)
            {
/*                manifest.Append(property.Name + ": " + property.GetValue(this) + "\n");
                */
                manifest.Append(property.Name + ": " + property.GetValue(this) + " || ");
            }

            return manifest.ToString();
        }
        public Truck() { }
        public Truck (string vin, int capacity, int year, decimal price, TruckMake make, string model, TruckBodyStyle bodyStyle, string vehicleType = "Truck") : base(vin, capacity, year, price, vehicleType )
        {
            this.Make = make;
            this.Model = model;
            this.BodyStyle = bodyStyle;
            this.VehicleType = vehicleType;
        }
    }
}

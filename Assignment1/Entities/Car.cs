using System;
using System.Collections.Generic;
using System.Text;
using Assignment1.Enums;
namespace Assignment1.Entities
{
    class Car: Vehicle
    {
        public CarMake Make { get; set; } //make enum
        public string Model { get; set; }
        public CarBodyStyle BodyStyle { get; set; } //make enum 
    }
}

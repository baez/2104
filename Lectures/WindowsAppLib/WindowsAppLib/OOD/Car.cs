﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAppLib.OOD
{
    public class Car
    {
        public string Model;
        public string Make;
        public int Year;
        public string Trim;
        public string BodyType;
        public Engines Engine;

        public decimal Kilometers;
        public decimal Price;

        public Car()
        {
            Engine = Engines.Cylinder_4;
        }
    }
}
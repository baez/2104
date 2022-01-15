using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAppLib.OOD
{
    public class Vehicle
    {
        public string Model;
        public string Make;
        public int Year;
        public Engines Engine;

        public virtual int GetMaxSpeed()
        {
            return 0;
        }
    }
}

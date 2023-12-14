using System;
using System.Collections.Generic;
using System.Text;

namespace F1MobileApp
{
    public class DriversAndQualifyingPosition
    {
        public string name { get; set; }

        public string[] races = new string[23];

        public DriversAndQualifyingPosition(string name, string[] races)
        {
            this.name = name;
            this.races = races;
        }
    }
}

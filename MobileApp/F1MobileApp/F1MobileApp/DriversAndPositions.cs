using System;
using System.Collections.Generic;
using System.Text;

namespace F1MobileApp
{
    public class DriversAndPositions
    {
        public string name { get; set; }

        public string[] races = new string[23];

        public string[] sprintraces = new string[23];

        public string[] fastestlap { get; set; }

        public DriversAndPositions(string name, string[] races,string[] sprintraces, string[] fastestlap)
        {
            this.name = name;
            this.races = races;
            this.sprintraces = sprintraces;
            this.fastestlap = fastestlap;
        }
    }
}

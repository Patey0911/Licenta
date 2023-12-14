using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediction
{
    internal class DriverModel
    {
        public string AccumulatedPos { get; set; }
        public string AccumulatedPosSprint { get; set; }
        public string Country { get; set; }
        public string DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string GrandPrixEntered { get; set; }
        public string HighestGridPosition { get; set; }
        public string HighestRaceFinish { get; set; }
        public string LastName { get; set; }
        public string No { get; set; }
        public string NoApp { get; set; }
        public string NoAppSprint { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Podiums { get; set; }
        public string Points { get; set; }
        public string PointsSeason { get; set; }
        public string Position { get; set; }
        public string Team { get; set; }
        public string WorldChampionships { get; set; }

        public string Race1 { get; set; }
        public string Race2 { get; set; }
        public string Race3 { get; set; }
        public string Race4 { get; set; }
        public string Race5 { get; set; }
        public float AvgPlace5Races { get; set;}

        public float AvgPlace { get; set;}
    }
}

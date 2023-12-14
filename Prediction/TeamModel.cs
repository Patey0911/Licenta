using System;
using System.Collections.Generic;
using System.Text;

namespace Prediction
{
    public class TeamModel
    {
        public string Driver1 { get; set; }
        public string Driver2 { get; set; }
        public string Points { get; set; }

        public string Team { get; set; }

        public TeamModel() { }
        
        public TeamModel(string driver1, string driver2, string points, string team)
        {
            Driver1 = driver1;
            Driver2 = driver2;
            Points = points;
            Team = team;
        }
    }
}

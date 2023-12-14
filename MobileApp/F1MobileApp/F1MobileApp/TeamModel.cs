using System;
using System.Collections.Generic;
using System.Text;

namespace F1MobileApp
{
    public class TeamModel
    {
        public string Base {  get; set; }
        public string Chassis {  get; set; }
        public string Driver1 { get; set; }
        public string Driver2 { get; set; }
        public string FastestLaps { get; set; }
        public string FirstTeamEntry { get; set; }
        public string HighestRaceFinish { get; set; }
        public string Points { get; set; }
        public string PolePositions { get; set; }
        public string PowerUnit { get; set; }
        public string Team { get; set; }
        public string TeamChief { get; set; }
        public string TechnicalChief { get; set; }
        public string WorldChampionships { get; set; }

        public TeamModel() { }
        
        public TeamModel(string baseteam, string chassis, string driver1, string driver2, string fastestslaps, string firstteamentry, string highestracefinish, string points, string polepositions, string powerunit, string team, string teamchief, string technicalchief, string worldchampionships)
        {
            Base = baseteam;
            Chassis = chassis;
            Driver1 = driver1;
            Driver2 = driver2;
            FastestLaps = fastestslaps;
            FirstTeamEntry = firstteamentry;
            HighestRaceFinish = highestracefinish;
            Points = points;
            PolePositions = polepositions;
            PowerUnit = powerunit;
            Team = team;
            TeamChief = teamchief;
            TechnicalChief = technicalchief;
            WorldChampionships = worldchampionships;
        }
    }
}

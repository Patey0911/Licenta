using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1MobileApp
{
    internal class TeamRepository
    {
        static FirebaseClient firebaseClient = new FirebaseClient("https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/");
        public static async Task<List<TeamModel>> GetAllTeams()
        {
            var teamslist = (await firebaseClient
            .Child("Teams")
            .OnceAsync<TeamModel>()).Select(item =>
            new TeamModel
            {
                Base = item.Object.Base,
                Chassis = item.Object.Chassis,
                Driver1 = item.Object.Driver1,
                Driver2 = item.Object.Driver2,
                FastestLaps = item.Object.FastestLaps,
                FirstTeamEntry = item.Object.FirstTeamEntry,
                HighestRaceFinish = item.Object.HighestRaceFinish,
                Points = item.Object.Points,
                PolePositions = item.Object.PolePositions,
                PowerUnit = item.Object.PowerUnit,
                Team = item.Object.Team,
                TeamChief = item.Object.TeamChief,
                TechnicalChief = item.Object.TechnicalChief,
                WorldChampionships = item.Object.WorldChampionships
            }).ToList();
            return teamslist;
        }

        public static async Task<TeamModel> GetByTeam(string TeamName)
        {
            try
            {
                var allTeams = await GetAllTeams();
                await firebaseClient
                .Child("Teams")
                .OnceAsync<TeamModel>();
                return allTeams.Where(a => a.Team == TeamName).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }

        public static async Task<List<TeamModel>> GetByTeamName(string team)
        {
            var Team = (await firebaseClient
            .Child("Teams")
            .OrderByKey()
            .EqualTo(team)
            .OnceAsync<TeamModel>())
            .Select(item =>
            new TeamModel
            {
                Driver1 = item.Object.Driver1,
                Driver2 = item.Object.Driver2,
                Points = item.Object.Points,
                Team = item.Object.Team
            }).ToList();
            return Team;
        }
    }
}

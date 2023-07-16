using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
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
                Driver1 = item.Object.Driver1,
                Driver2 = item.Object.Driver2,
                Points = item.Object.Points,
                Team = item.Object.Team
            }).ToList();
            return teamslist;
        }

        public static async Task<List<TeamModel>> GetByTeam(string team)
        {
            var Team = (await firebaseClient
            .Child("Teams")
            .OrderByKey()
            .EqualTo(team)
            .OnceAsync<TeamModel>())
            .Select(item =>
            new TeamModel
            { 
            Driver1= item.Object.Driver1,
            Driver2= item.Object.Driver2,
            Points = item.Object.Points,
            Team = item.Object.Team
            }).ToList();
        return Team;
        }
    }
}

using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediction
{
    internal class DriverRepository
    {
        static FirebaseClient firebaseClient = new FirebaseClient("https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/");

        public static async Task<List<DriverModel>> GetAllDrivers()
        {
            var driverslist = (await firebaseClient
            .Child("Drivers")
            .OnceAsync<DriverModel>()).Select(item =>
            new DriverModel
            {
                AccumulatedPos = item.Object.AccumulatedPos,
                AccumulatedPosSprint = item.Object.AccumulatedPosSprint,
                Country = item.Object.Country,
                DateOfBirth = item.Object.DateOfBirth,
                FirstName = item.Object.FirstName,
                GrandPrixEntered = item.Object.GrandPrixEntered,
                HighestGridPosition = item.Object.HighestGridPosition,
                HighestRaceFinish = item.Object.HighestRaceFinish,
                LastName = item.Object.LastName,
                No = item.Object.No,
                NoApp = item.Object.NoApp,
                NoAppSprint = item.Object.NoAppSprint,
                PlaceOfBirth = item.Object.PlaceOfBirth,
                Podiums = item.Object.Podiums,
                Points = item.Object.Points,
                PointsSeason = item.Object.PointsSeason,
                Position = item.Object.Position,
                Team = item.Object.Team,
                WorldChampionships = item.Object.WorldChampionships,
                Race1 = "0",
                Race2 = "0",
                Race3 = "0",
                Race4 = "0",
                Race5 = "0",
                AvgPlace5Races = 0
            }).ToList();
            return driverslist;
        }

        public static async Task<DriverModel> GetByNo(string No)
        {
            try
            {
                var allDrivers = await GetAllDrivers();
                await firebaseClient
                .Child("Drivers")
                .OnceAsync<DriverModel>();
                return allDrivers.Where(a => a.No == No).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }

        public static float AvgPosLast5Races(DriverModel a)
        {
            float pos;

            pos = int.Parse(a.Race1) + int.Parse(a.Race2) + int.Parse(a.Race3) + int.Parse(a.Race4) + int.Parse(a.Race5);

            pos = pos / 2;

            return pos;
        }
    }
}


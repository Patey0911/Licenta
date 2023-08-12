using Firebase.Database;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1MobileApp
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
                Country = item.Object.Country,
                DateOfBirth = item.Object.DateOfBirth,
                FirstName = item.Object.FirstName,
                GrandPrixEntered = item.Object.GrandPrixEntered,
                HighestGridPosition = item.Object.HighestGridPosition,
                HighestRaceFinish = item.Object.HighestRaceFinish,
                LastName = item.Object.LastName,
                PlaceOfBirth = item.Object.PlaceOfBirth,
                Podiums = item.Object.Podiums,
                Points = item.Object.Points,
                Team = item.Object.Team,
                WorldChampionships = item.Object.WorldChampionships
            }).ToList();
            return driverslist;
        }

        public static async Task<DriverModel> GetByName(string name)
        {
            try
            {
                var allDrivers = await GetAllDrivers();
                await firebaseClient
                .Child("Drivers")
                .OnceAsync<DriverModel>();
                return allDrivers.Where(a => a.LastName == name).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }
    }
}

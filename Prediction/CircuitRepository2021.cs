using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediction
{
    internal class CircuitRepository2021
    {
        static FirebaseClient firebaseClient = new FirebaseClient("https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/");

        public static async Task<List<CircuitModel>> GetAllCircuits()
        {
            var circuitslist = (await firebaseClient
            .Child("Circuits")
            .Child("2021")
            .OnceAsync<CircuitModel>()).Select(item =>
            new CircuitModel
            {
                CircuitLength = item.Object.CircuitLength,
                CircuitName = item.Object.CircuitName,
                Date = item.Object.Date,
                FirstGP = item.Object.FirstGP,
                FutureRace = item.Object.FutureRace,
                LapRecord = item.Object.LapRecord,
                NoLaps = item.Object.NoLaps,
                Place1 = item.Object.Place1,
                Place2 = item.Object.Place2,
                Place3 = item.Object.Place3,
                Place4 = item.Object.Place4,
                Place5 = item.Object.Place5,
                Place6 = item.Object.Place6,
                Place7 = item.Object.Place7,
                Place8 = item.Object.Place8,
                Place9 = item.Object.Place9,
                Place10 = item.Object.Place10,
                Place11 = item.Object.Place11,
                Place12 = item.Object.Place12,
                Place13 = item.Object.Place13,
                Place14 = item.Object.Place14,
                Place15 = item.Object.Place15,
                Place16 = item.Object.Place16,
                Place17 = item.Object.Place17,
                Place18 = item.Object.Place18,
                Place19 = item.Object.Place19,
                Place20 = item.Object.Place20,
                RaceDistance = item.Object.RaceDistance,
                Sprint1 = item.Object.Sprint1,
                Sprint2 = item.Object.Sprint2,
                Sprint3 = item.Object.Sprint3,
                Sprint4 = item.Object.Sprint4,
                Sprint5 = item.Object.Sprint5,
                Sprint6 = item.Object.Sprint6,
                Sprint7 = item.Object.Sprint7,
                Sprint8 = item.Object.Sprint8,
                Sprint9 = item.Object.Sprint9,
                Sprint10 = item.Object.Sprint10,
                Sprint11 = item.Object.Sprint11,
                Sprint12 = item.Object.Sprint12,
                Sprint13 = item.Object.Sprint13,
                Sprint14 = item.Object.Sprint14,
                Sprint15 = item.Object.Sprint15,
                Sprint16 = item.Object.Sprint16,
                Sprint17 = item.Object.Sprint17,
                Sprint18 = item.Object.Sprint18,
                Sprint19 = item.Object.Sprint19,
                Sprint20 = item.Object.Sprint20,
                SprintRace = item.Object.SprintRace
            }).ToList();
            return circuitslist;
        }

        public static async Task<CircuitModel> GetByName(string name)
        {
            try
            {
                var circuit = await GetAllCircuits();
                await firebaseClient
                .Child("Circuit")
                .OnceAsync<CircuitModel>();
                return circuit.Where(a => a.CircuitName == name).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }
    }
}

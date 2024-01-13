using Firebase.Database;
using Firebase.Database.Query;
using FirebaseAdmin.Auth;
using Java.IO;
using Java.Util.Functions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace F1MobileApp
{
    internal class CircuitRepository
    {
        static FirebaseClient firebaseClient = new FirebaseClient("https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/");

        public static async Task<List<CircuitModel>> GetAllCircuits()
        {
            var circuitslist = (await firebaseClient
            .Child("Circuits")
            .Child("2023")
            .OnceAsync<CircuitModel>()).Select(item =>
            new CircuitModel
            {
                CircuitLength = item.Object.CircuitLength,
                CircuitName = item.Object.CircuitName,
                Date = item.Object.Date,
                FastestLap = item.Object.FastestLap,
                FirstGP=item.Object.FirstGP,
                FutureRace = item.Object.FutureRace,
                LapRecord=item.Object.LapRecord,
                NoLaps=item.Object.NoLaps,
                Place1=item.Object.Place1,
                Place2=item.Object.Place2,
                Place3=item.Object.Place3,
                Place4=item.Object.Place4,
                Place5=item.Object.Place5,
                Place6=item.Object.Place6,
                Place7=item.Object.Place7,
                Place8=item.Object.Place8,
                Place9=item.Object.Place9,
                Place10=item.Object.Place10,
                Place11=item.Object.Place11,
                Place12=item.Object.Place12,
                Place13=item.Object.Place13,
                Place14=item.Object.Place14,
                Place15=item.Object.Place15,
                Place16=item.Object.Place16,
                Place17=item.Object.Place17,
                Place18=item.Object.Place18,
                Place19=item.Object.Place19,
                Place20=item.Object.Place20,
                Qualifying1 = item.Object.Qualifying1,
                Qualifying2 = item.Object.Qualifying2,
                Qualifying3 = item.Object.Qualifying3,
                Qualifying4 = item.Object.Qualifying4,
                Qualifying5 = item.Object.Qualifying5,
                Qualifying6 = item.Object.Qualifying6,
                Qualifying7 = item.Object.Qualifying7,
                Qualifying8 = item.Object.Qualifying8,
                Qualifying9 = item.Object.Qualifying9,
                Qualifying10 = item.Object.Qualifying10,
                Qualifying11 = item.Object.Qualifying11,
                Qualifying12 = item.Object.Qualifying12,
                Qualifying13 = item.Object.Qualifying13,
                Qualifying14 = item.Object.Qualifying14,
                Qualifying15 = item.Object.Qualifying15,
                Qualifying16 = item.Object.Qualifying16,
                Qualifying17 = item.Object.Qualifying17,
                Qualifying18 = item.Object.Qualifying18,
                Qualifying19 = item.Object.Qualifying19,
                Qualifying20 = item.Object.Qualifying20,
                RaceDistance = item.Object.RaceDistance,
                Sprint1 =item.Object.Sprint1,
                Sprint2=item.Object.Sprint2,
                Sprint3=item.Object.Sprint3,
                Sprint4=item.Object.Sprint4,
                Sprint5=item.Object.Sprint5,
                Sprint6=item.Object.Sprint6,
                Sprint7=item.Object.Sprint7,
                Sprint8=item.Object.Sprint8,
                Sprint9=item.Object.Sprint9,
                Sprint10=item.Object.Sprint10,
                Sprint11=item.Object.Sprint11,
                Sprint12=item.Object.Sprint12,
                Sprint13=item.Object.Sprint13,
                Sprint14=item.Object.Sprint14,
                Sprint15=item.Object.Sprint15,
                Sprint16=item.Object.Sprint16,
                Sprint17=item.Object.Sprint17,
                Sprint18=item.Object.Sprint18,
                Sprint19=item.Object.Sprint19,
                Sprint20=item.Object.Sprint20,
                SprintQualifying1 = item.Object.SprintQualifying1,
                SprintQualifying2 = item.Object.SprintQualifying2,
                SprintQualifying3 = item.Object.SprintQualifying3,
                SprintQualifying4 = item.Object.SprintQualifying4,
                SprintQualifying5 = item.Object.SprintQualifying5,
                SprintQualifying6 = item.Object.SprintQualifying6,
                SprintQualifying7 = item.Object.SprintQualifying7,
                SprintQualifying8 = item.Object.SprintQualifying8,
                SprintQualifying9 = item.Object.SprintQualifying9,
                SprintQualifying10 = item.Object.SprintQualifying10,
                SprintQualifying11 = item.Object.SprintQualifying11,
                SprintQualifying12 = item.Object.SprintQualifying12,
                SprintQualifying13 = item.Object.SprintQualifying13,
                SprintQualifying14 = item.Object.SprintQualifying14,
                SprintQualifying15 = item.Object.SprintQualifying15,
                SprintQualifying16 = item.Object.SprintQualifying16,
                SprintQualifying17 = item.Object.SprintQualifying17,
                SprintQualifying18 = item.Object.SprintQualifying18,
                SprintQualifying19 = item.Object.SprintQualifying19,
                SprintQualifying20 = item.Object.SprintQualifying20,
                SprintRace = item.Object.SprintRace
            }).ToList();
            return circuitslist;
        }

        public static async Task<CircuitModel> GetByName(string name)
        {
            try
            {
                var allDrivers = await GetAllCircuits();
                await firebaseClient
                .Child("Circuits")
                .Child("2024")
                .OnceAsync<CircuitModel>();
                return allDrivers.Where(a => a.CircuitName == name).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }

        }
    }
}

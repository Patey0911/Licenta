using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace F1MobileApp
{
    internal class UserRepository
    {
        static FirebaseClient firebaseClient = new FirebaseClient("https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/");

        public static async Task Save(UserModel user, int User_Number)
        {
           await firebaseClient.Child("Users/User"+User_Number).PutAsync(user);
        }

        public static async Task<List<UserModel>> GetAllUsers()
        {
            var userlist = (await firebaseClient
            .Child("Users")
            .OnceAsync<UserModel>()).Select(item =>
            new UserModel
            {
                Email = item.Object.Email,
                FavoriteTeam = item.Object.FavoriteTeam,
                FavoriteDriver = item.Object.FavoriteDriver,
                Name = item.Object.Name,
                Password = item.Object.Password
            }).ToList();
            return userlist;
        }

        public static async Task<UserModel> GetByEmail(string email)
        {
            try
            {
                var allUsers = await GetAllUsers();
                await firebaseClient
                .Child("Users")
                .OnceAsync<UserModel>();
                return allUsers.Where(a => a.Email == email).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }
    }
}

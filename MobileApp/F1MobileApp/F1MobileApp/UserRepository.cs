using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1MobileApp
{
    internal class UserRepository
    {
        static FirebaseClient firebaseClient = new FirebaseClient("https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/");

        public static async Task AddUser(string Name, string Email, string Password, string FavoriteDriver)
        {
            /*var toUpdateStatus = (await firebaseClient
              .Child("Users")
              .OnceAsync<UserModel>()).Where(a => a.Object.Name == Name).FirstOrDefault();*/

            var toAdd = new UserModel(Name, Email, Password,FavoriteDriver);

            await firebaseClient
              .Child("Users")
              .PutAsync(toAdd.Email);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Prediction
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FavoriteTeam { get; set; }
        public string FavoriteDriver { get; set; }

        public UserModel() { }
        public UserModel(string name, string email, string password, string favoriteDriver, string favoriteTeam)
        {
            Name = name;
            Email = email;
            Password = password;
            FavoriteDriver = favoriteDriver;
            FavoriteTeam = favoriteTeam;
        }
    }
}

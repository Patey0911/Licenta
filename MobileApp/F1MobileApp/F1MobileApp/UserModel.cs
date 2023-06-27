using System;
using System.Collections.Generic;
using System.Text;

namespace F1MobileApp
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FavoriteDriver { get; set; }

        public UserModel(string name, string email, string password, string favoriteDriver)
        {
            Name = name;
            Email = email;
            Password = password;
            FavoriteDriver = favoriteDriver;
        }   
    }
}

using Firebase.Auth.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace F1MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class RegisterPage : ContentPage
    {
        public static string Name, FavoriteDriver, Email, Password;
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (txtPassword.IsPassword)
            {
                password_icon.Source = "ShowPassword.png";
                txtPassword.IsPassword = false;
            }
            else
            {
                password_icon.Source = "HidePassword.png";
                txtPassword.IsPassword = true;
            }
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            if (txtPassword_Confirm.IsPassword)
            {
                password_icon2.Source = "ShowPassword.png";
                txtPassword_Confirm.IsPassword = false;
            }
            else
            {
                password_icon2.Source = "HidePassword.png";
                txtPassword_Confirm.IsPassword = true;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Get the input from the register form completed by the user
            Name = txtName.Text;
            Password = AESRepository.EncryptAesManaged(txtPassword.Text);   
            Email = txtEmail.Text;
            FavoriteDriver=txtDriver.Text;

            var user_list = await UserRepository.GetAllUsers();

            var user = new UserModel(Name, Email, Password, FavoriteDriver);
            //await UserRepository.Save(user);
            //Verify if the passwords match
            if (txtPassword.Text==txtPassword_Confirm.Text)
            {
                //Verify if the email is available
                if(await EmailVerification(Email))
                {
                    //Verify if the email is in a correct form
                    if (await EmailValidation(Email))
                    {
                        //Save the new user in Firebase

                        await UserRepository.Save(user, user_list.Count+1);
                        await DisplayAlert("Succes", "The user has been added", "OK");
                        await Navigation.PopAsync();
                    }
                    else
                    {
                        await DisplayAlert("Warning!", "The email is not correct", "OK");
                    }
                }
                else
                {
                    await DisplayAlert("Warning!", "The email is already used", "OK");
                }
            }
            else
            {
                await DisplayAlert("Warning!", "Password doesn't match", "OK");
            }
        }

        public async Task<bool> EmailValidation(String Email)
        {
            var emailPattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";

            if (!String.IsNullOrWhiteSpace(Email) && !(Regex.IsMatch(Email, emailPattern)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async Task<bool> EmailVerification(String email)
        {
            //Get all the users and then check that the email is not already used
            var user_list = await UserRepository.GetAllUsers();

            foreach(var user in user_list)
            {
                if(user.Email == email)
                {
                    return false;
                }
            }
            return true;
        }

        private void txtEmail_Completed(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private async void txtDriver_Focused(object sender, FocusEventArgs e)
        {
            //Get all drivers from firebase to show for registration
            var drivers_list = await DriverRepository.GetAllDrivers();
            String[] drivers_names = new string[20];

            int poz = 0;
            foreach(var driver in drivers_list)
            {
                drivers_names[poz] = driver.LastName;
                poz++;
            }

            string action = await DisplayActionSheet("List of the Drivers", "Cancel", null, drivers_names);
            txtDriver.Text = action;
            txtPassword.Focus();
        }

        private void txtName_Completed(object sender, EventArgs e)
        {
            txtDriver.Focus();
        }

        private void txtDriver_Completed(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_Completed(object sender, EventArgs e)
        {
            txtPassword_Confirm.Focus();
        }
    }
}
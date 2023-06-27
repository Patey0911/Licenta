using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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
            Name = txtName.Text;
            Password = txtPassword.Text;   
            Email = txtEmail.Text;
            FavoriteDriver=txtDriver.Text;

            await UserRepository.AddUser(Name, Email, Password, FavoriteDriver);
        }

        private void txtEmail_Completed(object sender, EventArgs e)
        {
            txtName.Focus();
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F1MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void txtUsername_Completed(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if(txtPassword.IsPassword)
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

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}

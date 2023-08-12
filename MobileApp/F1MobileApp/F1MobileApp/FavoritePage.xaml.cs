using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace F1MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FavoritePage : ContentPage
	{
		public FavoritePage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
			//Get favorite team and driver
			var FavDriver = await DriverRepository.GetByName(LoginPage.user.FavoriteDriver);
            var FavTeam = await TeamRepository.GetByTeam(LoginPage.user.FavoriteTeam);

            //Customize the page
            await ChangeBackroundColor(FavTeam);
        }

		private async Task ChangeBackroundColor(TeamModel FavTeam)
		{
            switch (FavTeam.Team)
            {
                case "Alfa Romeo":
                    this.BackgroundColor = Color.FromHex("#C92D4B");
                    break;
                case "AlphaTauri":
                    this.BackgroundColor = Color.FromHex("#5E8FAA");
                    break;
                case "Alpine":
                    this.BackgroundColor = Color.FromHex("#2293D1");
                    break;
                case "Aston Martin":
                    this.BackgroundColor = Color.FromHex("#358C75");
                    break;
                case "Ferrari":
                    this.BackgroundColor = Color.FromHex("#F91536");
                    break;
                case "Haas F1 Team":
                    this.BackgroundColor = Color.FromHex("#B6BABD");
                    break;
                case "McLaren":
                    this.BackgroundColor = Color.FromHex("#F58020");
                    break;
                case "Mercedes":
                    this.BackgroundColor = Color.FromHex("#6CD3BF");
                    break;
                case "Red Bull Racing":
                    this.BackgroundColor = Color.FromHex("#3671C6");
                    break;
                case "Williams":
                    this.BackgroundColor = Color.FromHex("#37BEDD");
                    break;
            }
        }
		
    }
}
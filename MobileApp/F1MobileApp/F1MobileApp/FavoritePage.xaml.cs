using Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Firebase.Auth;
using static Java.Util.Jar.Attributes;
using static Android.Renderscripts.Sampler;
using System.Runtime.ConstrainedExecution;
using System.Globalization;
using System.Text.RegularExpressions;

namespace F1MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FavoritePage : ContentPage
	{
        string NextRaceSend;
        public static DriverModel FavDriver;
        public static TeamModel FavTeam;

        public FavoritePage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
			//Get favorite team and driver
			FavDriver = await DriverRepository.GetByName(LoginPage.user.FavoriteDriver);
            FavTeam = await TeamRepository.GetByTeam(LoginPage.user.FavoriteTeam);

            //Customize the page
            //await ChangeBackroundColor(FavTeam);
            this.BackgroundColor = Color.FromHex("#FFFFFF");

            //Show data for favourite team and drivers
            Label11.Text = FavTeam.Driver1;
            Label12.Text = FavTeam.Driver2;

            if(FavTeam.Driver1==FavDriver.LastName)
                Label11.FontAttributes = FontAttributes.Bold;
            else
                Label12.FontAttributes = FontAttributes.Bold;

            Image1.Source = FavTeam.Driver1.Replace(" ","")+".png";
            Image2.Source = FavTeam.Team.Replace(" ", "") + ".png";
            Image3.Source = FavTeam.Driver2.Replace(" ", "") + ".png";

            //int points1 = await Calculate.CalculatePointsForOneDriverAsync(FavTeam.Driver1);
            //int points2 = await Calculate.CalculatePointsForOneDriverAsync(FavTeam.Driver2);
            var Driver1 = await DriverRepository.GetByName(FavTeam.Driver1);
            var Driver2 = await DriverRepository.GetByName(FavTeam.Driver2);
            
            //Position
            Label21.Text = Driver1.Position.ToString();
            Label23.Text = Driver2.Position.ToString();

            if (int.Parse(Driver1.Position) > int.Parse(Driver2.Position))
                Label23.FontAttributes = FontAttributes.Bold;
            else if (int.Parse(Driver1.Position) < int.Parse(Driver2.Position))
                Label21.FontAttributes = FontAttributes.Bold;
            else
            {
                Label21.FontAttributes = FontAttributes.Bold;
                Label23.FontAttributes = FontAttributes.Bold;
            }

            //Points
            Label31.Text = Driver1.PointsSeason.ToString();
            Label33.Text = Driver2.PointsSeason.ToString();

            if (int.Parse(Driver1.PointsSeason) > int.Parse(Driver2.PointsSeason))
                Label31.FontAttributes = FontAttributes.Bold;
            else if (int.Parse(Driver1.PointsSeason) < int.Parse(Driver2.PointsSeason))
                Label33.FontAttributes = FontAttributes.Bold;
            else
            {
                Label31.FontAttributes = FontAttributes.Bold;
                Label33.FontAttributes = FontAttributes.Bold;
            }

            //AvgPoints
            var value = (float.Parse(Driver1.PointsSeason) / (float.Parse(Driver1.NoApp) / 10));
            Label41.Text = String.Format("{0:0.00}", (float.Parse(Driver1.PointsSeason) / (float.Parse(Driver1.NoApp) / 10)));
            Label43.Text = String.Format("{0:0.00}", (float.Parse(Driver2.PointsSeason) / (float.Parse(Driver2.NoApp) / 10)));

            if(float.Parse(Label41.Text) > float.Parse(Label43.Text))
                Label41.FontAttributes = FontAttributes.Bold;
            else if (float.Parse(Label41.Text) < float.Parse(Label43.Text))
                Label43.FontAttributes = FontAttributes.Bold;
            else
            {
                Label41.FontAttributes = FontAttributes.Bold;
                Label43.FontAttributes = FontAttributes.Bold;
            }

            //AvgPos
            Label51.Text = String.Format("{0:0.00}", (float.Parse(Driver1.AccumulatedPos) / float.Parse(Driver1.NoApp)));
            Label53.Text = String.Format("{0:0.00}", (float.Parse(Driver2.AccumulatedPos) / float.Parse(Driver2.NoApp)));

            if (float.Parse(Label51.Text) < float.Parse(Label53.Text))
                Label51.FontAttributes = FontAttributes.Bold;
            else if (float.Parse(Label51.Text) > float.Parse(Label53.Text))
                Label53.FontAttributes = FontAttributes.Bold;
            else
            {
                Label51.FontAttributes = FontAttributes.Bold;
                Label53.FontAttributes = FontAttributes.Bold;
            }

            //NextRace
            var CircuitsList = await CircuitRepository.GetAllCircuits();

            foreach (CircuitModel c in CircuitsList)
            {
                string NoMonth = ReturnMonth(c.Date);
                string resultString = Regex.Match(c.Date, @"\d+").Value;

                if (NoMonth.Length != 2)
                {
                    NoMonth = "0" + NoMonth;
                }

                if (resultString.Length != 2)
                {
                    resultString = "0" + resultString;
                }

                DateTime DateGp;
                DateTime.TryParseExact(resultString + "/" + NoMonth + "/2024", "dd/MM/yyyy", null, DateTimeStyles.None, out DateGp);

                c.DateGP = DateGp;
            }

            List<CircuitModel> CircuitsSortedList = CircuitsList.OrderBy(o => o.DateGP).ToList();
            foreach (var circuit in CircuitsSortedList)
            {
                if (circuit.FutureRace == "1")
                {
                    NextRaceSend = circuit.CircuitName;
                    var index_sing = circuit.CircuitName.IndexOf("-") + 1;
                    char[] CharCircuits = circuit.CircuitName.ToCharArray();
                    CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                    circuit.CircuitName = new string(CharCircuits);
                    NextRace.Text = circuit.CircuitName.Replace("_","-");
                    break;
                }
            }
            if(NextRace.Text == null)
            {
                NextRace.Text = "See you next year";
                NextRace.FontSize = 20;
            }
        }

        private string ReturnMonth(string month)
        {
            string NoMonth;
            if (month.Contains("Feb"))
                NoMonth = "2";
            else if (month.Contains("Mar"))
                NoMonth = "3";
            else if (month.Contains("Apr"))
                NoMonth = "4";
            else if (month.Contains("May"))
                NoMonth = "5";
            else if (month.Contains("Jun"))
                NoMonth = "6";
            else if (month.Contains("Jul"))
                NoMonth = "7";
            else if (month.Contains("Aug"))
                NoMonth = "8";
            else if (month.Contains("Sep"))
                NoMonth = "9";
            else if (month.Contains("Oct"))
                NoMonth = "10";
            else if (month.Contains("Nov"))
                NoMonth = "11";
            else
                NoMonth = "12";
            return NoMonth;
        }

        private async Task ChangeBackroundColor(TeamModel FavTeam)
		{
            switch (FavTeam.Team)
            {
                case "Kick Sauber":
                    this.BackgroundColor = Color.FromHex("#52E252");
                    break;
                case "RB":
                    this.BackgroundColor = Color.FromHex("#6692FF");
                    break;
                case "Alpine":
                    this.BackgroundColor = Color.FromHex("#FF87BC");
                    break;
                case "Aston Martin":
                    this.BackgroundColor = Color.FromHex("#358C75");
                    break;
                case "Ferrari":
                    this.BackgroundColor = Color.FromHex("#E8002D");
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
                    this.BackgroundColor = Color.FromHex("#64C4FF");
                    break;
            }
        }

        private async void NextRace_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PredictionPage(NextRaceSend));
        }
    }
}
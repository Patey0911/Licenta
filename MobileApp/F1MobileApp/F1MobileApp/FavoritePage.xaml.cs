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
            this.BackgroundColor = Color.FromHex("#FFFFFF");

            //Show data for favourite team and drivers
            NameDriver1.Text = FavTeam.Driver1;
            NameDriver2.Text = FavTeam.Driver2;

            if(FavTeam.Driver1==FavDriver.LastName)
                NameDriver1.FontAttributes = FontAttributes.Bold;
            else
                NameDriver2.FontAttributes = FontAttributes.Bold;

            Image1.Source = FavTeam.Driver1.Replace(" ","")+".png";
            Image2.Source = FavTeam.Team.Replace(" ", "") + ".png";
            Image3.Source = FavTeam.Driver2.Replace(" ", "") + ".png";

            //int points1 = await Calculate.CalculatePointsForOneDriverAsync(FavTeam.Driver1);
            //int points2 = await Calculate.CalculatePointsForOneDriverAsync(FavTeam.Driver2);
            var Driver1 = await DriverRepository.GetByName(FavTeam.Driver1);
            var Driver2 = await DriverRepository.GetByName(FavTeam.Driver2);

            //Position
            PositionDriver1.Text = Driver1.Position.ToString();
            PositionDriver2.Text = Driver2.Position.ToString();

            if (int.Parse(Driver1.Position) > int.Parse(Driver2.Position))
                PositionDriver2.FontAttributes = FontAttributes.Bold;
            else if (int.Parse(Driver1.Position) < int.Parse(Driver2.Position))
                PositionDriver1.FontAttributes = FontAttributes.Bold;
            else
            {
                PositionDriver1.FontAttributes = FontAttributes.Bold;
                PositionDriver2.FontAttributes = FontAttributes.Bold;
            }

            //Points
            PointsDriver1.Text = Driver1.PointsSeason.ToString();
            PointsDriver2.Text = Driver2.PointsSeason.ToString();

            if (int.Parse(Driver1.PointsSeason) > int.Parse(Driver2.PointsSeason))
                PointsDriver1.FontAttributes = FontAttributes.Bold;
            else if (int.Parse(Driver1.PointsSeason) < int.Parse(Driver2.PointsSeason))
                PointsDriver2.FontAttributes = FontAttributes.Bold;
            else
            {
                PointsDriver1.FontAttributes = FontAttributes.Bold;
                PointsDriver2.FontAttributes = FontAttributes.Bold;
            }

            //AvgPoints
            var value = (float.Parse(Driver1.PointsSeason) / (float.Parse(Driver1.NoApp) / 10));
            AvgPtsDriver1.Text = String.Format("{0:0.00}", (float.Parse(Driver1.PointsSeason) / (float.Parse(Driver1.NoApp) / 10)));
            AvgPtsDriver2.Text = String.Format("{0:0.00}", (float.Parse(Driver2.PointsSeason) / (float.Parse(Driver2.NoApp) / 10)));

            if(float.Parse(AvgPtsDriver1.Text) > float.Parse(AvgPtsDriver2.Text))
                AvgPtsDriver1.FontAttributes = FontAttributes.Bold;
            else if (float.Parse(AvgPtsDriver1.Text) < float.Parse(AvgPtsDriver2.Text))
                AvgPtsDriver2.FontAttributes = FontAttributes.Bold;
            else
            {
                AvgPtsDriver1.FontAttributes = FontAttributes.Bold;
                AvgPtsDriver2.FontAttributes = FontAttributes.Bold;
            }

            //AvgPos
            AvgPosDriver1.Text = String.Format("{0:0.00}", (float.Parse(Driver1.AccumulatedPos) / float.Parse(Driver1.NoApp)));
            AvgPosDriver2.Text = String.Format("{0:0.00}", (float.Parse(Driver2.AccumulatedPos) / float.Parse(Driver2.NoApp)));

            if (float.Parse(AvgPosDriver1.Text) < float.Parse(AvgPosDriver2.Text))
                AvgPosDriver1.FontAttributes = FontAttributes.Bold;
            else if (float.Parse(AvgPosDriver1.Text) > float.Parse(AvgPosDriver2.Text))
                AvgPosDriver2.FontAttributes = FontAttributes.Bold;
            else
            {
                AvgPosDriver1.FontAttributes = FontAttributes.Bold;
                AvgPosDriver2.FontAttributes = FontAttributes.Bold;
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

        private async void NextRace_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PredictionPage(NextRaceSend));
        }
    }
}
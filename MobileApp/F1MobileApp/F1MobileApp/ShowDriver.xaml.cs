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
using Org.Xmlpull.V1.Sax2;
using Java.Lang;
using Java.Sql;

namespace F1MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowDriver : ContentPage
    {
        public string drivername;
        public ShowDriver(string driver)
        {
            InitializeComponent();
            drivername = driver;
        }
        protected override async void OnAppearing()
        {
            ImageDriver.Source = drivername + ".png";

            var Driver = await DriverRepository.GetByName(drivername);

            BackgroundColor = Color.FromHex(ChangeBackroundColor(Driver.Team));

            Label01.Text = Driver.Position.ToString(); 
            Label11.Text = Driver.Team.ToString();
            Label21.Text = Driver.Country.ToString();
            Label31.Text = Driver.WorldChampionships.ToString();
            Label41.Text = Driver.PointsSeason.ToString();
            Label51.Text = Driver.Points.ToString();
            Label61.Text = Driver.GrandsPrixEntered.ToString();
            Label71.Text = Driver.HighestRaceFinish.ToString();
            Label81.Text = Driver.HighestGridPosition.ToString();
            Label91.Text = System.String.Format("{0:0.00}", (float.Parse(Driver.PointsSeason) / (float.Parse(Driver.NoApp) / 10)));
            Label101.Text = System.String.Format("{0:0.00}", (float.Parse(Driver.AccumulatedPos) / (float.Parse(Driver.NoApp))));
            ImageCar.Source = Driver.Team.ToString().Replace(" ","") + "Car.png";
        }
        private string ChangeBackroundColor(string FavTeam)
		{
            switch (FavTeam)
            {
                case "Alfa Romeo":
                    return "#C92D4B";
                case "AlphaTauri":
                    return "#5E8FAA";
                case "Alpine":
                    return "#2293D1";
                case "Aston Martin":
                    return "#358C75";
                case "Ferrari":
                    return "#F91536";
                case "Haas F1 Team":
                    return "#B6BABD";
                case "McLaren":
                    return "#F58020";
                case "Mercedes":
                    return "#6CD3BF";
                case "Red Bull Racing":
                    return "#3671C6";
                case "Williams":
                    return "#37BEDD";
                default:
                    return "0";
            }
        }
    }
}
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
    public partial class ShowTeam : ContentPage
    {
        public string team;
        public int position;
        public ShowTeam(string team, int position)
        {
            InitializeComponent();
            this.team = team;
            this.position = position;
        }
        protected override async void OnAppearing()
        {
            BackgroundColor = Color.FromHex(ChangeBackroundColor(team));
            ImageLogo.Source = team.Replace(" ","") + ".png";

            var Team = await TeamRepository.GetByTeam(team);

            Label01.Text = Team.Team.ToString();
            Label11.Text = Team.Base.ToString();
            Label21.Text = position.ToString();
            Label31.Text = Team.Points.ToString();
            Label41.Text = Team.TeamChief.ToString();
            Label71.Text = Team.FastestLaps.ToString();
            Label81.Text = Team.FirstTeamEntry.ToString();
            Label91.Text = Team.HighestRaceFinish.ToString();
            Label101.Text = Team.PolePositions.ToString();
            Label111.Text = Team.WorldChampionships.ToString();
            Label121.Text = Team.PowerUnit.ToString();

            LabelDriver1.Text = Team.Driver1.ToString();
            LabelDriver2.Text = Team.Driver2.ToString();

            ImageCar.Source = Team.Team.ToString().Replace(" ", "") + "Car.png";
            ImageDriver1.Source = Team.Driver1.ToString() + ".png";
            ImageDriver2.Source = Team.Driver2.ToString() + ".png";
        }
        private string ChangeBackroundColor(string FavTeam)
		{
            switch (FavTeam)
            {
                case "Kick Sauber":
                    return "#52E252";
                case "RB":
                    return "#6692FF";
                case "Alpine":
                    return "#FF87BC";
                case "Aston Martin":
                    return "#358C75";
                case "Ferrari":
                    return "#E8002D";
                case "Haas F1 Team":
                    return "#B6BABD";
                case "McLaren":
                    return "#F58020";
                case "Mercedes":
                    return "#6CD3BF";
                case "Red Bull Racing":
                    return "#3671C6";
                case "Williams":
                    return "#64C4FF";
                default:
                    return "0";
            }
        }
    }
}
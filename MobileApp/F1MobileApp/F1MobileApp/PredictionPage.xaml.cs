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

namespace F1MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PredictionPage : ContentPage
    {
        List<DriverModel> DriversSortedList;
        public string circuitname;
        public PredictionPage(string circuit)
        {
            InitializeComponent();
            circuitname = circuit;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ShowDrivers();
        }

        private async Task ShowDrivers()
        {
            this.BackgroundColor = Color.FromHex("#FFFFFF");

            CircuitModel Results = await CircuitRepository.GetByName(circuitname);
            DriverModel Driver;

            RaceName.Text = Results.CircuitName.ToUpper().Replace("_","-");

            //1st Place
            Driver = await DriverRepository.GetByName(Results.Place1);
            ImageDriver1.Source = Driver.LastName + ".png";
            Driver1.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam1.Source = Driver.Team.Replace(" ", "") + ".png";

            //2nd Place
            Driver = await DriverRepository.GetByName(Results.Place2);
            ImageDriver2.Source = Driver.LastName + ".png";
            Driver2.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam2.Source = Driver.Team.Replace(" ", "") + ".png";

            //3rd Place
            Driver = await DriverRepository.GetByName(Results.Place3);
            ImageDriver3.Source = Driver.LastName + ".png";
            Driver3.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam3.Source = Driver.Team.Replace(" ", "") + ".png";

            //4th Place
            Driver = await DriverRepository.GetByName(Results.Place4);
            ImageDriver4.Source = Driver.LastName + ".png";
            Driver4.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam4.Source = Driver.Team.Replace(" ", "") + ".png";

            //5th Place
            Driver = await DriverRepository.GetByName(Results.Place5);
            ImageDriver5.Source = Driver.LastName + ".png";
            Driver5.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam5.Source = Driver.Team.Replace(" ", "") + ".png";

            //6th Place
            Driver = await DriverRepository.GetByName(Results.Place6);
            ImageDriver6.Source = Driver.LastName + ".png";
            Driver6.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam6.Source = Driver.Team.Replace(" ", "") + ".png";

            //7th Place
            Driver = await DriverRepository.GetByName(Results.Place7);
            ImageDriver7.Source = Driver.LastName + ".png";
            Driver7.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam7.Source = Driver.Team.Replace(" ", "") + ".png";

            //8th Place
            Driver = await DriverRepository.GetByName(Results.Place8);
            ImageDriver8.Source = Driver.LastName + ".png";
            Driver8.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam8.Source = Driver.Team.Replace(" ", "") + ".png";

            //9th Place
            Driver = await DriverRepository.GetByName(Results.Place9);
            ImageDriver9.Source = Driver.LastName + ".png";
            Driver9.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam9.Source = Driver.Team.Replace(" ", "") + ".png";

            //10th Place
            Driver = await DriverRepository.GetByName(Results.Place10);
            ImageDriver10.Source = Driver.LastName + ".png";
            Driver10.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam10.Source = Driver.Team.Replace(" ", "") + ".png";

            //11th Place
            Driver = await DriverRepository.GetByName(Results.Place11);
            ImageDriver11.Source = Driver.LastName + ".png";
            Driver11.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam11.Source = Driver.Team.Replace(" ", "") + ".png";

            //12th Place
            Driver = await DriverRepository.GetByName(Results.Place12);
            ImageDriver12.Source = Driver.LastName + ".png";
            Driver12.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam12.Source = Driver.Team.Replace(" ", "") + ".png";

            //13th Place
            Driver = await DriverRepository.GetByName(Results.Place13);
            ImageDriver13.Source = Driver.LastName + ".png";
            Driver13.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam13.Source = Driver.Team.Replace(" ", "") + ".png";

            //14th Place
            Driver = await DriverRepository.GetByName(Results.Place14);
            ImageDriver14.Source = Driver.LastName + ".png";
            Driver14.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam14.Source = Driver.Team.Replace(" ", "") + ".png";

            //15th Place
            Driver = await DriverRepository.GetByName(Results.Place15);
            ImageDriver15.Source = Driver.LastName + ".png";
            Driver15.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam15.Source = Driver.Team.Replace(" ", "") + ".png";

            //16th Place
            Driver = await DriverRepository.GetByName(Results.Place16);
            ImageDriver16.Source = Driver.LastName + ".png";
            Driver16.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam16.Source = Driver.Team.Replace(" ", "") + ".png";

            //17th Place
            Driver = await DriverRepository.GetByName(Results.Place17);
            ImageDriver17.Source = Driver.LastName + ".png";
            Driver17.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam17.Source = Driver.Team.Replace(" ", "") + ".png";

            //18th Place
            Driver = await DriverRepository.GetByName(Results.Place18);
            ImageDriver18.Source = Driver.LastName + ".png";
            Driver18.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam18.Source = Driver.Team.Replace(" ", "") + ".png";

            //19th Place
            Driver = await DriverRepository.GetByName(Results.Place19);
            ImageDriver19.Source = Driver.LastName + ".png";
            Driver19.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam19.Source = Driver.Team.Replace(" ", "") + ".png";

            //20th Place
            Driver = await DriverRepository.GetByName(Results.Place20);
            ImageDriver20.Source = Driver.LastName + ".png";
            Driver20.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam20.Source = Driver.Team.Replace(" ", "") + ".png";
        }
    }
}
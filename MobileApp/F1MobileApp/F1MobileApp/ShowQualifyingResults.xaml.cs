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
    public partial class ShowQualifyingResults : ContentPage
    {
        List<DriverModel> DriversSortedList;
        public string circuitname;
        public ShowQualifyingResults(string circuit)
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

            RaceName.Text = Results.CircuitName.ToUpper() + " Qualifying";

            //1st Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying1);
            ImageDriver1.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver1.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam1.Source = Driver.Team.Replace(" ", "") + ".png";

            //2nd Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying2);
            ImageDriver2.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver2.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam2.Source = Driver.Team.Replace(" ", "") + ".png";

            //3rd Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying3);
            ImageDriver3.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver3.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam3.Source = Driver.Team.Replace(" ", "") + ".png";

            //4th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying4);
            ImageDriver4.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver4.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam4.Source = Driver.Team.Replace(" ", "") + ".png";

            //5th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying5);
            ImageDriver5.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver5.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam5.Source = Driver.Team.Replace(" ", "") + ".png";

            //6th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying6);
            ImageDriver6.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver6.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam6.Source = Driver.Team.Replace(" ", "") + ".png";

            //7th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying7);
            ImageDriver7.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver7.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam7.Source = Driver.Team.Replace(" ", "") + ".png";

            //8th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying8);
            ImageDriver8.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver8.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam8.Source = Driver.Team.Replace(" ", "") + ".png";

            //9th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying9);
            ImageDriver9.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver9.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam9.Source = Driver.Team.Replace(" ", "") + ".png";

            //10th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying10);
            ImageDriver10.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver10.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam10.Source = Driver.Team.Replace(" ", "") + ".png";

            //11th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying11);
            ImageDriver11.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver11.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam11.Source = Driver.Team.Replace(" ", "") + ".png";

            //12th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying12);
            ImageDriver12.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver12.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam12.Source = Driver.Team.Replace(" ", "") + ".png";

            //13th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying13);
            ImageDriver13.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver13.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam13.Source = Driver.Team.Replace(" ", "") + ".png";

            //14th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying14);
            ImageDriver14.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver14.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam14.Source = Driver.Team.Replace(" ", "") + ".png";

            //15th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying15);
            ImageDriver15.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver15.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam15.Source = Driver.Team.Replace(" ", "") + ".png";

            //16th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying16);
            ImageDriver16.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver16.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam16.Source = Driver.Team.Replace(" ", "") + ".png";

            //17th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying17);
            ImageDriver17.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver17.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam17.Source = Driver.Team.Replace(" ", "") + ".png";

            //18th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying18);
            ImageDriver18.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver18.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam18.Source = Driver.Team.Replace(" ", "") + ".png";

            //19th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying19);
            ImageDriver19.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver19.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam19.Source = Driver.Team.Replace(" ", "") + ".png";

            //20th Place
            Driver = await DriverRepository.GetByNo(Results.Qualifying20);
            ImageDriver20.Source = Driver.LastName.Replace(" ", "") + ".png";
            Driver20.Text = Driver.FirstName + " " + Driver.LastName;
            ImageTeam20.Source = Driver.Team.Replace(" ", "") + ".png";
        }
    }
}
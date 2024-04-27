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
    public partial class DriversPage : ContentPage
    {
        public static List<DriverModel> DriversSortedList;

        public DriversPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            int NoDriver = -1;
            this.BackgroundColor = Color.FromHex("#FFFFFF");
            List<DriverModel> DriversSortedList = await DriverRepository.GetAllDrivers();
            DriversSortedList = DriversSortedList.OrderByDescending(o => int.Parse(o.PointsSeason)).ToList();

            foreach (var Driver in DriversSortedList)
            {
                NoDriver++;
                switch(NoDriver)
                {
                    case 0:
                        ButtonStackLayout1.BackgroundColor=Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image1.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName1.Text = DriversSortedList[NoDriver].FirstName +" "+ DriversSortedList[NoDriver].LastName;
                        LabelPts1.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 1:
                        ButtonStackLayout2.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image2.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName2.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts2.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 2:
                        ButtonStackLayout3.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image3.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName3.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts3.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 3:
                        ButtonStackLayout4.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image4.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName4.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts4.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 4:
                        ButtonStackLayout5.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image5.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName5.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts5.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 5:
                        ButtonStackLayout6.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image6.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName6.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts6.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 6:
                        ButtonStackLayout7.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image7.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName7.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts7.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 7:
                        ButtonStackLayout8.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image8.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName8.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts8.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 8:
                        ButtonStackLayout9.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image9.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName9.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts9.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 9:
                        ButtonStackLayout10.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image10.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName10.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts10.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 10:
                        ButtonStackLayout11.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image11.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName11.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts11.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 11:
                        ButtonStackLayout12.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image12.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName12.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts12.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 12:
                        ButtonStackLayout13.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image13.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName13.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts13.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 13:
                        ButtonStackLayout14.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image14.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName14.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts14.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 14:
                        ButtonStackLayout15.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image15.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName15.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts15.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 15:
                        ButtonStackLayout16.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image16.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName16.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts16.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 16:
                        ButtonStackLayout17.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image17.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName17.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts17.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 17:
                        ButtonStackLayout18.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image18.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName18.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts18.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 18:
                        ButtonStackLayout19.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image19.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName19.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts19.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 19:
                        ButtonStackLayout20.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image20.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName20.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts20.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                    case 20:
                        ButtonStackLayout21.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[NoDriver].Team));
                        Image21.Source = DriversSortedList[NoDriver].LastName.Replace(" ", "") + ".png";
                        LabelName21.Text = DriversSortedList[NoDriver].FirstName + " " + DriversSortedList[NoDriver].LastName;
                        LabelPts21.Text = DriversSortedList[NoDriver].PointsSeason;
                        break;
                }
            }
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
                case "Haas":
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
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[0].LastName));
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[1].LastName));
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[2].LastName));
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[3].LastName));
        }

        private async void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[4].LastName));
        }

        private async void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[5].LastName));
        }

        private async void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[6].LastName));
        }

        private async void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[7].LastName));
        }

        private async void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[8].LastName));
        }

        private async void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[9].LastName));
        }

        private async void TapGestureRecognizer_Tapped_10(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[10].LastName));
        }

        private async void TapGestureRecognizer_Tapped_11(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[11].LastName));
        }

        private async void TapGestureRecognizer_Tapped_12(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[12].LastName));
        }

        private async void TapGestureRecognizer_Tapped_13(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[13].LastName));
        }

        private async void TapGestureRecognizer_Tapped_14(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[14].LastName));
        }

        private async void TapGestureRecognizer_Tapped_15(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[15].LastName));
        }

        private async void TapGestureRecognizer_Tapped_16(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[16].LastName));
        }

        private async void TapGestureRecognizer_Tapped_17(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[17].LastName));
        }

        private async void TapGestureRecognizer_Tapped_18(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[18].LastName));
        }

        private async void TapGestureRecognizer_Tapped_19(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[19].LastName));
        }

        private async void TapGestureRecognizer_Tapped_20(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowDriver(DriversSortedList[20].LastName));
        }
    }
}
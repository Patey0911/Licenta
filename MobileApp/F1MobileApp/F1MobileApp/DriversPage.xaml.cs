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
            int index = -1;
            this.BackgroundColor = Color.FromHex("#FFFFFF");
            List<DriverModel> DriversList = await DriverRepository.GetAllDrivers();
            DriversSortedList = DriversList.OrderByDescending(o => int.Parse(o.PointsSeason)).ToList();

            foreach (var Driver in DriversSortedList)
            {
                index++;
                switch(index)
                {
                    case 0:
                        ButtonStackLayout1.BackgroundColor=Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image1.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label1.Text = DriversSortedList[index].FirstName +" "+ DriversSortedList[index].LastName;
                        LabelPts1.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 1:
                        ButtonStackLayout2.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image2.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label2.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts2.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 2:
                        ButtonStackLayout3.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image3.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label3.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts3.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 3:
                        ButtonStackLayout4.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image4.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label4.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts4.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 4:
                        ButtonStackLayout5.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image5.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label5.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts5.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 5:
                        ButtonStackLayout6.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image6.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label6.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts6.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 6:
                        ButtonStackLayout7.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image7.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label7.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts7.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 7:
                        ButtonStackLayout8.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image8.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label8.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts8.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 8:
                        ButtonStackLayout9.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image9.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label9.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts9.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 9:
                        ButtonStackLayout10.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image10.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label10.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts10.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 10:
                        ButtonStackLayout11.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image11.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label11.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts11.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 11:
                        ButtonStackLayout12.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image12.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label12.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts12.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 12:
                        ButtonStackLayout13.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image13.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label13.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts13.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 13:
                        ButtonStackLayout14.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image14.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label14.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts14.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 14:
                        ButtonStackLayout15.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image15.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label15.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts15.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 15:
                        ButtonStackLayout16.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image16.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label16.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts16.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 16:
                        ButtonStackLayout17.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image17.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label17.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts17.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 17:
                        ButtonStackLayout18.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image18.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label18.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts18.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 18:
                        ButtonStackLayout19.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image19.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label19.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts19.Text = DriversSortedList[index].PointsSeason;
                        break;
                    case 19:
                        ButtonStackLayout20.BackgroundColor = Color.FromHex(ChangeBackroundColor(DriversSortedList[index].Team));
                        Image20.Source = DriversSortedList[index].LastName.Replace(" ", "") + ".png";
                        Label20.Text = DriversSortedList[index].FirstName + " " + DriversSortedList[index].LastName;
                        LabelPts20.Text = DriversSortedList[index].PointsSeason;
                        break;
                }
            }
        }

		private string ChangeBackroundColor(string FavTeam)
		{
            switch (FavTeam)
            {
                case "Kick Sauber":
                    return "#C92D4B";
                case "RB":
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
    }
}
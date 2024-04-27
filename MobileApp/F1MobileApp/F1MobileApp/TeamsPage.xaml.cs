﻿using Android;
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
    public partial class TeamsPage : ContentPage
    {
        public static List<TeamModel> TeamsSortedList;

        public TeamsPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            int NoTeams = -1;
            this.BackgroundColor = Color.FromHex("#FFFFFF");
            List<TeamModel> TeamsSortedList = await TeamRepository.GetAllTeams();
            TeamsSortedList = TeamsSortedList.OrderByDescending(o => int.Parse(o.Points)).ToList();

            foreach (var Team in TeamsSortedList)
            {
                NoTeams++;
                switch(NoTeams)
                {
                    case 0:
                        ButtonStackLayout1.BackgroundColor=Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image1.Source = TeamsSortedList[NoTeams].Team.Replace(" ","") + ".png";
                        LabelTeam1.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts1.Text = TeamsSortedList[NoTeams].Points;
                        break;
                    case 1:
                        ButtonStackLayout2.BackgroundColor = Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image2.Source = TeamsSortedList[NoTeams].Team.Replace(" ", "") + ".png";
                        LabelTeam2.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts2.Text = TeamsSortedList[NoTeams].Points;
                        break;
                    case 2:
                        ButtonStackLayout3.BackgroundColor = Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image3.Source = TeamsSortedList[NoTeams].Team.Replace(" ", "") + ".png";
                        LabelTeam3.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts3.Text = TeamsSortedList[NoTeams].Points;
                        break;
                    case 3:
                        ButtonStackLayout4.BackgroundColor = Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image4.Source = TeamsSortedList[NoTeams].Team.Replace(" ", "") + ".png";
                        LabelTeam4.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts4.Text = TeamsSortedList[NoTeams].Points;
                        break;
                    case 4:
                        ButtonStackLayout5.BackgroundColor = Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image5.Source = TeamsSortedList[NoTeams].Team.Replace(" ", "") + ".png";
                        LabelTeam5.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts5.Text = TeamsSortedList[NoTeams].Points;
                        break;
                    case 5:
                        ButtonStackLayout6.BackgroundColor = Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image6.Source = TeamsSortedList[NoTeams].Team.Replace(" ", "") + ".png";
                        LabelTeam6.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts6.Text = TeamsSortedList[NoTeams].Points;
                        break;
                    case 6:
                        ButtonStackLayout7.BackgroundColor = Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image7.Source = TeamsSortedList[NoTeams].Team.Replace(" ", "") + ".png";
                        LabelTeam7.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts7.Text = TeamsSortedList[NoTeams].Points;
                        break;
                    case 7:
                        ButtonStackLayout8.BackgroundColor = Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image8.Source = TeamsSortedList[NoTeams].Team.Replace(" ", "") + ".png";
                        LabelTeam8.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts8.Text = TeamsSortedList[NoTeams].Points;
                        break;
                    case 8:
                        ButtonStackLayout9.BackgroundColor = Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image9.Source = TeamsSortedList[NoTeams].Team.Replace(" ", "") + ".png";
                        LabelTeam9.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts9.Text = TeamsSortedList[NoTeams].Points;
                        break;
                    case 9:
                        ButtonStackLayout10.BackgroundColor = Color.FromHex(ChangeBackroundColor(TeamsSortedList[NoTeams].Team));
                        Image10.Source = TeamsSortedList[NoTeams].Team.Replace(" ", "") + ".png";
                        LabelTeam10.Text = TeamsSortedList[NoTeams].Team;
                        LabelPts10.Text = TeamsSortedList[NoTeams].Points;
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
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[0].Team,1));
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[1].Team,2));
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[2].Team,3));
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[3].Team,4));
        }

        private async void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[4].Team,5));
        }

        private async void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[5].Team,6));
        }

        private async void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[6].Team,7));
        }

        private async void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[7].Team,8));
        }

        private async void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[8].Team,9));
        }

        private async void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowTeam(TeamsSortedList[9].Team,10));
        }
    }
}
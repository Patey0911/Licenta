using Microcharts;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microcharts.Forms;
using SkiaSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LiveCharts;
using Syncfusion.XForms.Themes;
using Syncfusion.SfChart.XForms;
using System.Collections.ObjectModel;
using Org.Xmlpull.V1.Sax2;
using Org.Apache.Http.Cookies;
using Java.Sql;
using Android.Media;
using Orientation = Microcharts.Orientation;
using static System.Net.Mime.MediaTypeNames;

namespace F1MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticPage : ContentPage
    {
        public static UserModel user;
        public String[] teams_names;
        public String[] drivers_names;
        public DriverModel Driver1;
        public DriverModel Driver2;
        public TeamModel Team1;
        public TeamModel Team2;
        public bool First = true;
        List<DriversAndPositions> DriversAndPositions = new List<DriversAndPositions>();
        List<DriversAndQualifyingPosition> DriversAndQualifyingPosition = new List<DriversAndQualifyingPosition>();

        public StatisticPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            if (First)
            {
                GetPosition();
                GetQualifyingPosition();
                ButtonSelect.Text = "Drivers";

                ButtonSelectNo1.Text = FavoritePage.FavTeam.Driver1;
                ButtonSelectNo2.Text = FavoritePage.FavTeam.Driver2;

                ButtonColor1.BackgroundColor = Color.FromHex(ChangeBackroundColorDrivers(ButtonSelectNo1.Text));
                ButtonColor2.BackgroundColor = Color.FromHex(ChangeBackroundColorDrivers(ButtonSelectNo2.Text));
                Image1.Source = ButtonSelectNo1.Text.Replace(" ", "") + ".png";
                Image2.Source = ButtonSelectNo2.Text.Replace(" ", "") + ".png";

                Driver1 = await DriverRepository.GetByName(ButtonSelectNo1.Text);
                Driver2 = await DriverRepository.GetByName(ButtonSelectNo2.Text);
                ButtonMode.Text = "Points %";

                ModifiyChartDrivers(ButtonSelectNo1.Text, ButtonSelectNo2.Text, ButtonMode.Text);

                teams_names = new string[10];
                drivers_names = new string[22];

                int poz = 0;
                foreach (var team in TeamsPage.TeamsSortedList)
                {
                    teams_names[poz] = team.Team;
                    poz++;
                }

                poz = 0;
                foreach (var driver in DriversPage.DriversSortedList)
                {
                    drivers_names[poz] = driver.LastName;
                    poz++;
                }
                First = false;
            }
        }

        private async void ButtonSelect_Clicked(object sender, EventArgs e)
        {
            String[] Options = new string[2];

            Options[0] = "Teams";
            Options[1] = "Drivers";

            string action = await DisplayActionSheet("Select", "Cancel", null, Options);
            if (action != null && action != "Cancel")
                ButtonSelect.Text = action;

            if (ButtonSelect.Text == "Teams")
            {
                ButtonMode.Text = "Points %";
                ButtonSelectNo1.Text = FavoritePage.FavTeam.Team;
                if (ButtonSelectNo1.Text == TeamsPage.TeamsSortedList[0].Team)
                    ButtonSelectNo2.Text = TeamsPage.TeamsSortedList[1].Team;
                else
                    ButtonSelectNo2.Text = TeamsPage.TeamsSortedList[0].Team;

                ButtonColor1.BackgroundColor = Color.FromHex(ChangeBackroundColorTeams(ButtonSelectNo1.Text));
                ButtonColor2.BackgroundColor = Color.FromHex(ChangeBackroundColorTeams(ButtonSelectNo2.Text));
                Image1.Source = ButtonSelectNo1.Text.Replace(" ", "") + ".png";
                Image2.Source = ButtonSelectNo2.Text.Replace(" ", "") + ".png";

                Team1 = await TeamRepository.GetByTeam(ButtonSelectNo1.Text);
                Team2 = await TeamRepository.GetByTeam(ButtonSelectNo2.Text);
                await ModifiyChartTeams(ButtonSelectNo1.Text, ButtonSelectNo2.Text, ButtonMode.Text);
            }
            else if (ButtonSelect.Text == "Drivers")
            {
                ButtonMode.Text = "Points %";
                ButtonSelectNo1.Text = FavoritePage.FavDriver.LastName;
                if (ButtonSelectNo1.Text == FavoritePage.FavTeam.Driver1)
                    ButtonSelectNo2.Text = FavoritePage.FavTeam.Driver2;
                else
                    ButtonSelectNo2.Text = FavoritePage.FavTeam.Driver1;

                ButtonColor1.BackgroundColor = Color.FromHex(ChangeBackroundColorDrivers(ButtonSelectNo1.Text));
                ButtonColor2.BackgroundColor = Color.FromHex(ChangeBackroundColorDrivers(ButtonSelectNo2.Text));
                Image1.Source = ButtonSelectNo1.Text.Replace(" ", "") + ".png";
                Image2.Source = ButtonSelectNo2.Text.Replace(" ", "") + ".png";

                Driver1 = await DriverRepository.GetByName(ButtonSelectNo1.Text);
                Driver2 = await DriverRepository.GetByName(ButtonSelectNo2.Text);
                ModifiyChartDrivers(ButtonSelectNo1.Text, ButtonSelectNo2.Text, ButtonMode.Text);
            }

            if (ButtonSelect.Text != "Drivers/Teams")
            {
                ButtonSelectNo1.IsEnabled = true;
                ButtonSelectNo2.IsEnabled = true;
                ButtonMode.Text = "Points %";
            }
        }

        private async void ButtonMode_Clicked(object sender, EventArgs e)
        {
            String[] Options = new string[5];
            if (ButtonSelect.Text == "Drivers")
            {
                Options[0] = "Points %";
                Options[1] = "Points % All time";
                Options[2] = "Positions in Races";
                Options[3] = "Positions in Qualifiyng";
                Options[4] = "Points Evolution";
            }
            else if (ButtonSelect.Text == "Teams")
            {
                Options[0] = "Points %";
                Options[1] = "Points Evolution";
            }

            string action = await DisplayActionSheet("Select", "Cancel", null, Options);

            if (action != null && action != "Cancel")
                ButtonMode.Text = action;
            if (ButtonSelect.Text == "Drivers")
                ModifiyChartDrivers(ButtonSelectNo1.Text, ButtonSelectNo2.Text, ButtonMode.Text);
            else if (ButtonSelect.Text == "Teams")
                await ModifiyChartTeams(ButtonSelectNo1.Text, ButtonSelectNo2.Text, ButtonMode.Text);
        }

        private async void SelectNo1_Clicked(object sender, EventArgs e)
        {
            if (ButtonSelect.Text == "Teams")
            {
                string action = await DisplayActionSheet("List of the Teams", "Cancel", null, teams_names);
                if (action != null && action != "Cancel" && action != ButtonSelectNo2.Text)
                {
                    ButtonSelectNo1.Text = action;
                    Image1.Source = ButtonSelectNo1.Text.Replace(" ", "") + ".png";
                }
                ButtonColor1.BackgroundColor = Color.FromHex(ChangeBackroundColorTeams(ButtonSelectNo1.Text));

                Team1 = await TeamRepository.GetByTeam(ButtonSelectNo1.Text);
                await ModifiyChartTeams(ButtonSelectNo1.Text, ButtonSelectNo2.Text, ButtonMode.Text);
            }
            else
            {
                string action = await DisplayActionSheet("List of the Drivers", "Cancel", null, drivers_names);
                if (action != null && action != "Cancel" && action != ButtonSelectNo2.Text)
                {
                    ButtonSelectNo1.Text = action;
                    Image1.Source = ButtonSelectNo1.Text.Replace(" ", "") + ".png";
                }
                ButtonColor1.BackgroundColor = Color.FromHex(ChangeBackroundColorDrivers(ButtonSelectNo1.Text));

                Driver1 = await DriverRepository.GetByName(ButtonSelectNo1.Text);
                ModifiyChartDrivers(ButtonSelectNo1.Text, ButtonSelectNo2.Text, ButtonMode.Text);
            }
        }

        private async void SelectNo2_Clicked(object sender, EventArgs e)
        {
            if (ButtonSelect.Text == "Teams")
            {
                string action = await DisplayActionSheet("List of the Teams", "Cancel", null, teams_names);
                if (action != null && action != "Cancel" && action != ButtonSelectNo1.Text)
                {
                    ButtonSelectNo2.Text = action;
                    Image2.Source = ButtonSelectNo2.Text.Replace(" ", "") + ".png";
                }
                ButtonColor2.BackgroundColor = Color.FromHex(ChangeBackroundColorTeams(ButtonSelectNo2.Text));

                Team2 = await TeamRepository.GetByTeam(ButtonSelectNo2.Text);
                await ModifiyChartTeams(ButtonSelectNo1.Text, ButtonSelectNo2.Text, ButtonMode.Text);
            }
            else
            {
                string action = await DisplayActionSheet("List of the Drivers", "Cancel", null, drivers_names);
                if (action != null && action != "Cancel" && action != ButtonSelectNo1.Text)
                {
                    ButtonSelectNo2.Text = action;
                    Image2.Source = ButtonSelectNo2.Text.Replace(" ", "") + ".png";
                }
                ButtonColor2.BackgroundColor = Color.FromHex(ChangeBackroundColorDrivers(ButtonSelectNo2.Text));

                Driver2 = await DriverRepository.GetByName(ButtonSelectNo2.Text);
                ModifiyChartDrivers(ButtonSelectNo1.Text, ButtonSelectNo2.Text, ButtonMode.Text);
            }
        }

        private void ModifiyChartDrivers(string driver1, string driver2, string mode)
        {
            if (mode == "Points %")
            {
                float total = float.Parse(Driver1.PointsSeason) + float.Parse(Driver2.PointsSeason);
                float per1 = float.Parse(Driver1.PointsSeason) * 100 / total;
                var per2 = 100 - per1;
                List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>()
                {
                    new ChartEntry(float.Parse(Driver2.PointsSeason))
                    {
                        ValueLabel = Driver2.LastName,
                        Label = Driver2.PointsSeason + "PTS " + String.Format("{0:0.00}", per2) + "%",
                        ValueLabelColor = SKColor.Parse(ChangeBackroundColorDrivers(driver2)),
                        Color = SKColor.Parse(ChangeBackroundColorDrivers(driver2))
                    },
                    new ChartEntry(float.Parse(Driver1.PointsSeason))
                    {
                        ValueLabel = Driver1.LastName,
                        Label = Driver1.PointsSeason + "PTS " + String.Format("{0:0.00}", per1) + "%",
                        ValueLabelColor = SKColor.Parse(ChangeBackroundColorDrivers(driver1)),
                        Color = SKColor.Parse(ChangeBackroundColorDrivers(driver1))
                    }
                };
                ChartView.Chart = new DonutChart()
                {
                    Entries = entries,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Black,
                };
                ChartView1.Chart = null;
            }
            else if(mode == "Points % All time")
            {
                Driver1.Points = Driver1.Points.Replace('.', ',');
                Driver2.Points = Driver2.Points.Replace('.', ',');
                float total = float.Parse(Driver1.Points) + float.Parse(Driver2.Points);
                float per1 = float.Parse(Driver1.Points) * 100 / total;
                var per2 = 100 - per1;
                List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>()
                {
                    new ChartEntry(float.Parse(Driver2.Points))
                    {
                        ValueLabel = Driver2.LastName,
                        Label = Driver2.Points + "PTS " + String.Format("{0:0.00}", per2) + "%",
                        ValueLabelColor = SKColor.Parse(ChangeBackroundColorDrivers(driver2)),
                        Color = SKColor.Parse(ChangeBackroundColorDrivers(driver2))
                    },
                    new ChartEntry(float.Parse(Driver1.Points))
                    {
                        ValueLabel = Driver1.LastName,
                        Label = Driver1.Points + "PTS " + String.Format("{0:0.00}", per1) + "%",
                        ValueLabelColor = SKColor.Parse(ChangeBackroundColorDrivers(driver1)),
                        Color = SKColor.Parse(ChangeBackroundColorDrivers(driver1))
                    }
                };
                ChartView.Chart = new DonutChart()
                {
                    Entries = entries,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Black,
                };
                ChartView1.Chart = null;
            }
            else if (mode == "Positions in Races")
            {
                List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>();
                List<Microcharts.ChartEntry> entries2 = new List<Microcharts.ChartEntry>();
                foreach (var drive in DriversAndPositions)
                {
                    if (drive.name == Driver1.LastName)
                    {
                        foreach (var result in drive.races)
                        {
                            if (result != null && result != "0")
                            {
                                entries.Add(
                                new ChartEntry(20 - float.Parse(result))
                                {
                                    Color = SKColor.Parse(ChangeBackroundColorDrivers(driver1))
                                }
                                );
                            }
                          
                        }
                    }
                    if (drive.name == Driver2.LastName)
                    {
                        foreach (var result in drive.races)
                            if (result != null && result != "0")
                            {
                                entries2.Add(
                                new ChartEntry(20 - float.Parse(result))
                                {
                                    Color = SKColor.Parse(ChangeBackroundColorDrivers(driver2))
                                }
                                );
                            }
                    }
                }
                ChartView.Chart = new LineChart()
                {
                    Entries = entries,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Black,
                    ValueLabelOrientation = Orientation.Horizontal,
                    LabelOrientation = Orientation.Horizontal
                };
                ChartView.Chart.MaxValue = 20;
                ChartView.Chart.MinValue = 0;
                ChartView1.Chart = new LineChart()
                {
                    Entries = entries2,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Empty,
                    ValueLabelOrientation = Orientation.Horizontal,
                    LabelOrientation = Orientation.Horizontal
                };
                ChartView1.Chart.MaxValue = 20;
                ChartView1.Chart.MinValue = 0;
            }
            else if (mode == "Positions in Qualifiyng")
            {
                List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>();
                List<Microcharts.ChartEntry> entries2 = new List<Microcharts.ChartEntry>();
                foreach (var drive in DriversAndQualifyingPosition)
                {
                    if (drive.name == Driver1.LastName)
                    {
                        foreach (var result in drive.races)
                        {
                            if (result != null && result != "0")
                            {
                                entries.Add(
                                new ChartEntry(20 - float.Parse(result))
                                {
                                    Color = SKColor.Parse(ChangeBackroundColorDrivers(driver1))
                                }
                                );
                            }
                        }
                    }
                    if (drive.name == Driver2.LastName)
                    {
                        foreach (var result in drive.races)
                            if (result != null && result != "0")
                            {
                                entries2.Add(
                                new ChartEntry(20 - float.Parse(result))
                                {
                                    Color = SKColor.Parse(ChangeBackroundColorDrivers(driver2))
                                }
                                );
                            }
                    }
                }
                ChartView.Chart = new LineChart()
                {
                    Entries = entries,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Black,
                    ValueLabelOrientation = Orientation.Horizontal,
                    LabelOrientation = Orientation.Horizontal

                };
                ChartView.Chart.MaxValue = 20;
                ChartView.Chart.MinValue = 0;
                ChartView1.Chart = new LineChart()
                {
                    Entries = entries2,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Empty,
                    ValueLabelOrientation = Orientation.Horizontal,
                    LabelOrientation = Orientation.Horizontal
                };
                ChartView1.Chart.MaxValue = 20;
                ChartView1.Chart.MinValue = 0;
            }
            else if (mode == "Points Evolution")
            {
                List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>();
                List<Microcharts.ChartEntry> entries2 = new List<Microcharts.ChartEntry>();
                int points1 = 0;
                int points2 = 0;
                int index1 = -1;
                int index2 = -1;
                foreach (var drive in DriversAndPositions)
                {
                    if (drive.name == Driver1.LastName)
                    {
                        entries.Add(
                        new ChartEntry(points1)
                        {
                            Color = SKColor.Parse(ChangeBackroundColorDrivers(driver1))
                        }
                        );
                        foreach (var result in drive.races)
                        {
                            if (result != null && result != "0")
                            {
                                switch (result)
                                {
                                    case "1":
                                        points1 += 25; break;
                                    case "2":
                                        points1 += 18; break;
                                    case "3":
                                        points1 += 15; break;
                                    case "4":
                                        points1 += 12; break;
                                    case "5":
                                        points1 += 10; break;
                                    case "6":
                                        points1 += 8; break;
                                    case "7":
                                        points1 += 6; break;
                                    case "8":
                                        points1 += 4; break;
                                    case "9":
                                        points1 += 2; break;
                                    case "10":
                                        points1 += 1; break;
                                }
                                index1++;
                                if (drive.fastestlap[index1] == Driver1.No)
                                    points1 += 1;
                                if (drive.sprintraces[index1] != "0")
                                {
                                    switch (drive.sprintraces[index1])
                                    {
                                        case "1":
                                            points1 += 8; break;
                                        case "2":
                                            points1 += 7; break;
                                        case "3":
                                            points1 += 6; break;
                                        case "4":
                                            points1 += 5; break;
                                        case "5":
                                            points1 += 4; break;
                                        case "6":
                                            points1 += 3; break;
                                        case "7":
                                            points1 += 2; break;
                                        case "8":
                                            points1 += 1; break;
                                    }
                                }
                                entries.Add(
                                new ChartEntry(points1)
                                {
                                    Color = SKColor.Parse(ChangeBackroundColorDrivers(driver1))
                                }
                                );
                            }
                            if (index1 == 0 && drive.name == "Sainz")
                            {
                                index1++;
                                points1 += 0;
                                entries.Add(
                                new ChartEntry(points1)
                                {
                                    Color = SKColor.Parse(ChangeBackroundColorDrivers(driver1))
                                }
                                );
                            }
                        }
                    }
                    if (drive.name == Driver2.LastName)
                    {
                        entries2.Add(
                        new ChartEntry(0)
                        {
                            Color = SKColor.Parse(ChangeBackroundColorDrivers(driver2))
                        }
                        );
                        foreach (var result in drive.races)
                        {
                            if (result != null && result != "0")
                            {
                                switch (result)
                                {
                                    case "1":
                                        points2 += 25; break;
                                    case "2":
                                        points2 += 18; break;
                                    case "3":
                                        points2 += 15; break;
                                    case "4":
                                        points2 += 12; break;
                                    case "5":
                                        points2 += 10; break;
                                    case "6":
                                        points2 += 8; break;
                                    case "7":
                                        points2 += 6; break;
                                    case "8":
                                        points2 += 4; break;
                                    case "9":
                                        points2 += 2; break;
                                    case "10":
                                        points2 += 1; break;
                                }
                                index2++;
                                if (drive.fastestlap[index2] == Driver2.No)
                                    points2 += 1;
                                if (drive.sprintraces[index2] != "0")
                                {
                                    switch (drive.sprintraces[index2])
                                    {
                                        case "1":
                                            points2 += 8; break;
                                        case "2":
                                            points2 += 7; break;
                                        case "3":
                                            points2 += 6; break;
                                        case "4":
                                            points2 += 5; break;
                                        case "5":
                                            points2 += 4; break;
                                        case "6":
                                            points2 += 3; break;
                                        case "7":
                                            points2 += 2; break;
                                        case "8":
                                            points2 += 1; break;
                                    }
                                }
                                entries2.Add(
                                new ChartEntry(points2)
                                {
                                    Color = SKColor.Parse(ChangeBackroundColorDrivers(driver2))
                                }
                                );
                            }
                            if (index2 == 0 && drive.name == "Sainz")
                            {
                                index2++;
                                points2 += 0;
                                entries2.Add(
                                new ChartEntry(points2)
                                {
                                    Color = SKColor.Parse(ChangeBackroundColorDrivers(driver2))
                                }
                                );
                            }
                        }
                    }
                }
                ChartView.Chart = new LineChart()
                {
                    Entries = entries,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Black,
                    ValueLabelOrientation = Orientation.Horizontal,
                    LabelOrientation = Orientation.Horizontal,
                    LineMode = LineMode.Straight
                };
                ChartView1.Chart = new LineChart()
                {
                    Entries = entries2,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Empty,
                    ValueLabelOrientation = Orientation.Horizontal,
                    LabelOrientation = Orientation.Horizontal,
                    LineMode = LineMode.Straight
                };
                if (points2 > points1)
                {
                    ChartView.Chart.MaxValue = points2;
                    ChartView1.Chart.MaxValue = points2;
                }
                else
                {
                    ChartView.Chart.MaxValue = points1;
                    ChartView1.Chart.MaxValue = points1;
                }
                ChartView.Chart.MinValue = 0;
                ChartView1.Chart.MinValue = 0;
            }
        }

        private async Task ModifiyChartTeams(string team1, string team2, string mode)
        {
            if (mode == "Points %")
            {
                float total = float.Parse(Team1.Points) + float.Parse(Team2.Points);
                float per1 = float.Parse(Team1.Points) * 100 / total;
                var per2 = 100 - per1;
                List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>()
                {
                    new ChartEntry(float.Parse(Team2.Points))
                    {
                        ValueLabel = Team2.Team,
                        Label = Team2.Points+ "PTS " + String.Format("{0:0.00}", per2)+"%",
                        ValueLabelColor = SKColor.Parse(ChangeBackroundColorTeams(team2)),
                        Color = SKColor.Parse(ChangeBackroundColorTeams(team2))
                    },
                    new ChartEntry(float.Parse(Team1.Points))
                    {
                        ValueLabel = Team1.Team,
                        Label = Team1.Points+ "PTS " + String.Format("{0:0.00}", per1)+"%",
                        ValueLabelColor = SKColor.Parse(ChangeBackroundColorTeams(team1)),
                        Color = SKColor.Parse(ChangeBackroundColorTeams(team1))
                    }
                };
                ChartView.Chart = new DonutChart()
                {
                    Entries = entries,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Black,
                };
                ChartView1.Chart = null;
            }
            else if (mode == "Points Evolution")
            {
                List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>();
                List<Microcharts.ChartEntry> entries2 = new List<Microcharts.ChartEntry>();
                int points1 = 0;
                int points2 = 0;
                int now1 = 0;
                int now2 = 0;
                int raceno1 = 0;
                int raceno2 = 0;
                int sprintraceno1 = 0;
                int sprintraceno2 = 0;
                int index1 = -1;
                int index2 = -1;

                foreach (var team in TeamsPage.TeamsSortedList)
                {
                    if (team.Team == team1)
                    {
                        entries.Add(
                        new ChartEntry(0)
                        {
                            Color = SKColor.Parse(ChangeBackroundColorTeams(team.Team))
                        }
                        );
                        while (raceno1 != SchedulePage.CompletedRace)
                        {
                            foreach (var driver in DriversAndPositions)
                            {
                                if (driver.name == team.Driver1 || driver.name == team.Driver2)
                                {
                                    if (driver.races[raceno1] != null && driver.races[raceno1] != "0")
                                    {
                                        switch (driver.races[raceno1])
                                        {
                                            case "1":
                                                points1 += 25; break;
                                            case "2":
                                                points1 += 18; break;
                                            case "3":
                                                points1 += 15; break;
                                            case "4":
                                                points1 += 12; break;
                                            case "5":
                                                points1 += 10; break;
                                            case "6":
                                                points1 += 8; break;
                                            case "7":
                                                points1 += 6; break;
                                            case "8":
                                                points1 += 4; break;
                                            case "9":
                                                points1 += 2; break;
                                            case "10":
                                                points1 += 1; break;
                                        }
                                        index1++;
                                        if (driver.name == "Sainz" && index1 == 3)
                                            points1 += 6;
                                        if (driver.fastestlap[index1] == team.Driver1)
                                            points1 += 1;
                                        if (driver.fastestlap[index1] == team.Driver2)
                                            points1 += 1;
                                        switch (driver.sprintraces[raceno1])
                                        {
                                            case "1":
                                                points1 += 8; break;
                                            case "2":
                                                points1 += 7; break;
                                            case "3":
                                                points1 += 6; break;
                                            case "4":
                                                points1 += 5; break;
                                            case "5":
                                                points1 += 4; break;
                                            case "6":
                                                points1 += 3; break;
                                            case "7":
                                                points1 += 2; break;
                                            case "8":
                                                points1 += 1; break;
                                            default: break;
                                        }
                                        if (now1 == 0)
                                            now1 = 1;
                                        else
                                        {
                                            now1 = 0;
                                            entries.Add(
                                           new ChartEntry(points1)
                                           {
                                               Color = SKColor.Parse(ChangeBackroundColorTeams(team.Team))
                                           }
                                           );
                                            raceno1++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                foreach (var team in TeamsPage.TeamsSortedList)
                {
                    if (team.Team == team2)
                    {
                        entries2.Add(
                        new ChartEntry(0)
                        {
                            Color = SKColor.Parse(ChangeBackroundColorTeams(team.Team))
                        }
                        );
                        while (raceno2 != SchedulePage.CompletedRace)
                        {
                            foreach (var driver in DriversAndPositions)
                            {
                                if (driver.name == team.Driver1 || driver.name == team.Driver2)
                                {
                                    if (driver.races[raceno2] != null && driver.races[raceno2] != "0")
                                    {
                                        switch (driver.races[raceno2])
                                        {
                                            case "1":
                                                points2 += 25; break;
                                            case "2":
                                                points2 += 18; break;
                                            case "3":
                                                points2 += 15; break;
                                            case "4":
                                                points2 += 12; break;
                                            case "5":
                                                points2 += 10; break;
                                            case "6":
                                                points2 += 8; break;
                                            case "7":
                                                points2 += 6; break;
                                            case "8":
                                                points2 += 4; break;
                                            case "9":
                                                points2 += 2; break;
                                            case "10":
                                                points2 += 1; break;
                                        }
                                        index2++;
                                        if (driver.name == "Sainz" && index2 == 1)
                                            points1 += 6;
                                        if (driver.fastestlap[index2] == team.Driver1)
                                            points2 += 1;
                                        if (driver.fastestlap[index2] == team.Driver2)
                                            points2 += 1;
                                        switch (driver.sprintraces[raceno2])
                                        {
                                            case "1":
                                                points2 += 8; break;
                                            case "2":
                                                points2 += 7; break;
                                            case "3":
                                                points2 += 6; break;
                                            case "4":
                                                points2 += 5; break;
                                            case "5":
                                                points2 += 4; break;
                                            case "6":
                                                points2 += 3; break;
                                            case "7":
                                                points2 += 2; break;
                                            case "8":
                                                points2 += 1; break;
                                            default: break;
                                        }
                                        if (now1 == 0)
                                            now1 = 1;
                                        else
                                        {
                                            now1 = 0;
                                            entries2.Add(
                                           new ChartEntry(points2)
                                           {
                                               Color = SKColor.Parse(ChangeBackroundColorTeams(team.Team))
                                           }
                                           );
                                            raceno2++;
                                        }
                                    }
                                }
                            }
                        }
                    }          
                }
                ChartView.Chart = new LineChart()
                {
                    Entries = entries,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Black,
                    ValueLabelOrientation = Orientation.Horizontal,
                    LabelOrientation = Orientation.Horizontal,
                    LineMode = LineMode.Straight
                };
                ChartView1.Chart = new LineChart()
                {
                    Entries = entries2,
                    LabelTextSize = 30,
                    AnimationDuration = TimeSpan.FromSeconds(2),
                    BackgroundColor = SKColors.Empty,
                    ValueLabelOrientation = Orientation.Horizontal,
                    LabelOrientation = Orientation.Horizontal,
                    LineMode = LineMode.Straight
                };
                if (points2 > points1)
                {
                    ChartView.Chart.MaxValue = points2;
                    ChartView1.Chart.MaxValue = points2;
                }
                else
                {
                    ChartView.Chart.MaxValue = points1;
                    ChartView1.Chart.MaxValue = points1;
                }
                ChartView.Chart.MinValue = 0;
                ChartView1.Chart.MinValue = 0;
            }
        }

        private string ChangeBackroundColorDrivers(string Driver)
        {
            switch (Driver)
            {
                case "Bottas":
                    return "#52E252";
                case "Zhou":
                    return "#35C135";
                case "Tsunoda":
                    return "#5E8FAA";
                case "Ricciardo":
                    return "#6BB4AA";
                case "Gasly":
                    return "#FF87BC";
                case "Ocon":
                    return "#EB4D93";
                case "Alonso":
                    return "#358C75";
                case "Stroll":
                    return "#35AD75";
                case "Leclerc":
                    return "#F91536";
                case "Sainz":
                    return "#f95D4D";
                case "Hulkenberg":
                    return "#B6BABD";
                case "Magnussen":
                    return "#D2C7A5";
                case "Norris":
                    return "#F58020";
                case "Piastri":
                    return "#F5B42E";
                case "Hamilton":
                    return "#6CD3BF";
                case "Russell":
                    return "#1AE2D9";
                case "Verstappen":
                    return "#3671C6";
                case "Perez":
                    return "#367EA3";
                case "Albon":
                    return "#37BEDD";
                case "Sargeant":
                    return "#77A6E0";
                default:
                    return "#FFFFFF";
            }
        }

        private string ChangeBackroundColorTeams(string Team)
        {
            switch (Team)
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

        private void GetPosition()
        {
            int nocircuit;
            int posdriver = -1;
            List<DriverModel> Drivers = DriversPage.DriversSortedList;
            List<CircuitModel> Circuits = SchedulePage.CircuitsSortedList;

            foreach (DriverModel Driver in Drivers)
            {
                //DriversAndPositions[posdriver].name = Driver.LastName;
                string[] races = new string[24];
                string[] sprintraces = new string[24];
                for (var pos = 0; pos < 24; pos++)
                    sprintraces[pos] = "0";
                string[] fastestlap = new string[24];
                posdriver++;
                nocircuit = -1;
                foreach (CircuitModel Circ in Circuits)
                {
                    nocircuit++;
                    if (Driver.No == Circ.Place1)
                    {
                        races[nocircuit] = "1";
                    }
                    else if (Driver.No == Circ.Place2)
                    {
                        races[nocircuit] = "2";
                    }
                    else if (Driver.No == Circ.Place3)
                    {
                        races[nocircuit] = "3";
                    }
                    else if (Driver.No == Circ.Place4)
                    {
                        races[nocircuit] = "4";
                    }
                    else if (Driver.No == Circ.Place5)
                    {
                        races[nocircuit] = "5";
                    }
                    else if (Driver.No == Circ.Place6)
                    {
                        races[nocircuit] = "6";
                    }
                    else if (Driver.No == Circ.Place7)
                    {
                        races[nocircuit] = "7";
                    }
                    else if (Driver.No == Circ.Place8)
                    {
                        races[nocircuit] = "8";
                    }
                    else if (Driver.No == Circ.Place9)
                    {
                        races[nocircuit] = "9";
                    }
                    else if (Driver.No == Circ.Place10)
                    {
                        races[nocircuit] = "10";
                    }
                    else if (Driver.No == Circ.Place11)
                    {
                        races[nocircuit] = "11";
                    }
                    else if (Driver.No == Circ.Place12)
                    {
                        races[nocircuit] = "12";
                    }
                    else if (Driver.No == Circ.Place13)
                    {
                        races[nocircuit] = "13";
                    }
                    else if (Driver.No == Circ.Place14)
                    {
                        races[nocircuit] = "14";
                    }
                    else if (Driver.No == Circ.Place15)
                    {
                        races[nocircuit] = "15";
                    }
                    else if (Driver.No == Circ.Place16)
                    {
                        races[nocircuit] = "16";
                    }
                    else if (Driver.No == Circ.Place17)
                    {
                        races[nocircuit] = "17";
                    }
                    else if (Driver.No == Circ.Place18)
                    {
                        races[nocircuit] = "18";
                    }
                    else if (Driver.No == Circ.Place19)
                    {
                        races[nocircuit] = "19";
                    }
                    else if (Driver.No == Circ.Place20)
                    {
                        races[nocircuit] = "20";
                    }
                    else
                        races[nocircuit] = "0";
                    fastestlap[nocircuit] = Circ.FastestLap;

                    //Sprint
                    if (Circ.SprintRace == "1")
                    {
                        if (Driver.No == Circ.Sprint1)
                        {
                            sprintraces[nocircuit] = "1";
                        }
                        else if (Driver.No == Circ.Sprint2)
                        {
                            sprintraces[nocircuit] = "2";
                        }
                        else if (Driver.No == Circ.Sprint3)
                        {
                            sprintraces[nocircuit] = "3";
                        }
                        else if (Driver.No == Circ.Sprint4)
                        {
                            sprintraces[nocircuit] = "4";
                        }
                        else if (Driver.No == Circ.Sprint5)
                        {
                            sprintraces[nocircuit] = "5";
                        }
                        else if (Driver.No == Circ.Sprint6)
                        {
                            sprintraces[nocircuit] = "6";
                        }
                        else if (Driver.No == Circ.Sprint7)
                        {
                            sprintraces[nocircuit] = "7";
                        }
                        else if (Driver.No == Circ.Sprint8)
                        {
                            sprintraces[nocircuit] = "8";
                        }
                        else
                        {
                            sprintraces[nocircuit] = "0";
                        }
                    }
                    else
                        sprintraces[nocircuit] = "0";
                    
                }
                var DriverAndPos = new DriversAndPositions(Driver.LastName, races,sprintraces, fastestlap);
                DriversAndPositions.Add(DriverAndPos);
            }
        }

        private void GetQualifyingPosition()
        {
            int nocircuit;
            int posdriver = -1;
            List<DriverModel> Drivers = DriversPage.DriversSortedList;
            List<CircuitModel> Circuits = SchedulePage.CircuitsSortedList;

            foreach (DriverModel Driver in Drivers)
            {
                //DriversAndPositions[posdriver].name = Driver.LastName;
                string[] races = new string[24];
                posdriver++;
                nocircuit = -1;
                foreach (CircuitModel Circ in Circuits)
                {
                    nocircuit++;
                    if (Driver.No == Circ.Qualifying1)
                    {
                        races[nocircuit] = "1";
                    }
                    else if (Driver.No == Circ.Qualifying2)
                    {
                        races[nocircuit] = "2";
                    }
                    else if (Driver.No == Circ.Qualifying3)
                    {
                        races[nocircuit] = "3";
                    }
                    else if (Driver.No == Circ.Qualifying4)
                    {
                        races[nocircuit] = "4";
                    }
                    else if (Driver.No == Circ.Qualifying5)
                    {
                        races[nocircuit] = "5";
                    }
                    else if (Driver.No == Circ.Qualifying6)
                    {
                        races[nocircuit] = "6";
                    }
                    else if (Driver.No == Circ.Qualifying7)
                    {
                        races[nocircuit] = "7";
                    }
                    else if (Driver.No == Circ.Qualifying8)
                    {
                        races[nocircuit] = "8";
                    }
                    else if (Driver.No == Circ.Qualifying9)
                    {
                        races[nocircuit] = "9";
                    }
                    else if (Driver.No == Circ.Qualifying10)
                    {
                        races[nocircuit] = "10";
                    }
                    else if (Driver.No == Circ.Qualifying11)
                    {
                        races[nocircuit] = "11";
                    }
                    else if (Driver.No == Circ.Qualifying12)
                    {
                        races[nocircuit] = "12";
                    }
                    else if (Driver.No == Circ.Qualifying13)
                    {
                        races[nocircuit] = "13";
                    }
                    else if (Driver.No == Circ.Qualifying14)
                    {
                        races[nocircuit] = "14";
                    }
                    else if (Driver.No == Circ.Qualifying15)
                    {
                        races[nocircuit] = "15";
                    }
                    else if (Driver.No == Circ.Qualifying16)
                    {
                        races[nocircuit] = "16";
                    }
                    else if (Driver.No == Circ.Qualifying17)
                    {
                        races[nocircuit] = "17";
                    }
                    else if (Driver.No == Circ.Qualifying18)
                    {
                        races[nocircuit] = "18";
                    }
                    else if (Driver.No == Circ.Qualifying19)
                    {
                        races[nocircuit] = "19";
                    }
                    else if (Driver.No == Circ.Qualifying20)
                    {
                        races[nocircuit] = "20";
                    }
                    else
                        races[nocircuit] = "0";
                }
                var DriverAndPos = new DriversAndQualifyingPosition(Driver.LastName, races);
                DriversAndQualifyingPosition.Add(DriverAndPos);
            }
        }

    }
}
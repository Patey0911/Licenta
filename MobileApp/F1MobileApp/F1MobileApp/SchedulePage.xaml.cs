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
using System.Text.RegularExpressions;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace F1MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulePage : ContentPage
    {
        public static int CompletedRace;
        public static List<CircuitModel> CircuitsSortedList;
        public SchedulePage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            CompletedRace = 0;
            int index = -1, index_sing;
            this.BackgroundColor = Color.FromHex("#FFFFFF");
            var CircuitsList = await CircuitRepository.GetAllCircuits();

            //Calculate Date of GP
            foreach(CircuitModel c in CircuitsList)
            {
                string NoMonth = ReturnMonth(c.Date);
                string resultString = Regex.Match(c.Date, @"\d+").Value;

                if (NoMonth.Length !=2)
                {
                    NoMonth = "0" + NoMonth;
                }

                if (resultString.Length!=2) 
                {
                    resultString = "0" + resultString;
                }

                DateTime DateGp;
                DateTime.TryParseExact(resultString + "/" + NoMonth + "/2024", "dd/MM/yyyy", null, DateTimeStyles.None, out DateGp);

                c.DateGP=DateGp;
            }

            CircuitsSortedList = CircuitsList.OrderBy(o => o.DateGP).ToList();


            foreach (var Driver in CircuitsSortedList)
            {
                index++;
                switch(index)
                {
                    case 0:
                        Image1.Source = CircuitsSortedList[index].CircuitName.Replace("-","_") + "Flag.png";
                        string modifiedcircuit  = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label1.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate1.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 1:
                        Image2.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label2.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate2.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 2:
                        Image3.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label3.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate3.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 3:
                        Image4.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label4.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate4.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 4:
                        Image5.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label5.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate5.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 5:
                        Image6.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label6.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate6.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 6:
                        Image7.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label7.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate7.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 7:
                        Image8.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label8.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate8.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 8:
                        Image9.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label9.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate9.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 9:
                        Image10.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label10.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate10.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 10:
                        Image11.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label11.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate11.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 11:
                        Image12.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label12.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate12.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 12:
                        Image13.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label13.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate13.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 13:
                        Image14.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label14.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate14.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 14:
                        Image15.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label15.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate15.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 15:
                        Image16.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label16.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate16.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 16:
                        Image17.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label17.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate17.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 17:
                        Image18.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label18.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate18.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 18:
                        Image19.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label19.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate19.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 19:
                        Image20.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label20.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate20.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 20:
                        Image21.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label21.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate21.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 21:
                        Image22.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label22.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate22.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 22:
                        Image23.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label23.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate23.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    case 23:
                        Image24.Source = CircuitsSortedList[index].CircuitName.Replace("-", "_") + "Flag.png";
                        modifiedcircuit = CircuitsSortedList[index].CircuitName.Replace("_", "-");
                        if (modifiedcircuit.Contains("-"))
                        {
                            index_sing = modifiedcircuit.IndexOf("-") + 1;
                            char[] CharCircuits = modifiedcircuit.ToCharArray();
                            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
                            modifiedcircuit = new string(CharCircuits);
                        }
                        Label24.Text = char.ToUpper(modifiedcircuit[0]) + modifiedcircuit.Substring(1);
                        LabelDate24.Text = CircuitsSortedList[index].Date;
                        if (CircuitsSortedList[index].FutureRace == "0")
                            CompletedRace++;
                        break;
                    default:
                        break;
                }
            }
        }

        private string ReturnMonth(string month)
        {
            string NoMonth;
            if (month.Contains("Mar"))
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
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[0].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[1].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[2].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[3].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[4].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[5].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[6].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[7].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[8].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[9].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_10(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[10].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_11(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[11].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_12(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[12].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_13(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[13].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_14(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[14].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_15(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[15].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_16(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[16].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_17(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[17].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_18(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[18].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_19(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[19].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_20(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[20].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_21(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[21].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_22(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[22].CircuitName));
        }

        private async void TapGestureRecognizer_Tapped_23(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuit(CircuitsSortedList[23].CircuitName));
        }
    }
}
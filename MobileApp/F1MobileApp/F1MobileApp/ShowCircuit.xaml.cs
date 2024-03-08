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

namespace F1MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowCircuit : ContentPage
    {
        CircuitModel circuit;
        public string circuitname;
        public ShowCircuit(string circuitname)
        {
            InitializeComponent();
            this.circuitname = circuitname;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            circuit = await CircuitRepository.GetByName(circuitname);

            ImageCircuit.Source = circuitname.Replace("-", "_") + ".png";

            circuitname = circuitname.Replace("-", " ");
            circuitname = circuitname.Replace("_", " ");
            var index = circuitname.IndexOf(' ') + 1;
            var circ = circuitname.Substring(0, index) + char.ToUpper(circuitname[index]) + circuitname.Substring(index + 1, circuitname.Length - index - 1);
            var circuitString = circ.ToString();
            circuitString = char.ToUpper(circuitString[0]) + circuitString.Substring(1);

            Label01.Text = circuit.CircuitLength.ToString();
            Label11.Text = circuit.NoLaps.ToString();
            Label21.Text = circuit.FirstGP.ToString();
            Label31.Text = circuit.RaceDistance.ToString();
            Label41.Text = circuit.LapRecord.ToString();

            circuit.CircuitName = circuit.CircuitName.Replace("_", "-");
            var index_sing = circuit.CircuitName.IndexOf("-") + 1;
            char[] CharCircuits = circuit.CircuitName.ToCharArray();
            CharCircuits[index_sing] = char.ToUpper(CharCircuits[index_sing]);
            circuit.CircuitName = new string(CharCircuits);
            LabelTitle.Text = char.ToUpper(circuit.CircuitName[0]) + circuit.CircuitName.Substring(1);

            if (circuit.Place1 == "" || !char.IsDigit(circuit.Place1[0]))
            {
                ResultsBtn.IsEnabled = false;
            }

            if(circuit.Qualifying1 == "")
            {
                ResultQualiBtn.IsEnabled = false;
            }

            if (circuit.Sprint1 == "" || circuit.SprintRace == "0")
            {
                ResultsSprintBtn.IsEnabled = false;
            }

            if (circuit.SprintQualifying5 == "" || circuit.SprintRace == "0")
            {
                ResultSprintQualiBtn.IsEnabled = false;
            }
        }

        private async void InfoBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowCircuitInfo(circuitname));
        }

        private async void ResultsBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowResults(circuitname));
        }

        private async void ResultsSprintBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowSprintResults(circuitname));
        }

        private async void QualiBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowQualifyingResults(circuitname));
        }

        private async void ResultSprintQualiBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ShowSprintQualifyingResults(circuitname));
        }
    }
}
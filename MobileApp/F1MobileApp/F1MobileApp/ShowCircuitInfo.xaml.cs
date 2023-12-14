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
    public partial class ShowCircuitInfo : ContentPage
    {
        public string circuit;
        public ShowCircuitInfo(string circuit)
        {
            InitializeComponent();
            this.circuit = circuit;
        }
        protected override async void OnAppearing()
        {
            

            var Circuit = await CircuitRepository.GetByName(circuit);

            ImageCircuit.Source = circuit.Replace("-","_") + ".png";

            Label01.Text = Circuit.CircuitLength.ToString();
            Label11.Text = Circuit.NoLaps.ToString();
            Label21.Text = Circuit.FirstGP.ToString();
            Label31.Text = Circuit.RaceDistance.ToString();
            Label41.Text = Circuit.LapRecord.ToString();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace F1MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public static List<DriverModel> DriversList;
        public MainPage(UserModel user)
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            DriversList = await DriverRepository.GetAllDrivers();
        }

        
    }
}
using F1MobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace F1MobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
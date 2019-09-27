using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Example17 : ContentPage
    {
        public Example17()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((BaseViewModel)BindingContext).LoadData = true;
        }
    }
}
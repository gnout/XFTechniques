using Etude.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Etude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Example12 : ContentPage
    {
        public Example12()
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
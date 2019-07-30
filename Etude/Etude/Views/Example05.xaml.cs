using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Etude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Example05 : ContentPage
    {
        public Example05()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            stackLayout.Opacity = 0.1;
            stackLayout.FadeTo(1, 750, Easing.CubicIn);
        }
    }
}
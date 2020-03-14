using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set04Example01 : ContentPage
    {
        public Set04Example01()
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
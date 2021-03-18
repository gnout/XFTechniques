using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set04Example03 : ContentPage
    {
        public Set04Example03()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            stackLayout.AnchorX = 0;
            stackLayout.RotationY = 180;
            await stackLayout.RotateYTo(0, 1000, Easing.CubicOut);
            stackLayout.AnchorX = 0.5;
        }
    }
}
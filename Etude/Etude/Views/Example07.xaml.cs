using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Etude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Example07 : ContentPage
    {
        public Example07()
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
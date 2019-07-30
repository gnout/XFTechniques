using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Etude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Example06 : ContentPage
    {
        public Example06()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            double offset = 1000;

            foreach (View view in stackLayout.Children)
            {
                view.TranslationX = offset;
                offset *= -1;
            }

            foreach (View view in stackLayout.Children)
            {
                await Task.WhenAny(view.TranslateTo(0, 0, 1000, Easing.SpringOut), Task.Delay(100));
            }
        }
    }
}
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Etude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Example08 : ContentPage
    {
        uint animationSpeed = 600;
        int delay = 160;

        public Example08()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            double offset = -600;

            Editors.TranslationY = offset;
            buttonSubmit.TranslationY = offset;
            buttonFacebook.TranslationY = offset;
            CreatedBy.TranslationY = offset;

            await Task.WhenAny(Editors.TranslateTo(0, 0, animationSpeed, Easing.SinOut), Task.Delay(delay));
            await Task.WhenAny(buttonSubmit.TranslateTo(0, 0, animationSpeed, Easing.SinOut), Task.Delay(delay));
            await Task.WhenAny(buttonFacebook.TranslateTo(0, 0, animationSpeed, Easing.SinOut), Task.Delay(delay));
            await CreatedBy.TranslateTo(0, 0, animationSpeed, Easing.SinOut);
        }
    }
}
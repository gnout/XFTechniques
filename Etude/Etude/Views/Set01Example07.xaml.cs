using Etude.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Etude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Set01Example07 : ContentPage
    {
        public Set01Example07()
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
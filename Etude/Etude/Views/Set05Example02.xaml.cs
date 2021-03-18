using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set05Example02 : ContentPage
    {
        public Set05Example02()
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
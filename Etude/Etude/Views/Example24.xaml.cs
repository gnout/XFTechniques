using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Example24 : ContentPage
    {
        public Example24()
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
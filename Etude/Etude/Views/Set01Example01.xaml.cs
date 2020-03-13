using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set01Example01 : ContentPage
    {
        public Set01Example01()
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
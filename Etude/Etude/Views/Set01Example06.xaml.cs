using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set01Example06 : ContentPage
    {
        public Set01Example06()
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
using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Example03 : ContentPage
    {
        public Example03()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            ((BaseViewModel)BindingContext).LoadData = true;
        }
    }
}
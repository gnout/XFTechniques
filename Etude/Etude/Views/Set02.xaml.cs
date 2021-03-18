using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set02 : ContentPage
    {
        public Set02()
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
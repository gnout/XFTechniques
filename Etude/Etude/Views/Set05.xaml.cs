using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set05 : ContentPage
    {
        public Set05()
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
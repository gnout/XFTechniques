using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set06 : ContentPage
    {
        public Set06()
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
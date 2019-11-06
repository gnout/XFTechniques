using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set08 : ContentPage
    {
        public Set08()
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
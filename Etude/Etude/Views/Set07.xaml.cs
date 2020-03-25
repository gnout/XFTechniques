using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set07 : ContentPage
    {
        public Set07()
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
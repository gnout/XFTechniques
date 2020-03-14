using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set03 : ContentPage
    {
        public Set03()
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
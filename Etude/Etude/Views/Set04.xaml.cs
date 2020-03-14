using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set04 : ContentPage
    {
        public Set04()
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
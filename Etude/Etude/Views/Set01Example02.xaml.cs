
using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set01Example02 : ContentPage
    {
        public Set01Example02()
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
using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set01Example05 : ContentPage
    {
        public Set01Example05()
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
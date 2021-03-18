using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set01Example03 : ContentPage
    {
        public Set01Example03()
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
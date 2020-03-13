using Etude.ViewModels;
using Xamarin.Forms;

namespace Etude.Views
{
    public partial class Set01 : ContentPage
    {
        public Set01()
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
using Etude.Models;

namespace Etude.ViewModels
{
    public class Set07Example01ViewModel : BaseViewModel
    {
        public Beer Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private Beer _model = new Beer
        {
            Alcohol = 12.6F,
            Price = 5.3M
        };
        #endregion

        public Set07Example01ViewModel()
        {
        }
    }
}

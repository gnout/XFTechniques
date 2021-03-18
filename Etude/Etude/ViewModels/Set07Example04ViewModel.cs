namespace Etude.ViewModels
{
    public class Set07Example04ViewModel : BaseViewModel
    {
        public decimal Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public string CurrencyCode
        {
            get => _currencyCode;
            set => SetProperty(ref _currencyCode, value);
        }

        #region Backing Property Fields
        private decimal _price = 147.56M;
        private string _currencyCode = "EUR";
        #endregion
    }
}

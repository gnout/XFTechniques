namespace Etude.ViewModels
{
    public class Example01ViewModel : BaseViewModel
    {
        public string Fullname
        {
            get { return _fullname; }
            set { SetProperty(ref _fullname, value); }
        }

        public string UnitPrice
        {
            get { return _unitPrice; }
            set { SetProperty(ref _unitPrice, value); }
        }

        #region Private Variables
        private string _fullname = string.Empty;
        private string _unitPrice = string.Empty;
        #endregion

        public Example01ViewModel()
        {

        }
    }
}

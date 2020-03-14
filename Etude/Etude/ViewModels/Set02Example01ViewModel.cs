using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set02Example01ViewModel : BaseViewModel
    {
        public bool DialogIsVisible
        {
            get => _dialogIsVisible;
            set => SetProperty(ref _dialogIsVisible, value);
        }

        #region Backing Properties
        private bool _dialogIsVisible = false;
        #endregion

        #region Delegate Commands
        public ICommand ShowDialogCommand { get; }
        public ICommand HideDialogCommand { get; }
        #endregion

        public Set02Example01ViewModel()
        {
            ShowDialogCommand = new Command(ShowDialogExecute);
            HideDialogCommand = new Command(HideDialogExecute);
        }

        private void ShowDialogExecute()
        {
            DialogIsVisible = true;
        }

        private void HideDialogExecute()
        {
            DialogIsVisible = false;
        }
    }
}

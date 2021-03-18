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
            ShowDialogCommand = new Command(ExecuteShowDialogCommand);
            HideDialogCommand = new Command(ExecuteHideDialogCommand);
        }

        private void ExecuteShowDialogCommand()
        {
            DialogIsVisible = true;
        }

        private void ExecuteHideDialogCommand()
        {
            DialogIsVisible = false;
        }
    }
}

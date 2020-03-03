using Etude.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example23ViewModel : BaseViewModel
    {
        #region Delegate Commands
        public ICommand BaseViewModelCommand { get; }
        public ICommand FodyBaseViewModelCommand { get; }
        #endregion

        private readonly INavigation _navigation;

        public Example23ViewModel()
        {
            _navigation = App.Current.MainPage.Navigation;

            BaseViewModelCommand = new Command(async () => await ExecuteBaseViewModelCommand());
            FodyBaseViewModelCommand = new Command(async () => await ExecuteFodyBaseViewModelCommand());
        }

        private async Task ExecuteBaseViewModelCommand()
        {
            await _navigation.PushAsync(new Example23Sample01());
        }

        private async Task ExecuteFodyBaseViewModelCommand()
        {
            await _navigation.PushAsync(new Example23Sample02());
        }
    }
}

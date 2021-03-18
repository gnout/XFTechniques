using Etude.Models;
using Etude.Services;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set05Example02ViewModel : BaseViewModel
    {
        public ObservableCollection<Beer> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private ObservableCollection<Beer> _model;
        #endregion

        #region Delegate Commands
        public ICommand SelectedItemCommand { get; private set; }
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        public Set05Example02ViewModel()
        {
            LoadDataCommand = new Command(() => Init());
            SelectedItemCommand = new Command<SelectedItemChangedEventArgs>(async (args) => await ExecuteSelectedItemCommand(args));
        }

        private void Init()
        {
            IsBusy = true;

            try
            {
                Model = new ObservableCollection<Beer>(_dataService.GetBeers()
                    .OrderBy(x => x.Name));
            }
            finally { IsBusy = false; }
        }

        private async Task ExecuteSelectedItemCommand(SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem == null)
                return;

            var beer = (Beer)args.SelectedItem;

            await App.Current.MainPage.DisplayAlert($"Beer: {beer?.Name}", "Alert", "OK");
        }
    }
}

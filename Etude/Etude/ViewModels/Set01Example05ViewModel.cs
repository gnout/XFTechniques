using Etude.Models;
using Etude.Services;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set01Example05ViewModel : BaseViewModel
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
        public ICommand EditItemCommand { set; get; }
        public ICommand DeleteItemCommand { set; get; }
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        public Set01Example05ViewModel()
        {
            LoadDataCommand = new Command(() => Init());
            EditItemCommand = new Command<Beer>(async (beer) => await ExecuteEditItemCommandAsync(beer));
            DeleteItemCommand = new Command<Beer>(async (beer) => await ExecuteDeleteItemCommandAsync(beer));
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

        private Task ExecuteEditItemCommandAsync(Beer beer)
        {
            return App.Current.MainPage.DisplayAlert($"Beer: {beer.Name}", "Edit", "OK");
        }

        private Task ExecuteDeleteItemCommandAsync(Beer beer)
        {
            return App.Current.MainPage.DisplayAlert($"Beer: {beer.Name}", "Delete", "OK");
        }
    }
}

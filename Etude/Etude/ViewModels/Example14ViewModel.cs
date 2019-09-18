using Acr.UserDialogs;
using Etude.Models;
using Etude.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example14ViewModel : BaseViewModel
    {
        public ObservableCollection<Band> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private ObservableCollection<Band> _model;
        #endregion

        #region Delegate Commands
        public ICommand EditItemCommand { set; get; }
        public ICommand DeleteItemCommand { set; get; }
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        public Example14ViewModel()
        {
            LoadDataCommand = new Command(async () => await InitAsync());
            EditItemCommand = new Command<Band>(async (band) => await EditItemExecuteAsync(band));
            DeleteItemCommand = new Command<Band>(async (band) => await DeleteItemExecuteAsync(band));
        }

        private Task InitAsync()
        {
            return Task.Run(() =>
            {
                Model = _dataService.GetBands();
            });
        }

        private Task EditItemExecuteAsync(Band band)
        {
            return UserDialogs.Instance.AlertAsync($"Band: {band.Name}", "Edit", "OK");
        }

        private Task DeleteItemExecuteAsync(Band band)
        {
            return UserDialogs.Instance.AlertAsync($"Band: {band.Name}", "Delete", "OK");
        }
    }
}

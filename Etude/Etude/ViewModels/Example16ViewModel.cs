using Etude.Models;
using Etude.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example16ViewModel : BaseViewModel
    {
        public ObservableCollection<Employee> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private ObservableCollection<Employee> _model;
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        public Example16ViewModel()
        {
            LoadDataCommand = new Command(async () => await InitAsync());
        }

        private async Task InitAsync()
        {
            IsBusy = true;

            try
            {
                Model = new ObservableCollection<Employee>(await _dataService.GetApiDataAsync());
            }
            finally { IsBusy = false; }
        }
    }
}

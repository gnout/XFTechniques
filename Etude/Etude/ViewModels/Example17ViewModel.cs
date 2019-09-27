using Etude.Models;
using Etude.Services;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example17ViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private ObservableCollection<Recipe> _model;
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        public Example17ViewModel()
        {
            LoadDataCommand = new Command(async () => await InitAsync());
        }

        private async Task InitAsync()
        {
            IsBusy = true;

            try
            {
                var response = await _dataService.GetApiRecipePuppyAsync();

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Model = new ObservableCollection<Recipe>(response.Recipies);
                });
            }
            finally { IsBusy = false; }
        }
    }
}

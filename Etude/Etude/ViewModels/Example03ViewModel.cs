using Etude.Models;
using Etude.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example03ViewModel : BaseViewModel
    {
        public ObservableCollection<Band> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private ObservableCollection<Band> _model;
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        public Example03ViewModel()
        {
            LoadDataCommand = new Command(async () => await InitAsync());
        }

        private Task InitAsync()
        {
            return Task.Run(() =>
            {
                Model = _dataService.GetBands();
            });
        }
    }
}

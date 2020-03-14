using Etude.Helpers;
using Etude.Models;
using Etude.Services;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set01Example03ViewModel : BaseViewModel
    {
        public ObservableCollection<Grouping<string, Beer>> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private ObservableCollection<Grouping<string, Beer>> _model;
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        public Set01Example03ViewModel()
        {
            LoadDataCommand = new Command(() => Init());
        }

        private void Init()
        {
            IsBusy = true;

            try
            {
                Model = _dataService.GroupBeerList(_dataService.GetBeers().ToList<Beer>());
            }
            finally { IsBusy = false; }
        }
    }
}

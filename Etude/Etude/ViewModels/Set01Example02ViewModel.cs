using Etude.Models;
using Etude.Services;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set01Example02ViewModel : BaseViewModel
    {
        public ObservableCollection<Beer> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private ObservableCollection<Beer> _model;
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        public Set01Example02ViewModel()
        {
            LoadDataCommand = new Command(() => Init());
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
    }
}

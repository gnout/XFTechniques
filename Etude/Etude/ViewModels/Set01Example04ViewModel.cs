using Etude.Helpers;
using Etude.Models;
using Etude.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set01Example04ViewModel : BaseViewModel
    {
        public ObservableCollection<Grouping<string, Beer>> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private ObservableCollection<Grouping<string, Beer>> _model;
        #endregion

        #region Delegate Commands
        public ICommand ExpandCollapseCommand { get; }
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        private ObservableCollection<Grouping<string, Beer>> _staticData;

        public Set01Example04ViewModel()
        {
            ExpandCollapseCommand = new Command<object>(ExecuteExpandCollapseCommand);

            LoadDataCommand = new Command(() => Init());
        }

        private void Init()
        {
            IsBusy = true;

            try
            {
                _staticData = _dataService.GroupBeerList(_dataService.GetBeers().ToList<Beer>());
                UpdateListContent();
            }
            finally { IsBusy = false; }
        }

        private void ExecuteExpandCollapseCommand(object item)
        {
            var tappedGroup = (Grouping<string, Beer>)item;
            var selectedIndex = _model.IndexOf(tappedGroup);

            if (selectedIndex >= _staticData.Count)
                return;

            _staticData[selectedIndex].Expanded = !_staticData[selectedIndex].Expanded;

            UpdateListContent();
        }

        private void UpdateListContent()
        {
            Model = new ObservableCollection<Grouping<string, Beer>>();

            foreach (var beerGroup in _staticData)
            {
                var list = new List<Beer>();

                if (beerGroup.Expanded)
                {
                    list = new List<Beer>(beerGroup);
                }

                Model.Add(new Grouping<string, Beer>(beerGroup.Key, list, beerGroup.Expanded));
            }
        }
    }
}

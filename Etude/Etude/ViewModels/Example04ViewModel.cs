using Etude.Models;
using Etude.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example04ViewModel : BaseViewModel
    {
        public ObservableCollection<FoodGroup> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Properties
        private ObservableCollection<FoodGroup> _model;
        #endregion

        #region Services
        private readonly DataService _dataService = new DataService();
        #endregion

        #region Delegate Commands
        public ICommand ExpandCollapseCommand { get; }
        #endregion

        private ObservableCollection<FoodGroup> _foodGroups;

        public Example04ViewModel()
        {
            ExpandCollapseCommand = new Command<object>(ExpandCollapseExecute);

            MainThread.BeginInvokeOnMainThread(() =>
            {
                Init();
                UpdateListContent();
            });
        }

        private void ExpandCollapseExecute(object item)
        {
            var tappedGroup = (FoodGroup)item;
            var selectedIndex = _model.IndexOf(tappedGroup);

            if (selectedIndex >= _foodGroups.Count)
                return;

            _foodGroups[selectedIndex].Expanded = !_foodGroups[selectedIndex].Expanded;

            UpdateListContent();
        }

        private void Init()
        {
            _foodGroups = _dataService.GetFoodGroups();
        }

        private void UpdateListContent()
        {
            Model = new ObservableCollection<FoodGroup>();

            foreach (var foodGroup in _foodGroups)
            {
                var newGroup = new FoodGroup(foodGroup.Title, foodGroup.Expanded);

                if (foodGroup.Expanded)
                {
                    foreach (var store in foodGroup)
                    {
                        newGroup.Add(store);
                    }
                }

                Model.Add(newGroup);
            }
        }
    }
}

using Etude.Models;
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
            _foodGroups = new ObservableCollection<FoodGroup>
            {
                new FoodGroup("Carbohydrates")
                {
                    new Food { Name = "pasta", Description = "Carb Snakes" },
                    new Food { Name = "potato", Description = "The King of all Carbs" },
                    new Food { Name = "bread", Description = "Soft & Gentle" },
                    new Food { Name = "rice", Description = "Tiny grains of goodness" },
                },
                new FoodGroup("Fruits")
                {
                    new Food { Name = "apple", Description = "Keep the Doctor away" },
                    new Food { Name = "banana", Description = "This fruit is appealing" },
                    new Food { Name = "pear", Description = "Pear with me" },
                },
                new FoodGroup("Vegetables")
                {
                    new Food { Name = "carrot", Description = "Sounds like parrot" },
                    new Food { Name = "green bean", Description = "The less popular cousin of the baked bean" },
                    new Food { Name = "broccoli", Description = "Tiny food trees" },
                    new Food { Name = "peas", Description = "Peas sir, can I have some more?" },
                },
                new FoodGroup("Dairy")
                {
                    new Food { Name = "Milk", Description = "Milk" },
                    new Food { Name = "Cheese", Description = "Cheese + Potato" },
                    new Food { Name = "Ice Cream", Description = "Because I couldn't find an icon for yoghurt" }
                }
            };
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

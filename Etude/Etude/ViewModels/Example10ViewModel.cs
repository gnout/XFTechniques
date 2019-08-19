using Acr.UserDialogs;
using Etude.Models;
using Etude.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example10ViewModel : BaseViewModel
    {
        public IEnumerable<Food> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private IEnumerable<Food> _model = new List<Food>();
        #endregion

        #region Services
        private readonly FoodService _foodService = new FoodService();
        #endregion

        #region Delegate Commands
        public ICommand SelectedFoodCommand { get; private set; }
        #endregion

        public Example10ViewModel()
        {
            LoadDataCommand = new Command(async () => await InitAsync());
            SelectedFoodCommand = new Command<SelectedItemChangedEventArgs>(async (args) => await SelectedFoodExecute(args));
        }

        private Task InitAsync()
        {
            return Task.Run(() =>
            {
                Model = _foodService.GetFoods();
            });
        }

        private async Task SelectedFoodExecute(SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem == null)
                return;

            var food = (Food)args.SelectedItem;

            await UserDialogs.Instance.AlertAsync($"The selected food is {food.Name}", "Alert", "OK");
        }
    }
}

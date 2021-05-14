using Etude.Models;
using Etude.Views;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set03ViewModel : BaseViewModel
    {
        public List<Example> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        public Example SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value, value?.Act);
        }

        #region Backing Property Fields
        private List<Example> _model;
        private Example _selectedItem;
        #endregion

        public Set03ViewModel()
        {
            LoadDataCommand = new Command(async () => await InitAsync());
        }

        private Task InitAsync()
        {
            return Task.Run(() =>
            {
                var nav = App.Current.MainPage.Navigation;

                Model = new List<Example>
                {
                    new Example
                    {
                        Name = "Random Strings and Passwords",
                        Act = async () => { await nav.PushAsync(new Set03Example01()); }
                    },
                    new Example
                    {
                        Name = "Compare Decimal with Zero",
                        Act = async () => { await nav.PushAsync(new Set03Example02()); }
                    },
                    new Example
                    {
                        Name = "Task in Constructor",
                        Act = async () => { await nav.PushAsync(new Set03Example03()); }
                    }
                };
            });
        }
    }
}

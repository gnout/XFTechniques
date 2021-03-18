using Etude.Models;
using Etude.Views;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set04ViewModel : BaseViewModel
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

        public Set04ViewModel()
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
                        Name = "Fade In",
                        Act = async () => { await nav.PushAsync(new Set04Example01()); }
                    },
                    new Example
                    {
                        Name = "From Different Directions",
                        Act = async () => { await nav.PushAsync(new Set04Example02()); }
                    },
                    new Example
                    {
                        Name = "Turn the Page",
                        Act = async () => { await nav.PushAsync(new Set04Example03()); }
                    },
                    new Example
                    {
                        Name = "Coming from above",
                        Act = async () => { await nav.PushAsync(new Set04Example04()); }
                    },
                    new Example
                    {
                        Name = "Scale up and dissappear",
                        Act = async () => { await nav.PushAsync(new Set04Example05()); }
                    }
                };
            });
        }
    }
}

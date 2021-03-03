using Etude.Models;
using Etude.Views;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class MainPageViewModel : BaseViewModel
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

        public MainPageViewModel()
        {
            LoadDataCommand = new Command(async () => await InitAsync());
        }

        private Task InitAsync()
        {
            return Task.Run(() =>
            {
                Model = new List<Example>
                {
                    new Example
                    {
                        Name = "List Views - Collection Views",
                        Act = async () => { await App.Current.MainPage.Navigation.PushAsync(new Set01()); }
                    },
                    new Example
                    {
                        Name = "Interesting UI",
                        Act = async () => { await App.Current.MainPage.Navigation.PushAsync(new Set02()); }
                    },
                    new Example
                    {
                        Name = "Not so Xamarin",
                        Act = async () => { await App.Current.MainPage.Navigation.PushAsync(new Set03()); }
                    },
                    new Example
                    {
                        Name = "Page Transition Animations",
                        Act = async () => { await App.Current.MainPage.Navigation.PushAsync(new Set04()); }
                    },
                    new Example
                    {
                        Name = "Assorted",
                        Act = async () => { await App.Current.MainPage.Navigation.PushAsync(new Set05()); }
                    },
                    new Example
                    {
                        Name = "Effects",
                        Act = async () => { await App.Current.MainPage.Navigation.PushAsync(new Set06()); }
                    },
                    new Example
                    {
                        Name = "Converters",
                        Act = async () => { await App.Current.MainPage.Navigation.PushAsync(new Set07()); }
                    },
                    new Example
                    {
                        Name = "Reactive UI",
                        Act = async () => { await App.Current.MainPage.Navigation.PushAsync(new Set08()); }
                    }
                };
            });
        }
    }
}

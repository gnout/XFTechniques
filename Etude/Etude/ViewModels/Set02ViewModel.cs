using Etude.Models;
using Etude.Views;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set02ViewModel : BaseViewModel
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

        public Set02ViewModel()
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
                        Name = "Animate Dialog Appearance",
                        Act = async () => { await nav.PushAsync(new Set02Example01()); }
                    },
                    new Example
                    {
                        Name = "Equal Height to Width",
                        Act = async () => { await nav.PushAsync(new Set02Example02()); }
                    }
                };
            });
        }
    }
}

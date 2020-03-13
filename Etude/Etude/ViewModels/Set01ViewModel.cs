using Etude.Models;
using Etude.Views;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set01ViewModel : BaseViewModel
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

        public Set01ViewModel()
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
                        Name = "Android Fast Scrolling",
                        Act = async () => { await nav.PushAsync(new Set01Example01()); }
                    }
                };
            });
        }
    }
}

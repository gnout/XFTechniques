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
                        Name = "Expand / Collapse Tapped Cell",
                        Act = async () => { await nav.PushAsync(new Example03()); }
                    },
                    new Example
                    {
                        Name = "Expand / Collapse Grouped List",
                        Act = async () => { await nav.PushAsync(new Example04()); }
                    },
                    new Example
                    {
                        Name = "Simple Embeded Data",
                        Act = async () => { await nav.PushAsync(new Example11()); }
                    },
                    new Example
                    {
                        Name = "Simple ListView API Data",
                        Act = async () => { await nav.PushAsync(new Example12()); }
                    },
                    new Example
                    {
                        Name = "ListView with button",
                        Act = async () => { await nav.PushAsync(new Example14()); }
                    }
                };
            });
        }
    }
}

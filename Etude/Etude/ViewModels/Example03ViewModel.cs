using Etude.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example03ViewModel : BaseViewModel
    {
        public ObservableCollection<Band> Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private ObservableCollection<Band> _model;
        #endregion

        public Example03ViewModel()
        {
            LoadDataCommand = new Command(async () => await InitAsync());
        }

        private Task InitAsync()
        {
            return Task.Run(() =>
            {
                Model = new ObservableCollection<Band>
                {
                    new Band
                    {
                        Name = "Black Sabbath",
                        Musicians = new List<string>
                        {
                            "Ozzy Osbourne",
                            "Tommy Iommy",
                            "Geezer Butler",
                            "Bill Ward"
                        }
                    },
                    new Band
                    {
                        Name = "Pink Floyd",
                        Musicians = new List<string>
                        {
                            "Roger Waters",
                            "David Gilmour",
                            "Richard Wright",
                            "Nick Mason"
                        }
                    },
                    new Band
                    {
                        Name = "Led Zeppelin",
                        Musicians = new List<string>
                        {
                            "Robert Plant",
                            "Jimmy Page",
                            "John Paul Jones",
                            "John Bonham"
                        }
                    },
                    new Band
                    {
                        Name = "Deep Purple",
                        Musicians = new List<string>
                        {
                            "Ian Gillan",
                            "Ritchie Blackmore",
                            "Jon Lord",
                            "Roger Glover",
                            "Ian Paice"
                        }
                    },
                    new Band
                    {
                        Name = "Rainbow",
                        Musicians = new List<string>
                        {
                            "Ronnie James Dio",
                            "Ritchie Blackmore",
                            "Jimmy Bain",
                            "Tony carey",
                            "Cozy Powell"
                        }
                    }
                };
            });
        }
    }
}

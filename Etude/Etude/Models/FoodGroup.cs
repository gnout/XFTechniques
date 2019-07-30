using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Etude.Models
{
    public class FoodGroup : ObservableCollection<Food>
    {
        private bool _expanded;

        public string Title { get; set; }
        public string ShortName { get; set; }
        public string StateIcon => Expanded ? "collapsed" : "expanded";

        public bool Expanded
        {
            get => _expanded;
            set
            {
                if (_expanded != value)
                {
                    _expanded = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Expanded"));
                    OnPropertyChanged(new PropertyChangedEventArgs("StateIcon"));
                }
            }
        }

        public FoodGroup(string title, bool expanded = false)
        {
            Title = title;
            Expanded = expanded;
        }
    }
}

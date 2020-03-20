using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Etude.Helpers
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }
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

        private bool _expanded;

        public Grouping(K key, IEnumerable<T> items, bool expanded = false)
        {
            Key = key;
            Expanded = expanded;

            foreach (var item in items)
            {
                this.Items.Add(item);
            }
        }
    }
}

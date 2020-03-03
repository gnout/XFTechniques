using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Etude.ViewModels
{
    public class Example23Sample02ViewModel : ReactiveObject
    {
        [Reactive]
        public string Firstname { get; set; }

        [Reactive]
        public string Lastname { get; set; }

        public string FormattedName { [ObservableAsProperty] get; }

        public Example23Sample02ViewModel()
        {
            this.WhenAnyValue(
                vm => vm.Firstname,
                vm => vm.Lastname,
                (first, last) => $"{last}, {first}" )
                .ToPropertyEx(this, x => x.FormattedName);
        }
    }
}

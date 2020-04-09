using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Input;

namespace Etude.ViewModels
{
    public class Set08Example01ViewModel : ReactiveObject
    {
        [Reactive]
        public bool IsBusy { get; set; }

        #region Delegate Commands
        public ICommand Sample01Command { get; }
        public ReactiveCommand<Unit, Unit> Sample02Command { get; }
        public ReactiveCommand<Unit, Unit> Sample03Command { get; }
        public ReactiveCommand<Unit, bool> Sample04Command { get; }
        #endregion

        public Set08Example01ViewModel()
        {
            Sample01Command = ReactiveCommand.Create(ExecuteSample01Command);
            Sample02Command = ReactiveCommand.Create(ExecuteSample02Command);
            Sample03Command = ReactiveCommand.Create(ExecuteSample03Command);

            Sample04Command = ReactiveCommand.CreateFromTask<Unit, bool>(async (a) =>
            {
                IsBusy = true;

                try
                {
                    await Observable.Return(Unit.Default).Delay(TimeSpan.FromSeconds(2));
                }
                finally { IsBusy = false; }

                return false;
            });

            Sample04Command.Subscribe(async (result) =>
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Subscribe to a result", "OK");
            });
        }

        private async void ExecuteSample01Command()
        {
            await App.Current.MainPage.DisplayAlert("Alert", "Command Executed", "OK");
        }

        private async void ExecuteSample02Command()
        {
            await App.Current.MainPage.DisplayAlert("Alert", "Command Executed", "OK");
        }

        private async void ExecuteSample03Command()
        {
            IsBusy = true;

            try
            {
                await Observable.Return(Unit.Default).Delay(TimeSpan.FromSeconds(3));
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

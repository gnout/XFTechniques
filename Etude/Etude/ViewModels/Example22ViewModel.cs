using Etude.Modules;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example22ViewModel : BaseViewModel
    {
        #region Delegate Commands
        public ICommand Sample01Command { get; }
        #endregion

        public Example22ViewModel()
        {
            Sample01Command = new Command(async () => await Sample01Execute());
        }

        [Interceptor]
        private async Task Sample01Execute()
        {
            await Task.Delay(2000);
            IsBusy = false;
        }
    }
}

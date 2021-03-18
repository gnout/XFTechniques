using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set03Example02ViewModel : BaseViewModel
    {
        public string Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        #region Backing Property Fields
        private string _result = string.Empty;
        #endregion

        #region Delegate Commands
        public ICommand Compare01Command { get; }
        public ICommand Compare02Command { get; }
        public ICommand Compare03Command { get; }
        public ICommand Compare04Command { get; }
        #endregion

        public Set03Example02ViewModel()
        {
            Compare01Command = new Command(ExecuteCompare01Command);
            Compare02Command = new Command(ExecuteCompare02Command);
            Compare03Command = new Command(ExecuteCompare03Command);
            Compare04Command = new Command(ExecuteCompare04Command);
        }

        private void ExecuteCompare01Command()
        {
            Result = Compare(0);
        }

        private void ExecuteCompare02Command()
        {
            Result = Compare(0.0M);
        }

        private void ExecuteCompare03Command()
        {
            Result = Compare(0.01M);
        }

        private void ExecuteCompare04Command()
        {
            Result = Compare(0.0000000M);
        }

        private string Compare(decimal value)
        {
            if (decimal.Compare(value, 0.00000M) == 0)
            {
                return "Equal Values";
            }
            else
            {
                return "Values NOT Equal";
            }
        }
    }
}

using System;
using System.Threading.Tasks;

namespace Etude.ViewModels
{
    public class Set03Example03ViewModel : BaseViewModel
    {
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        #region Backing Property Fields
        private string _model = "Default Value";
        #endregion

        public Set03Example03ViewModel()
        {
            DoSomething().Await(HandleError);
        }

        private async Task DoSomething()
        {
            await Task.Delay(1000);
            Model = "Did Something";

            // Uncomment the following to see what happens when the task throws an exception
            //throw new Exception("That is an exception");
        }

        private void HandleError(Exception ex)
        {
            Model = ex.Message;
        }
    }

    public static class TaskExtensions
    {
        public static async void Await(this Task task, Action<Exception> errorCallback)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                errorCallback?.Invoke(ex);
            }
        }
    }
}

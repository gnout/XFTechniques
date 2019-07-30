using Acr.UserDialogs;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Example02ViewModel : BaseViewModel
    {
        #region Delegate Commands
        public ICommand Sample01Command { get; }
        public ICommand Sample02Command { get; }
        public ICommand Sample03Command { get; }
        public ICommand Sample04Command { get; }
        public ICommand Sample05Command { get; }
        public ICommand Sample06Command { get; }
        public ICommand Sample07Command { get; }
        public ICommand Sample08Command { get; }
        public ICommand Sample09Command { get; }
        public ICommand Sample10Command { get; }
        public ICommand Sample11Command { get; }
        public ICommand Sample12Command { get; }
        public ICommand Sample13Command { get; }
        #endregion

        public Example02ViewModel()
        {
            Sample01Command = new Command(Sample01Execute);
            Sample02Command = new Command(Sample02Execute);
            Sample03Command = new Command(Sample03Execute);
            Sample04Command = new Command(Sample04Execute);
            Sample05Command = new Command(Sample05Execute);
            Sample06Command = new Command(Sample06Execute);
            Sample07Command = new Command(Sample07Execute);
            Sample08Command = new Command(Sample08Execute);
            Sample09Command = new Command(Sample09Execute);
            Sample10Command = new Command(Sample10Execute);
            Sample11Command = new Command(Sample11Execute);
            Sample12Command = new Command(Sample12Execute);
            Sample13Command = new Command(Sample13Execute);
        }

        private async void Sample01Execute()
        {
            await UserDialogs.Instance.AlertAsync("Test alert", "Alert Title", "OK");
        }

        private void Sample02Execute()
        {
            var confirmConfig = new ConfirmConfig
            {
                Message = "Delete this record?",
                OkText = "Yes",
                CancelText = "No",
                Title = "Delete Confirmation",
                OnAction = async (a) =>
                {
                    if (a)
                        await UserDialogs.Instance.AlertAsync("The answer was to delete", "Alert", "OK");
                    else
                        await UserDialogs.Instance.AlertAsync("The answer was to cancel the action", "Alert", "OK");
                }
            };

            UserDialogs.Instance.Confirm(confirmConfig);
        }

        private async void Sample03Execute()
        {
            var result = await UserDialogs.Instance.ConfirmAsync(new ConfirmConfig
            {
                Message = "Delete this smoke record?",
                OkText = "Delete",
                CancelText = "Cancel"
            });

            if (result)
                await UserDialogs.Instance.AlertAsync("The answer was to delete", "Alert", "OK");
            else
                await UserDialogs.Instance.AlertAsync("The answer was to cancel the action", "Alert", "OK");
        }

        private void Sample04Execute()
        {
            var promptConfig = new PromptConfig
            {
                Title = "Filename",
                Text = "<Default Value>",
                Message = "Please type a valid filename (Min 2 characters)",
                OkText = "OK",
                CancelText = "Cancel",
                Placeholder = "filename",
                InputType = InputType.Name,
                OnTextChanged = args =>
                {
                    args.IsValid = args.Value.Length > 2;
                },
                OnAction = (result) =>
                {
                    UserDialogs.Instance.Alert($"Result - {result.Ok} - {result.Text}", "Alert", "OK");
                }
            };

            UserDialogs.Instance.Prompt(promptConfig);
        }

        private async void Sample05Execute()
        {
            var dateConfig = new DatePromptConfig
            {
                IsCancellable = true,
                MinimumDate = DateTime.Now.AddDays(-3),
                MaximumDate = DateTime.Now.AddDays(1),
            };

            var result = await UserDialogs.Instance.DatePromptAsync(dateConfig);

            UserDialogs.Instance.Alert($"Date Prompt: {result.Ok} - Value: {result.SelectedDate}", "Alert", "OK");
        }

        private async void Sample06Execute()
        {
            var timeConfig = new TimePromptConfig
            {
                IsCancellable = true
            };

            var result = await UserDialogs.Instance.TimePromptAsync(timeConfig);

            UserDialogs.Instance.Alert($"Time Prompt: {result.Ok} - Value: {result.SelectedTime}", "Alert", "OK");
        }

        private async void Sample07Execute()
        {
            using (UserDialogs.Instance.Loading("Loading", null, null, true, MaskType.Black))
            {
                await Task.Delay(2000);
            }
        }

        private async void Sample08Execute()
        {
            using (UserDialogs.Instance.Loading("Loading", null, null, true, MaskType.Clear))
            {
                await Task.Delay(2000);
            }
        }

        private async void Sample09Execute()
        {
            using (IProgressDialog progress = UserDialogs.Instance.Progress("Progress", null, null, true, MaskType.Black))
            {
                for (int i = 0; i < 100; i++)
                {
                    progress.PercentComplete = i;
                    await Task.Delay(80);
                }
            }
        }

        private void Sample10Execute()
        {
            ToastConfig toastConfig = new ToastConfig("This is unexpected (2 secs)");
            toastConfig.SetDuration(2000);
            toastConfig.SetBackgroundColor(Color.DimGray);

            UserDialogs.Instance.Toast(toastConfig);
        }

        private void Sample11Execute()
        {
            ToastConfig toastConfig = new ToastConfig("")
            {
                BackgroundColor = Color.AliceBlue,
                MessageTextColor = Color.Red,
                Message = "This is unexpected (2 secs)",
                Duration = TimeSpan.FromSeconds(2),
                Position = ToastPosition.Top
            };

            UserDialogs.Instance.Toast(toastConfig);
        }

        private void Sample12Execute()
        {
            ToastConfig.DefaultActionTextColor = System.Drawing.Color.DarkRed;

            UserDialogs.Instance.Toast(new ToastConfig("Unexpected Event")
                .SetBackgroundColor(Color.AliceBlue)
                .SetMessageTextColor(Color.Red)
                .SetDuration(TimeSpan.FromSeconds(2))
                .SetPosition(ToastPosition.Bottom)
                .SetAction((args) =>
                {
                    args.SetText("Done");
                })
            );
        }

        private void Sample13Execute()
        {
            UserDialogs.Instance.ActionSheet(new ActionSheetConfig()
                .SetTitle("Choose Type")
                .Add("Default", () => UserDialogs.Instance.Alert("Default", "Alert", "OK"))
                .Add("E-Mail", () => UserDialogs.Instance.Alert("E-mail", "Alert", "OK"))
                .Add("Name", () => UserDialogs.Instance.Alert("Name", "Alert", "OK"))
                .SetCancel());
        }
    }
}

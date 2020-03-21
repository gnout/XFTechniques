# XFTechniques
Techniques for Xamarin.Forms

## NuGet Packages

* [Newtonsoft.Json 12.0.2](https://www.newtonsoft.com/json) - All Projects
* [SkiaSharp.Views.Forms 1.68.0](https://github.com/mono/SkiaSharp) - All Projects (for the Markdown Control)
* [SkiaSharp.Svg 1.60.1](https://github.com/mono/SkiaSharp.Extended) - All Projects (for the Markdown Control)
* [ReactiveUI 11.2.1](https://reactiveui.net/) - All Projects
* [ReactiveUI.XamForms 11.2.1](https://reactiveui.net/) - All Projects
* [ReactiveUI.Events.XamForms 11.2.1](https://reactiveui.net/) - All Projects
* [ReactiveUI.Fody 11.2.1](https://reactiveui.net/) - All Projects

## Articles
[Easy full screen Splash for Android](https://xamarininsider.com/2019/04/03/easy-full-screen-splash-for-android/?utm_campaign=Weekly%2BXamarin&utm_medium=email&utm_source=Weekly_Xamarin_201)

## Android image sizes (screen resolutions

Following are the screen resolution and also the proportions of the screen resolutions for Android.
Proportions can also ve used for other media like icons etc. 

| Description | Resolution  | Proportion       |
| ----------- |:-----------:| ----------------:|
| MDPI        | 320x480px   | (The Default x1) |
| LDPI        | 240x360px   |   is 0.75 x MDPI |
| HDPI        | 480x800px   |    is 1.5 x MDPI |
| XHDPI       | 720x1280px  |      is 2 x MDPI |
| XXHDPI      | 960x1600px  |      is 3 x MDPI |
| XXXHDPI     | 1280x1920px |      is 4 x MDPI |

## Etudes

### Set 01 (ListViews) - Example 06 (Thread Safe Observable Collection)

The example shows how to make an `ObservableCollection` thread safe. The code is taken for the article [Making ObservableCollection Thread-Safe in Xamarin.Forms](https://codetraveler.io/2019/09/11/using-observablecollection-in-a-multi-threaded-xamarin-forms-application/)




For Reactive UI

    public class Example23Sample01ViewModel : ReactiveObject
    {
        [DataMember]
        public string UserName 
        { 
            get => _userName;
            set => this.RaiseAndSetIfChanged(ref _userName, value);
        }

        [DataMember]
        public string Password
        {
            get => _password;
            set => this.RaiseAndSetIfChanged(ref _password, value);
        }

        #region Backing variables
        private string _userName;
        private string _password;
        #endregion
    }


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




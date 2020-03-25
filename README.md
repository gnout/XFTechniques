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

### Set 06 (Effects) - Example 01 (Auto Scale Font)

The code is taken for the article [Forms Effect to automatically scale FontSize on Label](https://msicc.net/xfeffects-forms-effect-to-automatically-scale-fontsize-on-label/)

### Set 07 (Converters) - Example 01 (Binadble Converter Parameter)

The example is take from the [Xamarin Forum](https://forums.xamarin.com/discussion/71810/pass-binding-to-converterparameter)


For the converters
https://stackoverflow.com/questions/4942501/using-enum-in-converterparameter
https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/converters#binding-converter-properties









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



Check the following
                                <Label x:Name="LabelSubscriptionType" 
                                       Text="{Binding SubscriptionType}"
                                       IsVisible="False"/>
                                <Label Grid.Row="0"
                                       Style="{StaticResource BlackLabelBold}"
                                       FontSize="20">
                                    <Label.FormattedText>
                                        <FormattedString>
                                            <Span Text="{resources:Translate CreateInvoiceDiscountCodeAvailableCodes1}"/>
                                            <Span Text=" " />
                                            <Span Text="{Binding FreeDiscountCodesLeft, Converter={StaticResource NumberOfDiscountCodesToStringConverter}, ConverterParameter={x:Reference Name=LabelSubscriptionType}}" 
                                                  FontSize="22" />
                                            <Span Text=" " />
                                            <Span Text="{resources:Translate CreateInvoiceDiscountCodeAvailableCodes2}"/>
                                        </FormattedString>
                                    </Label.FormattedText>
                                </Label>

                                <Label Grid.Row="1"
                                       Style="{StaticResource GrayLabel}">
                                    <Label.FormattedText>
                                        <FormattedString>
                                            <Span Text="{resources:Translate CreateInvoiceDiscountCodePlanInfo1}"/>
                                            <Span Text=" " />
                                            <Span Text="{Binding SubscriptionType, Converter={StaticResource SubscriptionTypesToStringConverter}}" 
                                                  FontAttributes="Bold" 
                                                  FontSize="20" />
                                            <Span Text=" " />
                                            <Span Text="{Binding MaxFreeDiscountCodeForPeriod, Converter={StaticResource NumberOfDiscountCodesToStringConverter}, ConverterParameter={x:Reference Name=LabelSubscriptionType}, StringFormat={resources:Translate CreateInvoiceDiscountCodePlanInfo2}}"/>
                                        </FormattedString>
                                    </Label.FormattedText>
                                </Label>


using Xamarin.Forms;

namespace Etude.Effects
{
    public class AutoFitFontSizeEffect : RoutingEffect
    {
        public AutoFitFontSizeEffect() : base($"RandomWalk.{nameof(AutoFitFontSizeEffect)}")
        {

        }
    }

    public static class AutoFitFontSizeEffectParameters
    {
        #region Public Fields

        public static BindableProperty MaxFontSizeProperty = BindableProperty.CreateAttached("MaxFontSize", 
            typeof(NamedSize), typeof(AutoFitFontSizeEffectParameters), NamedSize.Large, BindingMode.Default);
        public static BindableProperty MinFontSizeProperty = BindableProperty.CreateAttached("MinFontSize", 
            typeof(NamedSize), typeof(AutoFitFontSizeEffectParameters), NamedSize.Default, BindingMode.Default);

        #endregion Public Fields

        #region Public Methods

        public static NamedSize GetMaxFontSize(BindableObject bindable)
        {
            return (NamedSize)bindable.GetValue(MaxFontSizeProperty);
        }

        public static NamedSize GetMinFontSize(BindableObject bindable)
        {
            return (NamedSize)bindable.GetValue(MinFontSizeProperty);
        }

        public static double MaxFontSizeNumeric(BindableObject bindable)
        {
            return Device.GetNamedSize(GetMaxFontSize(bindable), typeof(Label));
        }

        public static double MinFontSizeNumeric(BindableObject bindable)
        {
            return Device.GetNamedSize(GetMinFontSize(bindable), typeof(Label));
        }

        public static void SetMaxFontSize(BindableObject bindable, NamedSize value)
        {
            bindable.SetValue(MaxFontSizeProperty, value);
        }

        public static void SetMinFontSize(BindableObject bindable, NamedSize value)
        {
            bindable.SetValue(MinFontSizeProperty, value);
        }

        #endregion Public Methods
    }
}

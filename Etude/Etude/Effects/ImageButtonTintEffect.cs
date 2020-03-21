using System.Linq;
using Xamarin.Forms;

namespace Etude.Effects
{
    public class ImageButtonTintEffect : RoutingEffect
    {
        public ImageButtonTintEffect() : base($"RandomWalk.{nameof(ImageButtonTintEffect)}")
        {

        }
    }

    public static class ImageButtonTintEffectParameters
    {
        #region Public Fields

        public static readonly BindableProperty TintColorProperty = BindableProperty.CreateAttached("TintColor", 
            typeof(Color), typeof(ImageButtonTintEffectParameters), Color.Default, propertyChanged: OnTintColorPropertyChanged);

        #endregion Public Fields

        #region Public Methods

        public static Color GetTintColor(BindableObject bindable)
        {
            return (Color)bindable.GetValue(TintColorProperty);
        }

        public static void SetTintColor(BindableObject bindable, Color value)
        {
            bindable.SetValue(TintColorProperty, value);
        }

        #endregion Public Methods

        #region Private Methods

        private static void OnTintColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is ImageButton current)
            {
                if ((Color)newValue != Color.Default)
                {
                    if (!current.Effects.Any(e => e is ImageButtonTintEffect))
                        current.Effects.Add(Effect.Resolve(nameof(ImageButtonTintEffect)));
                }
                else
                {
                    if (current.Effects.Any(e => e is ImageButtonTintEffect))
                    {
                        var existingEffect = current.Effects.FirstOrDefault(e => e is ImageButtonTintEffect);
                        current.Effects.Remove(existingEffect);
                    }
                }
            }
        }

        #endregion Private Methods
    }
}

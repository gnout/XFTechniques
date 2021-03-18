using Etude.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(Etude.iOS.Effects.AutoFitFontSizeEffect), nameof(Etude.Effects.AutoFitFontSizeEffect))]
namespace Etude.iOS.Effects
{
    [Preserve(AllMembers = true)]
    public class AutoFitFontSizeEffect : PlatformEffect
    {
        #region Protected Methods

        protected override void OnAttached()
        {
            if (this.Control is UILabel label)
            {
                if (AutoFitFontSizeEffectParameters.GetMinFontSize(this.Element) == NamedSize.Default &&
                    AutoFitFontSizeEffectParameters.GetMaxFontSize(this.Element) == NamedSize.Default)
                    return;

                var min = (int)AutoFitFontSizeEffectParameters.MinFontSizeNumeric(this.Element);
                var max = (int)AutoFitFontSizeEffectParameters.MaxFontSizeNumeric(this.Element);

                if (max <= min)
                    return;

                label.AdjustsFontSizeToFitWidth = true;
                label.MinimumFontSize = (float)min;
                label.Font = label.Font.WithSize((float)max);
            }
        }

        protected override void OnDetached()
        {
        }

        #endregion Protected Methods
    }
}
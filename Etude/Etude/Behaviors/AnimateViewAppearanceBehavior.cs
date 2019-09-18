using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Etude.Behaviors
{
    public class AnimateViewAppearanceBehavior : Behavior<ContentView>
    {
        public object AnimateControl { get; set; }

        private const int AnimationSpeed = 350;
        private const int PositionToAnimate = 700;

        protected override void OnAttachedTo(ContentView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.PropertyChanged += Bindable_PropertyChanged;
        }

        protected override void OnDetachingFrom(ContentView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.PropertyChanged -= Bindable_PropertyChanged;
        }

        private async void Bindable_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var isVisible = false;

            if (!e.PropertyName.Equals("IsVisible", StringComparison.CurrentCultureIgnoreCase))
            {
                return;
            }
            else
            {
                var view = ((ContentView)sender);

                if (view != null)
                {
                    isVisible = view.IsVisible;
                }
            }

            if (!isVisible)
            {
                return;
            }

            View controlToAnimate;

            if (AnimateControl == null)
            {
                return;
            }
            else
            {
                controlToAnimate = (View)((Binding)AnimateControl)?.Source;
            }

            if (controlToAnimate == null)
            {
                return;
            }

            try
            {
                var translateToY = controlToAnimate.TranslationY;

                controlToAnimate.TranslationY = PositionToAnimate;
                await controlToAnimate.TranslateTo(0, translateToY, AnimationSpeed, Easing.SinOut);
            }
            catch (Exception)
            {
                controlToAnimate.TranslationY = 0;
            }
        }
    }
}

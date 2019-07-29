using Xamarin.Forms;

namespace Etude.Behaviors
{
    public static class DecimalValidationBehavior
    {
        public static readonly BindableProperty AttachBehaviorProperty =
            BindableProperty.CreateAttached(
                "AttachBehavior",
                typeof(bool),
                typeof(DecimalValidationBehavior),
                false,
                propertyChanged: OnAttachBehaviorChanged);

        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }

        public static void SetAttachBehavior(BindableObject view, bool value)
        {
            view.SetValue(AttachBehaviorProperty, value);
        }

        static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
        {
            if (!(view is Entry entry))
            {
                return;
            }

            var attachBehavior = (bool)newValue;

            if (attachBehavior)
            {
                entry.TextChanged += OnEntryTextChanged;
            }
            else
            {
                entry.TextChanged -= OnEntryTextChanged;
            }
        }

        private static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            ((Entry)sender).TextColor = double.TryParse(args.NewTextValue, out var result) 
                ? Color.Default 
                : Color.Red;
        }
    }
}

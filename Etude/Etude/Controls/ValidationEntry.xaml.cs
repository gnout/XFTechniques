using Xamarin.Forms;

namespace Etude.Controls
{
    public partial class ValidationEntry : ContentView
    {
        // Caption Label
        public static readonly BindableProperty CaptionProperty = BindableProperty.Create(
            nameof(Caption), typeof(string), typeof(ValidationEntry), default(string));

        public string Caption
        {
            get => (string)GetValue(CaptionProperty);
            set => SetValue(CaptionProperty, value);
        }

        // Entry
        public static readonly BindableProperty ValueProperty = BindableProperty.Create(
            nameof(Value), typeof(string), typeof(ValidationEntry), default(string));

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
            nameof(Placeholder), typeof(string), typeof(ValidationEntry), default(string));

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        public static readonly BindableProperty AttachDecimalValidationBehaviorProperty =
            BindableProperty.Create(nameof(AttachDecimalValidationBehavior), typeof(bool), typeof(ValidationEntry),
                false);

        public bool AttachDecimalValidationBehavior
        {
            get => (bool)GetValue(AttachDecimalValidationBehaviorProperty);
            set => SetValue(AttachDecimalValidationBehaviorProperty, value);
        }

        public ValidationEntry()
        {
            InitializeComponent();
        }
    }
}
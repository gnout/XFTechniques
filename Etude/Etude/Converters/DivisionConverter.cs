using System;
using System.Globalization;
using Xamarin.Forms;

namespace Etude.Converters
{
    public class DivisionConverter : BindableObject, IValueConverter
    {
        public static readonly BindableProperty DenominatorProperty = BindableProperty.Create("Denominator", 
            typeof(decimal), 
            typeof(DivisionConverter));

        public decimal Denominator
        {
            get { return (decimal)GetValue(DenominatorProperty); }
            set { SetValue(DenominatorProperty, value); }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, null))
            {
                return null;
            }

            return Math.Floor((float)value / float.Parse(Denominator.ToString()));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}

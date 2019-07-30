using System;
using System.Globalization;
using Xamarin.Forms;

namespace Etude.Converters
{
    public class EqualsParameterContextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;

            return value == ((View)parameter).BindingContext;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}

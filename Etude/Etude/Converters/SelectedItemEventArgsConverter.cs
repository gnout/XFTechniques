using System;
using System.Globalization;
using Xamarin.Forms;

namespace Etude.Converters
{
    public class SelectedItemEventArgsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value as SelectedItemChangedEventArgs;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}

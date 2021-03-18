using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace Etude.Converters
{
    public enum CharCaps
    {
        All,
        OnlyLowercase,
        OnlyUppercase
    }

    public class CharCounterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = 0;

            if ((value == null) || (parameter == null))
            {
                return result;
            }

            var input = value.ToString();
            var method = (CharCaps)Enum.Parse(typeof(CharCaps), parameter.ToString());

            switch (method)
            {
                case CharCaps.OnlyUppercase:
                    result = input.Count(c => char.IsUpper(c));
                    break;
                case CharCaps.OnlyLowercase:
                    result = input.Count(c => char.IsLower(c));
                    break;
                default:
                    result = input.Count();
                    break;
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}

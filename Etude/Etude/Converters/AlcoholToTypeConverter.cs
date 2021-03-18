using System;
using System.Globalization;
using Xamarin.Forms;

namespace Etude.Converters
{
    public class AlcoholToTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = string.Empty;

            if (value != null)
            {
                try
                {
                    var alcohol = float.Parse(value.ToString());
                    var name = GetParamValue(parameter);

                    if (alcohol < 9.0F)
                    {
                        result = $"{name} is a Tripe";
                    }
                    else
                    {
                        result = $"{name} is a Quadrapel";
                    }
                }
                catch { }
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        private string GetParamValue(object param)
        {
            var result = string.Empty;

            try
            {
                if (param is Label nameLabel)
                {
                    result = nameLabel.Text;
                }
            }
            catch { }

            return result;
        }
    }
}

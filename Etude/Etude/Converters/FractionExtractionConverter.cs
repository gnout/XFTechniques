using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;

namespace Etude.Converters
{
    public class FractionExtractionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = string.Empty;

            try
            {
                var currentCulture = Thread.CurrentThread.CurrentCulture;
                var amount = float.Parse(value.ToString());
                var amountFormatted = amount.ToString("N2", currentCulture);
                var numberOfLastCharacters = 3;

                if (parameter?.ToString()?.ToLower(culture) == "false")
                {
                    numberOfLastCharacters = 2;
                }

                result = GetLast(amountFormatted, numberOfLastCharacters);
            }
            catch { }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        private string GetLast(string source, int numberOfChars)
        {
            return numberOfChars >= source.Length
                ? source
                : source.Substring(source.Length - numberOfChars);
        }
    }
}

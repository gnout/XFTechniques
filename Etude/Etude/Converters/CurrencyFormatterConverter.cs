using NodaMoney;
using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;

namespace Etude.Converters
{
    public class CurrencyFormatterConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var amount = default(decimal);
            var currencyCode = "EUR";
            var format = "C2";
            var result = string.Empty;

            try
            {
                amount = decimal.Parse(values[0].ToString());
            }
            catch { }

            try
            {
                currencyCode = values[1].ToString();
            }
            catch { }

            try
            {
                format = parameter.ToString();
            }
            catch { }

            try
            {
                var currentCulture = Thread.CurrentThread.CurrentCulture;

                if (format == "C0")
                {
                    amount = Math.Floor(amount);
                }

                result = new Money(amount, Currency.FromCode(currencyCode))
                    .ToString(format, currentCulture);
            }
            catch { }

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return new object[] { 0.0M, "EUR", "C2" };
        }
    }
}

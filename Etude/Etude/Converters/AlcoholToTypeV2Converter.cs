using Etude.ViewModels;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace Etude.Converters
{
    public class AlcoholToTypeV2Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = string.Empty;

            if (value != null)
            {
                try
                {
                    if (!(parameter is BindableObject bindableObject))
                        return string.Empty;

                    var vm = (Set07Example03ViewModel)bindableObject.BindingContext;

                    if (vm != null)
                    {
                        if (vm.Model2.Alcohol < 9.0F)
                        {
                            result = $"{vm.Model2.Name} is a Tripe";
                        }
                        else
                        {
                            result = $"{vm.Model2.Name} is a Quadrapel";
                        }
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
    }
}

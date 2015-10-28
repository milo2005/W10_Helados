using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Helados.Models
{
    public class HeladoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Color c = (Color) value;
            return new SolidColorBrush(c);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            int valueC = System.Convert.ToInt16(value);
            return valueC;
        }
    }
}

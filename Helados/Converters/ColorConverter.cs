using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Helados.Converters
{
    class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Color c = (Color)value;
            return new SolidColorBrush(c);
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            int v = System.Convert.ToInt32(value);
            return v;
        }
    }
}

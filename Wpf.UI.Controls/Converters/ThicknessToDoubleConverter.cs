using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Wpf.UI.Controls.Converters
{
    public class ThicknessToDoubleConverter : IValueConverter
    {
        public static ThicknessToDoubleConverter Instance => new ThicknessToDoubleConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Thickness thickness = (Thickness)value;
            return thickness.Bottom;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

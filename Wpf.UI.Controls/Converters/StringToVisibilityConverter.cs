﻿using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Wpf.UI.Controls.Converters
{
    public class StringToVisibilityConverter : IValueConverter
    {
        public static StringToVisibilityConverter Instance => new StringToVisibilityConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.IsNullOrEmpty(value.ToString()) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

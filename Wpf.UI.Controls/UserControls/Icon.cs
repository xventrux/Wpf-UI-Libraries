using System.Windows;
using System.Windows.Controls;

namespace Wpf.UI.Controls
{
    /// <summary>
    /// Логика взаимодействия для Icon.xaml
    /// </summary>
    public class Icon : UserControl
    {

        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(Icon), new PropertyMetadata(string.Empty));
    }
}

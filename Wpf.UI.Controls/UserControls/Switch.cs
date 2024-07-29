using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Wpf.UI.Controls
{
    /// <summary>
    /// Логика взаимодействия для Switch.xaml
    /// </summary>
    public partial class Switch : CheckBox
    {

        public string OffText
        {
            get { return (string)GetValue(OffTextProperty); }
            set { SetValue(OffTextProperty, value); }
        }

        public static readonly DependencyProperty OffTextProperty =
            DependencyProperty.Register("OffText", typeof(string), typeof(Switch), new PropertyMetadata(string.Empty));

        public string OnText
        {
            get { return (string)GetValue(OnTextProperty); }
            set { SetValue(OnTextProperty, value); }
        }

        public static readonly DependencyProperty OnTextProperty =
            DependencyProperty.Register("OnText", typeof(string), typeof(Switch), new PropertyMetadata(string.Empty));

        public string OffIcon
        {
            get { return (string)GetValue(OffIconProperty); }
            set { SetValue(OffIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OffIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OffIconProperty =
            DependencyProperty.Register("OffIcon", typeof(string), typeof(Switch), new PropertyMetadata(string.Empty));



        public string OnIcon
        {
            get { return (string)GetValue(OnIconProperty); }
            set { SetValue(OnIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OnIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OnIconProperty =
            DependencyProperty.Register("OnIcon", typeof(string), typeof(Switch), new PropertyMetadata(string.Empty));



        public Brush Fill
        {
            get { return (Brush)GetValue(FillProperty); }
            set { SetValue(FillProperty, value); }
        }

        public static readonly DependencyProperty FillProperty =
            DependencyProperty.Register("Fill", typeof(Brush), typeof(Switch), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(255, 255, 255))));



        internal double EllipseOffset
        {
            get { return (double)GetValue(EllipseOffsetProperty); }
            set { SetValue(EllipseOffsetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EllipseOffset.  This enables animation, styling, binding, etc...
        internal static readonly DependencyProperty EllipseOffsetProperty =
            DependencyProperty.Register("EllipseOffset", typeof(double), typeof(Switch), new PropertyMetadata(0d));



        public double EllipseHeight
        {
            get { return (double)GetValue(EllipseHeightProperty); }
            set { SetValue(EllipseHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EllipseHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EllipseHeightProperty =
            DependencyProperty.Register("EllipseHeight", typeof(double), typeof(Switch), new PropertyMetadata(10d));



    }
}

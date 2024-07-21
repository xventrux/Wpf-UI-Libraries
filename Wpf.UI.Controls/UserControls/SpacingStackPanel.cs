using System.Windows.Controls;
using System.Windows;

namespace Wpf.UI.Controls
{
    public class SpacingStackPanel : StackPanel
    {
        public int ItemSpacing
        {
            get { return (int)GetValue(ItemSpacingProperty); }
            set { SetValue(ItemSpacingProperty, value); }
        }
        public static readonly DependencyProperty ItemSpacingProperty =
            DependencyProperty.Register("ItemSpacing", typeof(int), typeof(SpacingStackPanel), new PropertyMetadata(0));

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            switch (e.Property.Name)
            {
                case nameof(ItemSpacing):
                    SetMarginChilds();
                    break;
            }
        }

        protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved)
        {
            base.OnVisualChildrenChanged(visualAdded, visualRemoved);

            SetMarginChilds();
        }

        private void SetMarginChilds()
        {
            if (Children.Count == 0)
                return;

            for (int i = 0; i < Children.Count - 1; i++)
            {
                SetMargin(Children[i] as FrameworkElement);
            }
        }

        private void SetMargin(FrameworkElement visual)
        {
            if (visual is null) return;

            if (Orientation == Orientation.Horizontal)
                visual.Margin = new Thickness(0, 0, ItemSpacing, 0);
            else
                visual.Margin = new Thickness(0, 0, 0, ItemSpacing);
        }
    }
}

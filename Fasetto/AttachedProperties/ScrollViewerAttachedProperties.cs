using System.Windows;
using System.Windows.Controls;

namespace Fasetto.AttachedProperties;

public class ScrollViewerAttachedProperties
{
    public static readonly DependencyProperty ScrollToBottomProperty = DependencyProperty.RegisterAttached(
        "ScrollToBottom", typeof(bool), typeof(ScrollViewerAttachedProperties), 
        new PropertyMetadata(OnScrollToBottomValueChanged));

    public static bool GetScrollToBottom(DependencyObject obj)
    {
        return (bool)obj.GetValue(ScrollToBottomProperty);
    }

    public static void SetScrollToBottom(DependencyObject obj, bool value)
    {
        obj.SetValue(ScrollToBottomProperty, value);
    }

    private static void OnScrollToBottomValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (!(d is ScrollViewer scrollViewer))
            return;

        if ((bool)e.NewValue)
            ((ScrollViewer)d).ScrollToBottom();
    }
}

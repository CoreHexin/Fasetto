using Fasetto.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.AttachedProperties;

public class ScrollViewerAttachedProperties
{
    public static readonly DependencyProperty ScrollToBottomProperty = DependencyProperty.RegisterAttached(
        "ScrollToBottom", typeof(List<ChatMessageListItemViewModel>), typeof(ScrollViewerAttachedProperties), 
        new PropertyMetadata(OnScrollToBottomValueChanged));

    public static List<ChatMessageListItemViewModel> GetScrollToBottom(DependencyObject obj)
    {
        return (List<ChatMessageListItemViewModel>)obj.GetValue(ScrollToBottomProperty);
    }

    public static void SetScrollToBottom(DependencyObject obj, List<ChatMessageListItemViewModel> value)
    {
        obj.SetValue(ScrollToBottomProperty, value);
    }

    private static void OnScrollToBottomValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (!(d is ScrollViewer scrollViewer))
            return;

        ((ScrollViewer)d).ScrollToBottom();
    }
}

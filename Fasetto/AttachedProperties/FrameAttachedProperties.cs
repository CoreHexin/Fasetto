using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Fasetto.AttachedProperties;

public class FrameAttachedProperties
{
    public static readonly DependencyProperty NoFrameHistoryProperty = DependencyProperty.RegisterAttached(
        "NoFrameHistory", typeof(bool), typeof(FrameAttachedProperties), new PropertyMetadata(OnPropertyChanged));

    private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is Frame frame)
        {
            frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            frame.Navigated += Frame_Navigated;
        }
    }

    private static void Frame_Navigated(object sender, NavigationEventArgs e)
    {
        ((Frame)sender).NavigationService.RemoveBackEntry();
    }

    public static bool GetNoFrameHistory(DependencyObject obj)
    {
        return (bool)obj.GetValue(NoFrameHistoryProperty);
    }

    public static void SetNoFrameHistory(DependencyObject obj, bool value)
    {
        obj.SetValue(NoFrameHistoryProperty, value);
    }

}

using System.Windows;

namespace Fasetto.AttachedProperties;

public class ButtonAttachedProperties
{
    public static readonly DependencyProperty IsBusyProperty =
        DependencyProperty.RegisterAttached("IsBusy", typeof(bool), typeof(ButtonAttachedProperties), new PropertyMetadata(false));

    public static bool GetIsBusy(DependencyObject obj)
    {
        return (bool)obj.GetValue(IsBusyProperty);
    }

    public static void SetIsBusy(DependencyObject obj, bool value)
    {
        obj.SetValue(IsBusyProperty, value);
    }
}

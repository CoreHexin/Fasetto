using System.Windows;
using System.Windows.Controls;

namespace Fasetto.AttachedProperties;

public class TextBoxAttachedProperties
{
    public static readonly DependencyProperty IsFocusedProperty = DependencyProperty.RegisterAttached(
        "IsFocused", typeof(bool), typeof(TextBoxAttachedProperties), new PropertyMetadata(OnPropertyChanged));

    private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is Control control)
        {
            control.Focus();
        }
    }

    public static bool GetIsFocused(DependencyObject obj)
    {
        return (bool)obj.GetValue(IsFocusedProperty);
    }

    public static void SetIsFocused(DependencyObject obj, bool value)
    {
        obj.SetValue(IsFocusedProperty, value);
    }

}

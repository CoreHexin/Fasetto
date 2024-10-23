using System.Windows;
using System.Windows.Controls;

namespace Fasetto.AttachedProperties;

public class TextBoxAttachedProperties
{
    public static readonly DependencyProperty IsFocusedProperty = DependencyProperty.RegisterAttached(
        "IsFocused", typeof(bool), typeof(TextBoxAttachedProperties), new PropertyMetadata(OnIsFocusedPropertyChanged));

    private static void OnIsFocusedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
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


    public static readonly DependencyProperty FocusAndVisibleProperty = DependencyProperty.RegisterAttached(
        "FocusAndVisible", typeof(bool), typeof(TextBoxAttachedProperties), new PropertyMetadata(OnFocusAndVisiblePropertyChanged));

    private static void OnFocusAndVisiblePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not Control control)
            return;

        if ((bool)e.NewValue)
        {
            control.Visibility = Visibility.Visible;
            control.Focus();
        }
        else
        {
            control.Visibility = Visibility.Hidden;
        }

    }

    public static bool GetFocusAndVisible(DependencyObject obj)
    {
        return (bool)obj.GetValue(FocusAndVisibleProperty);
    }

    public static void SetFocusAndVisible(DependencyObject obj, bool value)
    {
        obj.SetValue(FocusAndVisibleProperty, value);
    }

}

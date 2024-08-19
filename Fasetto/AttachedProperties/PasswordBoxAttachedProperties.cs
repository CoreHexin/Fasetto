using System.Windows;

namespace Fasetto.AttachedProperties;

public class PasswordBoxAttachedProperties
{
    public static readonly DependencyProperty HasPasswordProperty =
        DependencyProperty.RegisterAttached("HasPassword", typeof(bool), typeof(PasswordBoxAttachedProperties), new PropertyMetadata(false));

    public static bool GetHasPassword(DependencyObject obj)
    {
        return (bool)obj.GetValue(HasPasswordProperty);
    }

    public static void SetHasPassword(DependencyObject obj, bool value)
    {
        obj.SetValue(HasPasswordProperty, value);
    }
}

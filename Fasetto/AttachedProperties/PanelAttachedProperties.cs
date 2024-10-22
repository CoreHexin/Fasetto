using System.Windows;
using System.Windows.Controls;

namespace Fasetto.AttachedProperties;

public class PanelAttachedProperties
{
    public static readonly DependencyProperty PanelChildMarginProperty = DependencyProperty.RegisterAttached(
        "PanelChildMargin", typeof(string), typeof(PanelAttachedProperties), new PropertyMetadata(OnPanelChildMarginValueChanged));

    public static string GetPanelChildMargin(DependencyObject obj)
    {
        return (string)obj.GetValue(PanelChildMarginProperty);
    }

    public static void SetPanelChildMargin(DependencyObject obj, string value)
    {
        obj.SetValue(PanelChildMarginProperty, value);
    }

    private static void OnPanelChildMarginValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var panel = d as Panel;
        if (panel != null)
        {
            panel.Loaded += (s, ee) =>
            {
                foreach (var child in panel.Children)
                {
                    (child as FrameworkElement).Margin = (Thickness)new ThicknessConverter().ConvertFromString(e.NewValue.ToString());
                }
            };
        }
    }
}

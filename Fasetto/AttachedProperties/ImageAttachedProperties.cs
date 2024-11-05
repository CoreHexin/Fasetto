using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Fasetto.AttachedProperties;

public class ImageAttachedProperties
{
    private static RoutedEventHandler _border_Loaded;

    private static SizeChangedEventHandler _border_SizeChanged;

    // 根据父元素Border的圆角设置Image圆角效果
    public static readonly DependencyProperty ClipFromBorderProperty = 
        DependencyProperty.RegisterAttached("ClipFromBorder", typeof(bool), typeof(ImageAttachedProperties), new PropertyMetadata(OnClipFromBorderChanged));

    private static void OnClipFromBorderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var image = d as FrameworkElement;

        if (!(image.Parent is Border border))
        {
            throw new ArgumentException("image parent must be Border");
        }

        _border_Loaded = (s,e) => Border_LoadedOrSizeChanged(s, e, image);
        _border_SizeChanged = (s,e) => Border_LoadedOrSizeChanged(s, e, image);

        if ((bool)e.NewValue)
        {
            border.Loaded -= _border_Loaded;
            border.Loaded += _border_Loaded;

            border.SizeChanged -= _border_SizeChanged;
            border.SizeChanged += _border_SizeChanged;
        }
    }

    private static void Border_LoadedOrSizeChanged(object sender, RoutedEventArgs e, FrameworkElement child)
    {
        var border = (Border)sender;
        if (border.ActualWidth == 0 || border.ActualHeight == 0)
            return;

        var rect = new RectangleGeometry();
        rect.RadiusX = rect.RadiusY = Math.Max(0, border.CornerRadius.TopLeft);
        rect.Rect = new Rect(child.RenderSize);
        child.Clip = rect;
    }

    public static bool GetClipFromBorder(DependencyObject obj)
    {
        return (bool)obj.GetValue(ClipFromBorderProperty);
    }

    public static void SetClipFromBorder(DependencyObject obj, bool value)
    {
        obj.SetValue(ClipFromBorderProperty, value);
    }

}

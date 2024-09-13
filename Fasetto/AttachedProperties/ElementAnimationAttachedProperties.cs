using Fasetto.Animation;
using System.Windows;

namespace Fasetto.AttachedProperties;


public class ElementAnimationAttachedProperties
{
    public static readonly DependencyProperty SlideAndFadeInFromLeftProperty = DependencyProperty.RegisterAttached(
        "SlideAndFadeInFromLeft", typeof(bool), typeof(ElementAnimationAttachedProperties), 
        new PropertyMetadata(OnPropertyChanged));

    private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (!(d is FrameworkElement element))
            return;

        bool value = GetSlideAndFadeInFromLeft(d);
        if (value)
        {
            element.SlideAndFadeInFromLeft(0.3f);
        }
        else
        {
            element.SlideAndFadeOutToLeft(0.3f);
        }
    }

    public static bool GetSlideAndFadeInFromLeft(DependencyObject obj)
    {
        return (bool)obj.GetValue(SlideAndFadeInFromLeftProperty);
    }

    public static void SetSlideAndFadeInFromLeft(DependencyObject obj, bool value)
    {
        obj.SetValue(SlideAndFadeInFromLeftProperty, value);
    }
}

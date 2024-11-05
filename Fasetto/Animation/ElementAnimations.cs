using System.Windows;
using System.Windows.Media.Animation;

namespace Fasetto.Animation;

public static class ElementAnimations
{
    /// <summary>
    /// 淡入动画
    /// </summary>
    /// <param name="element"></param>
    /// <param name="seconds"></param>
    public static void FadeIn(this FrameworkElement element, float seconds)
    {
        var storyboard = new Storyboard();
        storyboard.AddFadeIn(seconds);
        storyboard.Begin(element);
    }

    /// <summary>
    /// 从左侧滑入加淡入效果
    /// </summary>
    /// <param name="element"></param>
    /// <param name="seconds"></param>
    /// <returns></returns>
    public static void SlideAndFadeInFromLeft(this FrameworkElement element, float seconds)
    {
        var storyboard = new Storyboard();
        storyboard.AddSlideFromLeft(seconds, element.ActualWidth);
        storyboard.AddFadeIn(seconds);
        storyboard.Begin(element);
    }

    /// <summary>
    /// 从右侧滑入加淡入效果
    /// </summary>
    /// <param name="element"></param>
    /// <param name="seconds"></param>
    public static void SlideAndFadeInFromRight(this FrameworkElement element, float seconds)
    {
        var storyboard = new Storyboard();
        storyboard.AddSlideFromRight(seconds, element.ActualWidth);
        storyboard.AddFadeIn(seconds);
        storyboard.Begin(element);
    }

    /// <summary>
    /// 向左侧滑出加淡出效果
    /// </summary>
    /// <param name="element"></param>
    /// <param name="seconds"></param>
    /// <returns></returns>
    public static void SlideAndFadeOutToLeft(this FrameworkElement element, float seconds)
    {
        var storyboard = new Storyboard();
        storyboard.AddSlideToLeft(seconds, element.ActualWidth);
        storyboard.AddFadeOut(seconds);
        storyboard.Begin(element);
    }

}

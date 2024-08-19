using System.Windows;
using System.Windows.Media.Animation;

namespace Fasetto.Animation;

public static class StoryboardHelpers
{
    /// <summary>
    /// 从右侧滑入效果
    /// </summary>
    /// <param name="storyboard"></param>
    /// <param name="seconds"></param>
    /// <param name="offset"></param>
    /// <param name="decelerationRatio"></param>
    public static void AddSlideFromRight(this Storyboard storyboard, float seconds,
        double offset, float decelerationRatio = 0.9f)
    {
        var animation = new ThicknessAnimation
        {
            Duration = new Duration(TimeSpan.FromSeconds(seconds)),
            From = new Thickness(offset, 0, -offset, 0),
            To = new Thickness(0),
            DecelerationRatio = decelerationRatio
        };
        Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
        storyboard.Children.Add(animation);
    }

    /// <summary>
    /// 向左侧滑出效果
    /// </summary>
    /// <param name="storyboard"></param>
    /// <param name="seconds"></param>
    /// <param name="offset"></param>
    /// <param name="decelerationRatio"></param>
    public static void AddSlideToLeft(this Storyboard storyboard, float seconds,
        double offset, float decelerationRatio = 0.9f)
    {
        var animation = new ThicknessAnimation
        {
            Duration = new Duration(TimeSpan.FromSeconds(seconds)),
            From = new Thickness(0),
            To = new Thickness(-offset, 0, offset, 0),
        };
        Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
        storyboard.Children.Add(animation);
    }

    /// <summary>
    /// 淡入效果
    /// </summary>
    /// <param name="storyboard"></param>
    /// <param name="seconds"></param>
    public static void AddFadeIn(this Storyboard storyboard, float seconds)
    {
        var animation = new DoubleAnimation
        {
            Duration = new Duration(TimeSpan.FromSeconds(seconds)),
            From = 0,
            To = 1
        };
        Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
        storyboard.Children.Add(animation);
    }

    /// <summary>
    /// 淡出效果
    /// </summary>
    /// <param name="storyboard"></param>
    /// <param name="seconds"></param>
    public static void AddFadeOut(this Storyboard storyboard, float seconds)
    {
        var animation = new DoubleAnimation
        {
            Duration = new Duration(TimeSpan.FromSeconds(seconds)),
            From = 1,
            To = 0
        };
        Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
        storyboard.Children.Add(animation);
    }

}

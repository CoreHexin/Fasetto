using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Animation;

public static class PageAnimations
{
    /// <summary>
    /// 从右侧滑入加淡入效果
    /// </summary>
    /// <param name="page"></param>
    /// <param name="seconds"></param>
    /// <returns></returns>
    public static void SlideAndFadeInFromRight(this Page page, float seconds)
    {
        var storyboard = new Storyboard();
        storyboard.AddSlideFromRight(seconds, page.WindowWidth);
        storyboard.AddFadeIn(seconds);
        storyboard.Begin(page);
    }

    /// <summary>
    /// 向左侧滑出加淡出效果
    /// </summary>
    /// <param name="page"></param>
    /// <param name="seconds"></param>
    /// <returns></returns>
    public static void SlideAndFadeOutToLeft(this Page page, float seconds)
    {
        var storyboard = new Storyboard();
        storyboard.AddSlideToLeft(seconds, page.WindowWidth);
        storyboard.AddFadeOut(seconds);
        storyboard.Begin(page);
    }

}

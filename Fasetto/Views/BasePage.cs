using Fasetto.Animation;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Views;

public class BasePage : Page
{
    public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

    public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

    /// <summary>
    /// 动画的执行时间
    /// </summary>
    public float SlideSeconds { get; set; } = 0.8f;

    public BasePage()
    {
        Loaded += BasePage_Loaded;
    }

    private void BasePage_Loaded(object sender, RoutedEventArgs e)
    {
        AnimationIn();
    }

    private void AnimationIn()
    {
        if (PageLoadAnimation == PageAnimation.None)
            return;

        switch (PageLoadAnimation)
        {
            case PageAnimation.SlideAndFadeInFromRight:
                this.SlideAndFadeInFromRight(SlideSeconds);
                break;
        }
    }

    private void AnimationOut()
    {
        if (PageUnloadAnimation == PageAnimation.None)
            return;

        switch (PageUnloadAnimation)
        {
            case PageAnimation.SlideAndFadeOutToLeft:
                this.SlideAndFadeOutToRight(SlideSeconds);
                break;
        }
    }
}

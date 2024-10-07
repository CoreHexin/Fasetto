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
    public float SlideSeconds { get; set; } = 0.5f;

    /// <summary>
    /// 是否已加载过
    /// 如果页面因显示或隐藏而从可视树中移除，然后再加入，Loaded 事件也会再次触发。
    /// </summary>
    public bool HasLoaded { get; set; }

    public BasePage()
    {
        Loaded += BasePage_Loaded;
    }

    private void BasePage_Loaded(object sender, RoutedEventArgs e)
    {
        if (!HasLoaded)
        {
            AnimationIn();
            HasLoaded = true;
        }
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

    public void AnimationOut()
    {
        if (PageUnloadAnimation == PageAnimation.None)
            return;

        switch (PageUnloadAnimation)
        {
            case PageAnimation.SlideAndFadeOutToLeft:
                this.SlideAndFadeOutToLeft(SlideSeconds);
                break;
        }
    }
}

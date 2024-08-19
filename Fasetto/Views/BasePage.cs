using Fasetto.Animation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    private async void BasePage_Loaded(object sender, RoutedEventArgs e)
    {
        await AnimationIn();
    }

    private async Task AnimationIn()
    {
        if (PageLoadAnimation == PageAnimation.None)
            return;

        switch (PageLoadAnimation)
        {
            case PageAnimation.SlideAndFadeInFromRight:
                await this.SlideAndFadeInFromRight(SlideSeconds);
                break;
        }
    }

    private async Task AnimationOut()
    {
        if (PageUnloadAnimation == PageAnimation.None)
            return;

        switch (PageUnloadAnimation)
        {
            case PageAnimation.SlideAndFadeOutToLeft:
                await this.SlideAndFadeOutToRight(SlideSeconds);
                break;
        }
    }
}

namespace Fasetto.Animation;

/// <summary>
/// 页面进入和退出的动画效果
/// </summary>
public enum PageAnimation
{
    None,

    /// <summary>
    /// 页面从右边进入
    /// </summary>
    SlideAndFadeInFromRight,

    /// <summary>
    /// 页面从左边退出
    /// </summary>
    SlideAndFadeOutToLeft,
}

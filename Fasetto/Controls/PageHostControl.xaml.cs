﻿using Fasetto.Views;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Controls;

/// <summary>
/// PageHostControl.xaml 的交互逻辑
/// </summary>
public partial class PageHostControl : UserControl
{
    public static readonly DependencyProperty CurPageProperty = DependencyProperty.Register(
        nameof(CurPage), typeof(Page), typeof(PageHostControl), new PropertyMetadata(OnCurPageChanged));

    public Page CurPage
    {
        get { return (Page)GetValue(CurPageProperty); }
        set { SetValue(CurPageProperty, value); }
    }

    public PageHostControl()
    {
        InitializeComponent();
    }

    private static void OnCurPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var newPageFrame = ((PageHostControl)d).NewPage;
        var oldPageFrame = ((PageHostControl)d).OldPage;

        var oldPageContent = newPageFrame.Content;
        newPageFrame.Content = null;
        oldPageFrame.Content = oldPageContent;

        if (oldPageContent is BasePage oldPage)
        {
            // 触发页面退出动画
            oldPage.AnimationOut();

            // 页面退出动画完成后释放OldPage
            Task.Run(async () =>
            {
                await Task.Delay(1000);
                Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
            });
        }
        else
        {
            // 未应用动画的Page
            oldPageFrame.Visibility = Visibility.Collapsed;
            Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
        }

        newPageFrame.Content = e.NewValue;
    }
}

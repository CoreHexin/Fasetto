using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Fasetto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fasetto.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    /// <summary>
    /// 窗口外边距, 用来实现阴影效果, 当窗口最大化时，该值为0
    /// </summary>
    [ObservableProperty]
    private int _outerMarginSize = 10;

    /// <summary>
    /// 窗口圆角效果，当窗口最大化时，该值为0
    /// </summary>
    [ObservableProperty]
    private int _windowCornerRadius = 10;

    /// <summary>
    /// 调整窗口大小的边距
    /// </summary>
    [ObservableProperty]
    private int _resizeBorder = 16;

    [ObservableProperty]
    public ApplicationPage _currentPage = ApplicationPage.Login;

    /// <summary>
    /// 窗口状态
    /// </summary>
    private WindowState _currentWindowState;

    public WindowState CurrentWindowState
    {
        get { return _currentWindowState; }
        set
        {
            if (SetProperty(ref _currentWindowState, value))
            {
                if (value == WindowState.Maximized)
                {
                    OuterMarginSize = 0;
                    WindowCornerRadius = 0;
                    ResizeBorder = 0;
                }
                else
                {
                    OuterMarginSize = 10;
                    WindowCornerRadius = 10;
                    ResizeBorder = 16;
                }
            }
        }
    }

    public MainWindowViewModel()
    {
        CurrentWindowState = WindowState.Normal;
    }

    [RelayCommand]
    private void Minimize()
    {
        CurrentWindowState = WindowState.Minimized;
    }

    [RelayCommand]
    private void Maximize()
    {
        CurrentWindowState ^= WindowState.Maximized;
    }
}

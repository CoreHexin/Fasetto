using Fasetto.Helpers;
using Fasetto.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Fasetto.Views;

/// <summary>
/// MainWindow.xaml 的交互逻辑
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
        var resizer = new WindowResizer(this);
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void IconButton_click(object sender, RoutedEventArgs e)
    {
        SystemCommands.ShowSystemMenu(this, GetMousePosition());
    }

    /// <summary>
    /// 获取鼠标当前坐标
    /// </summary>
    /// <returns></returns>
    private Point GetMousePosition()
    {
        var postion = Mouse.GetPosition(this);
        if (this.WindowState == WindowState.Maximized)
            return postion;

        return new Point(postion.X + this.Left, postion.Y + this.Top);
    }

    /// <summary>
    /// 不保存导航历史
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainFrame_Navigated(object sender, NavigationEventArgs e)
    {
        if (sender is Frame frame)
        {
            frame.NavigationService.RemoveBackEntry();
        }
    }
}

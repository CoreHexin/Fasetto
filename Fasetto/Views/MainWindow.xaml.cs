using Fasetto.Helpers;
using Fasetto.ViewModels;
using System.Windows;
using System.Windows.Input;

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

    private void Window_Activated(object sender, EventArgs e)
    {
        (DataContext as MainWindowViewModel).DimmedOverlayVisible = false;
    }

    private void Window_Deactivated(object sender, EventArgs e)
    {
        (DataContext as MainWindowViewModel).DimmedOverlayVisible = true;
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

}

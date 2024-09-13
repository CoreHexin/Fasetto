using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Fasetto.ViewModels;

public partial class ChatPageViewModel : ObservableObject
{
    /// <summary>
    /// 是否展开侧边栏
    /// </summary>
    [ObservableProperty]
    private bool _showSideMenu;

    public ChatPageViewModel()
    {
        ShowSideMenu = true;
    }

    [RelayCommand]
    private void ToggleSideMenu()
    {
        ShowSideMenu = !ShowSideMenu;
    }
}

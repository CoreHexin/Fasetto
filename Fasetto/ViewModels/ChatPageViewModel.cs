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

    /// <summary>
    /// 是否显示附件菜单
    /// </summary>
    [ObservableProperty]
    private bool _isShowAttachmentMenu;

    [ObservableProperty]
    private bool _isShowEmojiMenu;

    public ChatPageViewModel()
    {
        ShowSideMenu = true;
    }

    [RelayCommand]
    private void ToggleSideMenu()
    {
        ShowSideMenu = !ShowSideMenu;
    }

    [RelayCommand]
    private void ToggleAttachmentMenu()
    {
        IsShowAttachmentMenu = !IsShowAttachmentMenu;
    }

    [RelayCommand]
    private void ToggleEmojiMenu()
    {
        IsShowEmojiMenu = !IsShowEmojiMenu;
    }
}

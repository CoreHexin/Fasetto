using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Models;
using Fasetto.Views;

namespace Fasetto.ViewModels;

public partial class ChatPageViewModel : ObservableRecipient, IRecipient<ValueChangedMessage<SettingsMessage>>
{
    /// <summary>
    /// 是否展开侧边栏
    /// </summary>
    [ObservableProperty]
    private bool _isShowSideMenu;

    /// <summary>
    /// 是否显示附件菜单
    /// </summary>
    [ObservableProperty]
    private bool _isShowAttachmentMenu;

    [ObservableProperty]
    private bool _isShowEmojiMenu;

    [ObservableProperty]
    private bool _isShowSettingsMenu;

    public ChatPageViewModel()
    {
        IsShowSideMenu = true;
        IsShowSettingsMenu = false;
        IsActive = true;
    }

    [RelayCommand]
    private void ToggleSideMenu()
    {
        IsShowSideMenu = !IsShowSideMenu;
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

    [RelayCommand]
    private void ToggleSettingsMenu()
    {
        IsShowSettingsMenu = !IsShowSettingsMenu;
    }

    [RelayCommand]
    private void Send()
    {
        new DialogWindow().ShowDialog();
    }

    public void Receive(ValueChangedMessage<SettingsMessage> message)
    {
        IsShowSettingsMenu = message.Value.IsShowSettingsMenu;
    }
}
